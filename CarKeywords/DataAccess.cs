using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Linq;
using System.Data.SqlClient;

namespace CarKeywords
{
    public class DataAccess
    {

        public List<Car> GetListOfKeywords(string EnglishKeyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("KeywordsDB")))
                if (EnglishKeyword.Count() > 0)
            {

               
                {
                    return connection.Query<Car>($"select * from dbo.Tabelle1$ where English like '{EnglishKeyword}%'").ToList();
                }
            }

            else
            {
                return connection.Query<Car>($"select * from dbo.Tabelle1$").ToList();
            }


        }


        public List<Car> GetListOfKeywordsGerman(string GermanKeyword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("KeywordsDB")))
                if (GermanKeyword.Count() > 0)
                {


                    {
                        return connection.Query<Car>($"select * from dbo.Tabelle1$ where German like '{GermanKeyword}%'").ToList();
                    }
                }

                else
                {
                    return connection.Query<Car>($"select * from dbo.Tabelle1$").ToList();
                }


        }








        //write into database for storage

        public void UseDataBase(string a, string b, string d)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("InformationDB")))
            {
                connection.Query($"insert into dbo.save_tbl values ('{a}','{b}','{d}')");
                

            }





        }





        //public List<Car> GetListOfKeywords()
        //{


        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("KeywordsDB")))
        //    {
        //        return connection.Query<Car>($"select * from dbo.keyword_table").ToList();
        //    }

        //}




    }
}
