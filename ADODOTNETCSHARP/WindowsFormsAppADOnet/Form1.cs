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

namespace WindowsFormsAppADOnet
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapterCategory = null;
        SqlDataAdapter adapterGoods = null;
        SqlConnection conn = new SqlConnection();
        SqlCommandBuilder cmdbld = new SqlCommandBuilder();
        SqlDataReader reader = null;
        DataSet dataSetGoods = new DataSet();
        DataSet dataSetCategory = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void connectToBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            if (tabControl1.SelectedTab == tabPage1)
            {
                int lastid = 1;
                if (dataSetCategory.Tables[0].Rows.Count > 0)
                {
                    ts_status.Text = dataGridView1.Rows.Count.ToString();
                    lastid = (int)dataSetCategory.Tables[0].Rows[dataSetCategory.Tables[0].Rows.Count - 1][0] + 1;
                }
                AddCategory ac = new AddCategory(lastid);
                if (ac.ShowDialog() == DialogResult.OK )
                {
                    dataSetCategory.Tables[0].Rows.Add(Int32.Parse(ac.tb_id.Text), ac.tb_name.Text);
                }
                ac.Dispose();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {

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
            else if (tabControl1.SelectedTab == tabPage2)
            {

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

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmdbld = new SqlCommandBuilder(adapterCategory);
            adapterCategory.DeleteCommand = cmdbld.GetDeleteCommand();
            adapterCategory.InsertCommand = cmdbld.GetInsertCommand();
            adapterCategory.UpdateCommand = cmdbld.GetUpdateCommand();
            adapterCategory.Update(dataSetCategory);
        }
    }
}
