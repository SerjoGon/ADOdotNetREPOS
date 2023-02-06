using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopwithSQLDB
{

    public partial class BookShop : Form
    {
        SqlDataAdapter adapterBooks = null;
        SqlDataAdapter adapterStatistics = null;
        SqlConnection conn = new SqlConnection();
        SqlCommandBuilder cmdbld = new SqlCommandBuilder();
        SqlCommandBuilder cmdbld2 = new SqlCommandBuilder();
        SqlDataReader reader = null;
        DataSet dataSetBooks = new DataSet();
        DataSet dataSetStatistics = new DataSet();
        public BookShop()
        {
            InitializeComponent();
        }

        private void topMonthsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab == pageBook)
                {
                    int lastid = 1;
                    if (dataSetBooks.Tables[0].Rows.Count > 0)
                    {
                        lastid = (int)dataSetBooks.Tables[0].Rows[dataSetBooks.Tables[0].Rows.Count - 1][0] + 1;
                    }
                    Addbooks addbook = new Addbooks(lastid);
                    if (addbook.ShowDialog() == DialogResult.OK)
                    {
                        dataSetBooks.Tables[0].Rows.Add(
                            Int32.Parse(addbook.tb_bookID.Text),
                            addbook.tb_bookname.Text,
                            addbook.tb_authorname.Text,
                            addbook.tb_genre.Text,
                            addbook.tb_publisher.Text,
                            addbook.tb_datepublish.Text,
                            Int32.Parse(addbook.tb_price.Text)
                            );
                    }
                    addbook.Dispose();
                }
                else if (tabControl.SelectedTab == pageStatistics)
                {
                    
                }
            }
            catch (Exception ex)
            {
                ts_status.Text = ex.Message;
            }
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == pageBook && dgv1.SelectedRows.Count > 0)
            {
                DataRow editRow = dataSetBooks.Tables[0].Rows[dgv1.SelectedRows[0].Index];
                Editbook ec = Editbook((int)editRow[0], (string)editRow[1]);
                if (ec.ShowDialog() == DialogResult.OK)
                {
                    dataSetBooks.Tables[0].Rows[dgv1.SelectedRows[0].Index].SetField(0, Int32.Parse(ec.tb_bookID.Text));
                    dataSetBooks.Tables[0].Rows[dgv1.SelectedRows[0].Index].SetField(1, ec.tb_editbookname.Text);
                    dataSetBooks.Tables[0].Rows[dgv1.SelectedRows[0].Index].SetField(2, ec.tb_edit_authorname.Text);
                    dataSetBooks.Tables[0].Rows[dgv1.SelectedRows[0].Index].SetField(3, ec.tb_edit_genre.Text);
                    dataSetBooks.Tables[0].Rows[dgv1.SelectedRows[0].Index].SetField(4, ec.tb_edit_publisher.Text);
                    dataSetBooks.Tables[0].Rows[dgv1.SelectedRows[0].Index].SetField(5, ec.tb_edit_datepublish.Text);
                    dataSetBooks.Tables[0].Rows[dgv1.SelectedRows[0].Index].SetField(6, Int32.Parse(ec.tb_edit_price.Text));
                }
            }
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adapterBooks == null)
            {
                dgv1.Rows.Clear();
                dgv1.Columns.Clear();
                dgv2.Rows.Clear();
                dgv2.Columns.Clear();
            }
            else
            {
                adapterBooks = null; adapterStatistics = null;
                dataSetBooks = new DataSet(); dataSetStatistics = new DataSet();
            }
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["BookShop"].ConnectionString;
            try
            {
                adapterBooks = new SqlDataAdapter("select * from Books", conn.ConnectionString);
                adapterBooks.Fill(dataSetBooks);
                dgv1.DataSource = dataSetBooks.Tables[0];
                adapterStatistics = new SqlDataAdapter("select * from StatisticsBook", conn.ConnectionString);
                adapterStatistics.Fill(dataSetStatistics);
                dgv2.DataSource = dataSetStatistics.Tables[0];
                ts_status.Text = "Connection to BD success";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
