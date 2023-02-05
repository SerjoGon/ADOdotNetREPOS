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
    public partial class EditProviders : Form
    {
        int ID;
        string Name;
        int Count;
        DateTime Dateincome;
        public EditProviders(int id, string name, int count, DateTime dateincome)
        {
            InitializeComponent();
            ID = id;
            Name = name;
            Count = count;
            Dateincome = dateincome;
        }

        private void EditProviders_Load(object sender, EventArgs e)
        {
            tb_idprovider.Text = ID.ToString();
            tb_providername.Text = Name.ToString();
            tb_count.Text = Count.ToString();
            tb_dateincoming.Text = Dateincome.ToString();
        }

        private void btn_addproviders_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_canceladdprovider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
