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
    public partial class AddprodForm : Form
    {
        int lastid;
        public AddprodForm(int id)
        {
            lastid = id;
            InitializeComponent();
        }

        private void AddprodForm_Load(object sender, EventArgs e)
        {
            tb_idproduct.Text = lastid.ToString();
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
