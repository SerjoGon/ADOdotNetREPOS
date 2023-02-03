using System;
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
        SqlCommand sqlcomm = null;
        //string connstr = null;
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
                adapterVegetable = new SqlDataAdapter("select * from StockTable", connection.ConnectionString);
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
           /* try
            {
                asyncconnection.ConnectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
                asyncconnection.ConnectionString += ";Asynchronous Processing=true";
                await asyncconnection.OpenAsync();
                sqlcomm = new SqlCommand("select * from StockTable", asyncconnection);
                reader = await sqlcomm.ExecuteReaderAsync();
                if (reader != null)
                {
                    int line = 0;
                    do
                    {
                        while (await reader.ReadAsync())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    datagridviev.Columns.Add(reader.GetName(i).ToString(), reader.GetName(i).ToString());
                                }
                            }
                            line++;
                            datagridviev.Rows.Add(reader[0].ToString(), reader[1].ToString());
                        }
                    }
                    while (await reader.NextResultAsync());
                }
            }
            catch (Exception ex)
            { statuslbl.Text = ex.Message; }
            finally { asyncconnection.Close(); }*/

        }

        private void VegetableBaseDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult dr = MessageBox.Show("Сохранить данные работы в БД?", "Обновление БД", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK && adapterVegetable != null)
            {
                commandbuilder = new SqlCommandBuilder(adapterVegetable);
                adapterVegetable.DeleteCommand = commandbuilder.GetDeleteCommand();
                adapterVegetable.InsertCommand = commandbuilder.GetInsertCommand();
                adapterVegetable.UpdateCommand = commandbuilder.GetUpdateCommand();
                adapterVegetable.Update(datasetveget);
            }*/
        }

        private void maxCaloriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            try
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
                adapterVegetable = new SqlDataAdapter("select MAX(Calories) from StockTable", connection.ConnectionString);
                adapterVegetable.Fill(datasetveget);
                datagridviev.DataSource = datasetveget.Tables[0];
            }
            catch(Exception ex)
            {
                statuslbl.Text = ex.Message;
            }
        }

        private void minCaloriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            try
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
                adapterVegetable = new SqlDataAdapter("select MIN(Calories) from StockTable", connection.ConnectionString);
                adapterVegetable.Fill(datasetveget);
                datagridviev.DataSource = datasetveget.Tables[0];
            }
            catch (Exception ex)
            {
                statuslbl.Text = ex.Message;
            }
        }

        private void averageCaloriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            try
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
                adapterVegetable = new SqlDataAdapter("select AVG(Calories) from StockTable", connection.ConnectionString);
                adapterVegetable.Fill(datasetveget);
                datagridviev.DataSource = datasetveget.Tables[0];
            }
            catch (Exception ex)
            {
                statuslbl.Text = ex.Message;
            }
        }
    }
}
