﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CarKeywords
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
           
          return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
