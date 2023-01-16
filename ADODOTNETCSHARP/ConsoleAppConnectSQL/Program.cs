using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConnectSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
        MySqlConnection mysql = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
            mysql.Open();
            Console.WriteLine("Open");
            mysql.CreateCommand();
            MySqlCommand mysqlCommand = new MySqlCommand("select count(*) FROM Books",mysql);
            MySqlDataReader reader = mysqlCommand.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine(reader.GetValue(0));
            }
            Console.WriteLine("Done");
            mysql.Close();
            Console.WriteLine("Close");
            Console.ReadLine(); 
        }
    }
}
