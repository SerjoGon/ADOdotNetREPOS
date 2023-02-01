using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection= new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

            try
            {
            DataSet setCounter= new DataSet();
            DataSet setProduct= new DataSet();
            SqlDataAdapter adapterCounter = new SqlDataAdapter("SELECT * FROM Counter", connection.ConnectionString);
            SqlDataAdapter adapterProduct = new SqlDataAdapter("SELECT * FROM Product", connection.ConnectionString);
                adapterCounter.Fill(setCounter);
                adapterProduct.Fill(setProduct);
                SqlCommandBuilder builderCounter= new SqlCommandBuilder(adapterCounter);
                SqlCommandBuilder builderProduct= new SqlCommandBuilder(adapterProduct);
                adapterCounter.InsertCommand = builderCounter.GetInsertCommand();
                adapterProduct.InsertCommand = builderProduct.GetInsertCommand();
                adapterCounter.UpdateCommand= builderCounter.GetUpdateCommand();
                adapterProduct.UpdateCommand = builderProduct.GetUpdateCommand();
                adapterCounter.DeleteCommand= builderCounter.GetDeleteCommand();
                adapterProduct.DeleteCommand= builderProduct.GetDeleteCommand();
                //DataRow dr = setCounter.Tables[0].NewRow();
                //dr.SetField(0, 2);
                //dr.SetField(1, "PhilipMoris");
                //dr.SetField(2, 500);
                //dr.SetField(3, DateTime.Now);
                ////setCounter.Tables[0].Rows.Add(dr);
                //setCounter.Tables[0].Rows.Add(3,"BAT",666,DateTime.Now);
                //adapterCounter.Update(setCounter);
                /*for(int i = 4; i < 50; i++)
                {
                    setCounter.Tables[0].Rows.Add(i,"newprovider"+i,33+i,DateTime.Now);  
                }
                adapterCounter.Update(setCounter);*/
                int maxcount = 0;
                string countername = "";
                foreach(DataRow dr in setCounter.Tables[0].Rows)
                {
                    if(dr.Field<int>("Count")>maxcount)
                    {
                        maxcount= dr.Field<int>("Count");
                        countername = dr.Field<string>("CounterName");
                    }
                }
                Console.WriteLine(countername + " : " + maxcount + " " + "tovarov");
                DataViewManager dvm = new DataViewManager(setCounter);
                DataView dv = dvm.CreateDataView(setCounter.Tables[0]);
                dv.RowFilter = "Count = MAX(Count)";
                Console.WriteLine(dv.Count);

                /*Console.WriteLine(builderProduct.GetInsertCommand().CommandText);
                Console.WriteLine(builderProduct.GetUpdateCommand().CommandText);
                Console.WriteLine(builderProduct.GetDeleteCommand().CommandText);
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName= "@p1";
                sqlParameter.Value = "drop table counter";
                SqlCommand command = new SqlCommand("SELECT * FROM Counter WHERE id = @p1");
                command.Parameters.Add(sqlParameter);*/
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);      
            }
            Console.ReadLine();
        }
    }
}
