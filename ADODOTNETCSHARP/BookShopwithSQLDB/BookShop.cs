using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopwithSQLDB
{

    public partial class BookShop : Form
    {
        /*SqlDataAdapter adapterBooks = null;
        SqlDataAdapter adapterStatistics = null;
        SqlConnection conn = new SqlConnection();
        SqlCommandBuilder cmdbld = new SqlCommandBuilder();
        SqlCommandBuilder cmdbld2 = new SqlCommandBuilder();
        */
        SqlDataReader reader = null;
        DataSet dataSetBooks = new DataSet();
        DataSet dataSetStatistics = new DataSet();
        public BookShop()
        {
            InitializeComponent();
        }
        private void LoadDataIntoDataGridView()
        {
            List<BookTable> books = new List<BookTable>();

            using (BookShopDBNEWEntities db = new BookShopDBNEWEntities())
            {
                books = db.BookTable.ToList();
            }
            dgv1.DataSource = books;
        }
        private void topMonthsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Addbooks ab = new Addbooks();
            try
            {
                int index = dgv1.Rows.Count - 1;
                /*using (BookShopDBNEWEntities db = new BookShopDBNEWEntities())
                {
                    BookTable book = new BookTable(
                        Int32.Parse( ab.tb_bookID.Text),
                        ab.tb_bookname.Text,
                        ab.tb_authorname.Text,
                        ab.tb_genre.Text,
                        ab.tb_publisher.Text,
                        DateTime.Parse(ab.tb_datepublish.Text),
                        decimal.Parse(ab.tb_price.Text),false,false
                        );
                    db.BookTable.Add(book);
                    db.SaveChanges();
                }*/
                MessageBox.Show("Book added to the Bookstore.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataIntoDataGridView();
            }
            catch(Exception ex) { ts_status.Text = ex.ToString(); }
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgv1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int bookId = Convert.ToInt32(dgv1.Rows[index].Cells["Id"].Value);
            using (BookShopDBNEWEntities db = new BookShopDBNEWEntities())
            {
                BookTable book = db.BookTable.Find(bookId);
                db.BookTable.Remove(book);
                db.SaveChanges();
            }
            MessageBox.Show("Book remove from the store.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataIntoDataGridView();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BookShopDBNEWEntities bookDBEntities = new BookShopDBNEWEntities())
            {
                List<BookTable> books = bookDBEntities.BookTable.ToList();
                dgv1.DataSource = books;
            } 
        }

        private void BookShop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookShopDBNEWDataSet.BookTable' table. You can move, or remove it, as needed.
            this.bookTableTableAdapter.Fill(this.bookShopDBNEWDataSet.BookTable);

        }

        private void addrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Add();
        }
    }
}
