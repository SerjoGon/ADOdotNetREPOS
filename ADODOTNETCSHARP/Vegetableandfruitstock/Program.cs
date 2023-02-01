using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetableandfruitstock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connstr = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            Random rand = new Random();
            try 
            {
                connection.Open();
                SqlCommand insertcommand = new SqlCommand();
                insertcommand.Connection = connection;
                for(int i = 0; i <=25; i++)
                {
                    insertcommand.CommandText += "insert into VegetableStock" + 
                        "(Id, Name, Type, Color, Calories)"
                }
            }
        }
    }
}
