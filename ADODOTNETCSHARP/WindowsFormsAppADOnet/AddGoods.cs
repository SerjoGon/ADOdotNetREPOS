using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppADOnet
{
    public partial class AddGoods : Form
    {
        int lastid;
        public AddGoods(int id)
        {
            lastid = id;
            InitializeComponent();
        }
        private void AddGoods_Load(object sender, EventArgs e)
        {
            tb_id.Text = lastid.ToString();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
