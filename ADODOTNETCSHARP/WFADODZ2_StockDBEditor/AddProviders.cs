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
    public partial class AddProvider : Form
    {
        int lastid;
        public AddProvider(int id)
        {
            lastid = id;
            InitializeComponent();
        }

        public void addProviders_Load(object sender, EventArgs e)
        {
            tb_idprovider.Text = lastid.ToString();
        }

        public void btn_addproviders_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void btn_canceladdprovider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
