using System;
using System.Collections.Generic;
using System.Text;

namespace CarKeywords
{
    public class Car
    {

        public int Id { get; set; }
        public string English { get; set; }
        public string German { get; set; }
    


        public string FullInfo
        {
            get
            {
                return $"{Id},  {English},  {German}";
            }
        }

        public override string ToString()
        {
            return FullInfo.ToString();
        }

        



    }
}
