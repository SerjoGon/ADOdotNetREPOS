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

namespace WindowsFormsAppADOnet
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapterCategory = null;
        SqlDataAdapter adapterGoods = null;
        SqlConnection conn = new SqlConnection();
        SqlConnection connAsync = new SqlConnection();
        SqlCommandBuilder cmdbld = new SqlCommandBuilder();
        SqlCommandBuilder cmdbld2 = new SqlCommandBuilder();
        SqlDataReader reader = null;
        DataSet dataSetGoods = new DataSet();
        DataSet dataSetCategory = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void connectToBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adapterCategory == null)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
            }
            else 
            {
                adapterCategory = null; adapterGoods = null;
                dataSetCategory = new DataSet();dataSetGoods = new DataSet();
            }
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            try
            {
                adapterCategory = new SqlDataAdapter("select * from Category", conn.ConnectionString);
                adapterCategory.Fill(dataSetCategory);
                dataGridView1.DataSource = dataSetCategory.Tables[0];
                adapterGoods = new SqlDataAdapter("select * from Goods", conn.ConnectionString);
                adapterGoods.Fill(dataSetGoods);
                dataGridView2.DataSource = dataSetGoods.Tables[0];
                ts_status.Text = "Connection to BD success";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ts_status.Text = "All Data read success";
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabPage1)
                {
                    int lastid = 1;
                    if (dataSetCategory.Tables[0].Rows.Count > 0)
                    {
                        lastid = (int)dataSetCategory.Tables[0].Rows[dataSetCategory.Tables[0].Rows.Count - 1][0] + 1;
                    }
                    AddCategory ac = new AddCategory(lastid);
                    if (ac.ShowDialog() == DialogResult.OK)
                    {
                        dataSetCategory.Tables[0].Rows.Add(Int32.Parse(ac.tb_id.Text), ac.tb_name.Text);
                    }
                    ac.Dispose();
                }
                else if (tabControl1.SelectedTab == tabPage2)
                {
                    int lastid = 1;
                    if (dataSetGoods.Tables[0].Rows.Count > 0)
                    {
                        lastid = (int)dataSetGoods.Tables[0].Rows[dataSetGoods.Tables[0].Rows.Count - 1][0] + 1;
                    }
                    AddGoods ag = new AddGoods(lastid);
                    if (ag.ShowDialog() == DialogResult.OK)
                    {
                        dataSetGoods.Tables[0].Rows.Add(
                            Int32.Parse(ag.tb_id.Text),
                            ag.tb_name.Text,
                            Int32.Parse(ag.tb_cat_id.Text),
                            Int32.Parse(ag.tb_price.Text),
                            Int32.Parse(ag.tb_count.Text)
                            );
                    }
                    ag.Dispose();
                }
            }
            catch (Exception ex)
            {
                ts_status.Text = ex.Message;
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1 && dataGridView1.SelectedRows.Count > 0)
            {
                DataRow editRow = dataSetCategory.Tables[0].Rows[dataGridView1.SelectedRows[0].Index];
                EditCategory ec = new EditCategory((int)editRow[0], (string)editRow[1]);
                if (ec.ShowDialog() == DialogResult.OK)
                {
                    dataSetCategory.Tables[0].Rows[dataGridView1.SelectedRows[0].Index].SetField(0, Int32.Parse(ec.tb_id.Text));
                    dataSetCategory.Tables[0].Rows[dataGridView1.SelectedRows[0].Index].SetField(1, ec.tb_name.Text);
                }
            }
            else if (tabControl1.SelectedTab == tabPage2 && dataGridView2.SelectedRows.Count > 0)
            {
                DataRow editRow = dataSetGoods.Tables[0].Rows[dataGridView2.SelectedRows[0].Index];
                EditGoods eg = new EditGoods((int)editRow[0], (string)editRow[1], (int)editRow[2], (int)editRow[3], (int)editRow[4]);
                if (eg.ShowDialog() == DialogResult.OK)
                {
                    dataSetGoods.Tables[0].Rows[dataGridView2.SelectedRows[0].Index].SetField(0, Int32.Parse(eg.tb_id.Text));
                    dataSetGoods.Tables[0].Rows[dataGridView2.SelectedRows[0].Index].SetField(1, eg.tb_name.Text);
                    dataSetGoods.Tables[0].Rows[dataGridView2.SelectedRows[0].Index].SetField(2, Int32.Parse(eg.tb_cat_id.Text));
                    dataSetGoods.Tables[0].Rows[dataGridView2.SelectedRows[0].Index].SetField(3, Int32.Parse(eg.tb_price.Text));
                    dataSetGoods.Tables[0].Rows[dataGridView2.SelectedRows[0].Index].SetField(4, Int32.Parse(eg.tb_count.Text));
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    dataSetCategory.Tables[0].Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                if (dataGridView2.SelectedRows.Count > 0 && dataGridView2.SelectedRows[0].Cells[0].Value != null)
                    dataSetGoods.Tables[0].Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connAsync.ConnectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
                connAsync.ConnectionString += ";Asynchronous Processing=true";
                await connAsync.OpenAsync();
                SqlCommand sqlcomm = new SqlCommand("select * from Category", connAsync);
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
                                    dataGridView1.Columns.Add(reader.GetName(i).ToString(), reader.GetName(i).ToString());
                                }
                            }
                            line++;
                            dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString());
                        }
                    }
                    while (await reader.NextResultAsync());
                }
            }
            catch (Exception ex)
            {
                ts_status.Text = ex.Message;
            }
            finally { connAsync.Close(); }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Сохранить данные работы в БД?", "Обновление БД", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK && adapterGoods != null && adapterCategory != null)
            {
                cmdbld = new SqlCommandBuilder(adapterCategory);
                adapterCategory.DeleteCommand = cmdbld.GetDeleteCommand();
                adapterCategory.InsertCommand = cmdbld.GetInsertCommand();
                adapterCategory.UpdateCommand = cmdbld.GetUpdateCommand();
                adapterCategory.Update(dataSetCategory);

                cmdbld2 = new SqlCommandBuilder(adapterGoods);
                adapterGoods.DeleteCommand = cmdbld2.GetDeleteCommand();
                adapterGoods.InsertCommand = cmdbld2.GetInsertCommand();
                adapterGoods.UpdateCommand = cmdbld2.GetUpdateCommand();
                adapterGoods.Update(dataSetGoods);
            }
        }
    }
}
