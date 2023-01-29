﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace VegetableFormDZ
{
    public partial class VegetableBaseDB : Form
    {
        SqlDataAdapter adapterVegetable = null;
        SqlConnection connection = new SqlConnection();
        SqlConnection asyncconnection = new SqlConnection();
        SqlCommandBuilder commandbuilder = new SqlCommandBuilder();
        SqlDataReader reader = null;
        DataSet datasetveget = new DataSet();
        public VegetableBaseDB()
        {
            InitializeComponent();

        }

        private void connectToBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adapterVegetable == null)
            {
                datagridviev.Rows.Clear();
                datagridviev.Columns.Clear();
            }
            else
            {
                adapterVegetable = null;
                datasetveget = new DataSet();
            }
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            try
            {
                adapterVegetable = new SqlDataAdapter("select * from Vegetable", connection.ConnectionString);
                adapterVegetable.Fill(datasetveget);
                datagridviev.DataSource = datasetveget.Tables[0];
                statuslbl.Text = "Connection to DB success";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                statuslbl.Text = "All data read success";
            }
        }

        private async void VegetableBaseDB_Load(object sender, EventArgs e)
        {
            try
            {
                asyncconnection.ConnectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
                asyncconnection.ConnectionString += ";Asynchronous Processing=true";
                await asyncconnection.OpenAsync();
                SqlCommand sqlcomm = new SqlCommand(/*"WAITFOR DELAY '00:00:05';*/"select * from Vegetable", asyncconnection);
                reader = await sqlcomm.ExecuteReaderAsync();
                if(reader != null)
                {
                    int line = 0;
                    do
                    {
                        while(await reader.ReadAsync())
                        {
                            if(line == 0)
                            {
                                for(int i = 0; i < reader.FieldCount; i++)
                                {
                                    datagridviev.Columns.Add(reader.GetName(i).ToString(),reader.GetName(i).ToString());
                                }
                            }
                            line++;
                            datagridviev.Rows.Add(reader[0].ToString(), reader[1].ToString());
                        }
                    }
                    while(await reader.NextResultAsync());
                }
            }
            catch(Exception ex)
            { statuslbl.Text = ex.Message; }
            finally { asyncconnection.Close(); }

        }
    }
}
