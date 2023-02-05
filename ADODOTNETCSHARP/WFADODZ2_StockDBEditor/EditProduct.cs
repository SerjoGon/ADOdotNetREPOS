using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFADODZ2_StockDBEditor
{
    public partial class EditProduct : Form
    {
        int Idprod;
        string Nameprod;
        string Typeprod;
        int ProvID;
        public EditProduct(int idprod,string nameprod, string typeprod,int provID)
        {
            InitializeComponent();
            Idprod = idprod;
            Nameprod = nameprod;
            Typeprod = typeprod;
            ProvID = provID;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            tb_idproduct.Text = Idprod.ToString();
            tb_nameproduct.Text = Nameprod.ToString();
            tb_typeproduct.Text = Typeprod.ToString();
            tb_provID.Text = ProvID.ToString();
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancelproduct_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
