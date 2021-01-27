using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using CsvHelper;


namespace CarKeywords
{
    public partial class Form1 : Form
    {

        Image image;
        Image image2;
        public string path;
        public string newPath = " ";
        List<Car> cars = new List<Car>();
        public string keywords = "";
        public string[] keywordArray = new string[] { };
        public string fileNameCsv = "";
        public string compare = "";
        public string directoryName;
        public string[] files;
        public DateTime today = DateTime.Now;
        public bool fileExists = false;
        
        







        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            searchTextBox.PlaceholderText = "search...";
            GermanTextBox.PlaceholderText = "suchen...";

            //textBox1.PlaceholderText = "enter keyword";


        }



        // OPEN BUTTON
        //______________________________________________________________________
        //______________________________________________________________________
        public void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPG(*.JPG)|*.jpg";





            if (open.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(open.FileName);
                image2 = image;

                carPictureBox.Image = image2;

                carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            path = open.FileName;
           
            open.Dispose();

        }




        //SAVE BUTTON
        //______________________________________________________________________
        //______________________________________________________________________

        public void buttonSave_Click(object sender, EventArgs e)
        {






            using (SaveFileDialog f = new SaveFileDialog() { Filter = "JPG|*.jpg", ValidateNames = true, FileName = "" })

            {



                //this is checked in the meta.WriteData method. The save window should not be opened twice 
                //if (f.ShowDialog() == DialogResult.OK)
                //{





                // Lambda expression and Linq
                keywordArray = keywordList.Items.OfType<object>().Select(item => item.ToString()).ToArray();
                keywords = string.Join(",", keywordArray);



                //______________________________________________________________________
                //______________________________________________________________________


                //EXIF FOR EDITING METADATA

                MetaData meta = new MetaData();
                meta.WriteData(path, keywords);

                fileExists = meta.fileExists;


                //______________________________________________________________________
                //______________________________________________________________________








                //first the program checks if the file is actually saved and then performs following actions
                //This part deletes the image in the folder where it was opened
                if (fileExists == true)
                {


                    //clear keywordlist
                    keywordList.Items.Clear();
                    //carPictureBox.Image.Dispose();

                    //clear checklistbox
                    for (int i = 0; i < checkedListBoxEnglish.Items.Count; i++)
                    {
                        checkedListBoxEnglish.SetItemCheckState(i, CheckState.Unchecked);

                    }




                    //Here add the keywords after clicking save
                    //Every time the operator clicks save the keywords and the file name are saved into the listview.



                    ListViewItem itemId = new ListViewItem(meta.fileLocation);


                    itemId.SubItems.Add(keywords);
                    listViewKeywords.Items.Add(itemId);



                    //____________________________________________________________________________________
                    //____________________________________________________________________________________
                    //here we create a backup of the table with the keywords and the current date in sql 

                    //write to database

                    DataAccess dataBase = new DataAccess();

                    string a = meta.fileLocation;
                    string b = keywords;
                    string d = today.ToShortDateString();

                    dataBase.UseDataBase(a, b, d);

                    //____________________________________________________________________________________
                    //____________________________________________________________________________________






                    if (File.Exists(path))
                    {

                        image.Dispose();
                        File.Delete(path);
                    }



                    //creating array of strings with the file paths to the other images that have not been deleted yet.
                    //with this code the user can open the next image when clicking on the save button
                    //no need for opening again

                    directoryName = Path.GetDirectoryName(path);
                    files = Directory.GetFiles(directoryName);

                    path = files[0].ToString();



                    image = Image.FromFile(files[0]);
                    carPictureBox.Image = image;
                    files = files.Skip(1).ToArray();



                    buttonOpen.Visible = false;
                    buttonSave.Text = "Save and Next";
                }

                else
                {
                    MessageBox.Show($"File not saved and not deleted, FileExists = {fileExists}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    image = null;
                 
                    carPictureBox.Image = image;
                    buttonOpen.Visible = false;
                    buttonSave.Visible = false;


                }



            }



        }


        // Add Button 
        //I have removed this from the program 
        //______________________________________________________________________
        //______________________________________________________________________

        //private void addButton_Click(object sender, EventArgs e)
        //{
        //    string item = this.textBox1.Text.ToString();

        //    if(item.Length <= 0)
        //    {
        //        MessageBox.Show("Please enter Keyword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
        //    }
        //    else
        //    {
        //        keywordList.Items.Add(item);
        //        this.textBox1.Clear();
        //        this.textBox1.Focus();
        //    }
        //}



        //Button remove All
        //______________________________________________________________________
        //______________________________________________________________________

        private void button2_Click(object sender, EventArgs e)
        {

            this.keywordList.Items.Clear();
            //this.textBox1.Focus();

            for (int i = 0; i < checkedListBoxEnglish.Items.Count; i++)
            {
                checkedListBoxEnglish.SetItemCheckState(i, CheckState.Unchecked);

            }

        }



        //Button Remove selected Item
        //______________________________________________________________________
        //______________________________________________________________________

        private void button1_Click(object sender, EventArgs e)
        {
            if (keywordList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Keyword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                keywordList.Items.RemoveAt(keywordList.SelectedIndex);

            }


        }





        //Add checked keywords into listbox
        //______________________________________________________________________
        //______________________________________________________________________

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                int index = checkedListBoxEnglish.SelectedItem.ToString().IndexOf(",");
                string newString = checkedListBoxEnglish.SelectedItem.ToString().Remove(0, index + 1);
                int index2 = newString.IndexOf(",");
                string newString2 = newString.Remove(0, index2 + 2);
                newString2.Trim();



                //with this only one instance of the same keyword can be added
                if (keywordList.Items.Contains(newString2))
                {
                    MessageBox.Show("Keyword already selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    keywordList.Items.Add(newString2);
                }


                //or add all of the selected content to the keywordList with this code:
                //keywordList.Items.Add(checkedListBoxEnglish.SelectedItem.ToString());

            }
            else
            {
                keywordList.Items.Remove(checkedListBoxEnglish.SelectedItem.ToString());


            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        //Search Database for keyword
        //______________________________________________________________________
        //______________________________________________________________________
        private void SearchButton_Click(object sender, EventArgs e)
        {

            DataAccess dataBase = new DataAccess();
            cars = dataBase.GetListOfKeywords(searchTextBox.Text);
            //cars = dataBase.GetListOfKeywords();

            checkedListBoxEnglish.DataSource = cars;
            checkedListBoxEnglish.DisplayMember = "FullInfo";
            checkedListBoxEnglish.Visible = true;


        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SearchButton_Click(sender, e);
            }
        }



        //Export to csv file
        public async void ExportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        fileNameCsv = sfd.FileName;
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("ID, Keywords");

                        foreach (ListViewItem item in listViewKeywords.Items)
                        {
                            sb.AppendLine(string.Format("{0};;;;;; {1}", item.SubItems[0].Text, item.SubItems[1].Text));

                        }

                        await sw.WriteLineAsync(sb.ToString());
                        MessageBox.Show("Data Exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

            }

            listViewKeywords.Items.Clear();

        }



        // Write to existing csv file
        private void appendButton_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();



            foreach (ListViewItem item in listViewKeywords.Items)
            {
                string s = sb.AppendLine(string.Format("{0};;;;;; {1}", item.SubItems[0].Text, item.SubItems[1].Text)).ToString();




                using (StreamWriter sw = File.AppendText(fileNameCsv))
                {
                    sw.WriteLine(s);
                    MessageBox.Show("Data Exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }

            listViewKeywords.Items.Clear();


        }

        private void keywordList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GermanSearchButton_Click(object sender, EventArgs e)
        {
            DataAccess dataBase = new DataAccess();
            cars = dataBase.GetListOfKeywordsGerman(GermanTextBox.Text);
            //cars = dataBase.GetListOfKeywords();

            checkedListBoxEnglish.DataSource = cars;
            checkedListBoxEnglish.DisplayMember = "FullInfo";
            checkedListBoxEnglish.Visible = true;
        }


        //______________________________________________________________________
        //______________________________________________________________________
    }
}
