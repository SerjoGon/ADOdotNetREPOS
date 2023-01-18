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
        SqlCommand cmd = new SqlCommand();  
        SqlDataReader reader = null;
        DataSet dataSetGoods= new DataSet();
        DataSet dataSetCategory= new DataSet();
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
                if (dataGridView1.Rows.Count > 1)
                {
                    lastid = (int)dataGridView1.Rows[dataGridView1.Rows.Count -1 ].Cells[1].Value;
                }
                AddCategory ac = new AddCategory(lastid);
                if (ac.ShowDialog() == DialogResult.OK)
                {
                    dataSetCategory.Tables[0].Rows.Add(Int32.Parse(ac.tb_id.Text), ac.tb_name.Text);
                    //dataGridView1.Rows.Add(Int32.Parse(ac.tb_id.Text), Int32.Parse(ac.tb_name.Text));
                }
                ac.Dispose();
            }
            else if(tabControl1.SelectedTab == tabPage2)
            {

            }
        }
    }
}
