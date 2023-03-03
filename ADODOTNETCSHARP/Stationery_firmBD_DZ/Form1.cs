using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stationery_firmBD_DZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void loaddataGV()
        {
            List<Product> prod = new List<Product>();
            List<Managers> managers = new List<Managers>();
            List<Firm_buyer> firms = new List<Firm_buyer>();
            List<Sales> sales = new List<Sales>();
            using (Stationery_firm_DBEntities db = new Stationery_firm_DBEntities())
            {
                prod = db.Product.ToList();
                managers = db.Managers.ToList();
                firms = db.Firm_buyer.ToList();
                sales = db.Sales.ToList();
            }
            dgv_Product.DataSource = prod;
            dgv_Managers.DataSource = managers;
            dgv_Firms.DataSource = firms;
            dgv_Sales.DataSource = sales;
        }
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loaddataGV();
        }
    }
}
