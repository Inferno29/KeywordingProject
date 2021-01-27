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
using ExifLibrary;


namespace CarKeywords
{
   public class MetaData
    {
        public string fileLocation;
        public bool fileExists = true;

        public void WriteData(string fileName, string keywords)
        {
            
            var file = ImageFile.FromFile(fileName);
            
            file.Properties.Set(ExifTag.WindowsKeywords, keywords);
            file.Properties.Remove(ExifTag.WindowsComment);

            using (SaveFileDialog f = new SaveFileDialog() { Filter = "JPG|*.jpg", ValidateNames = true, FileName = "keyword" })
            {
                 string imageName = f.FileName;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (f.FileName.Length > 0)
                    {
                        file.Save(f.FileName);
                        fileLocation = f.FileName;
                        
                    }
                    else
                    {
                        
                        MessageBox.Show("Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }

                    
                }

            
              


            }

          
            

            if(File.Exists(fileLocation))
            {
                fileExists = true;
            }
            else
            {
                fileExists = false;
            }



        }


       





    }
}
