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

namespace WFADODZ2_StockDBEditor
{
    public partial class Stock : Form
    {
        SqlDataAdapter adapterProviders = null;
        SqlDataAdapter adapterProduct = null;
        SqlConnection connectProviders = new SqlConnection();
        SqlConnection connectProduct = new SqlConnection();
        SqlCommandBuilder cmdbuilderProviders = new SqlCommandBuilder();
        SqlCommandBuilder cmdbuilderProduct = new SqlCommandBuilder();
        SqlDataReader readerStock = null;
        DataSet datasetProviders = new DataSet();
        DataSet datasetProduct = new DataSet();
        SqlCommand sqlcommStock = null;
        public Stock()
        {
            InitializeComponent();
        }

        private void connectToBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adapterProduct == null)
            {
                dgvProviders.Rows.Clear();
                dgvProviders.Columns.Clear();
                dgvProduct.Rows.Clear();
                dgvProduct.Columns.Clear();
            }
            else
            {
                adapterProviders = null;
                adapterProduct = null;
                datasetProviders = new DataSet();
                datasetProduct = new DataSet();
            }
            connectProviders.ConnectionString = ConfigurationManager.ConnectionStrings["StockDB"].ConnectionString;
            try
            {
                adapterProviders = new SqlDataAdapter("select * from Providers", connectProviders.ConnectionString);
                adapterProviders.Fill(datasetProviders);
                adapterProduct = new SqlDataAdapter("select * from Product", connectProviders.ConnectionString);
                adapterProduct.Fill(datasetProduct);
                dgvProviders.DataSource = datasetProviders.Tables[0];
                dgvProduct.DataSource = datasetProduct.Tables[0];
                statuslbl.Text = "Connection to DB success";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                statuslbl.Text = "All data read success";
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabProviders)
                {
                    int lastid = 1;
                    if (datasetProviders.Tables[0].Rows.Count > 0)
                    {
                        lastid = (int)datasetProviders.Tables[0].Rows[datasetProviders.Tables[0].Rows.Count - 1][0] + 1;
                    }
                    AddProvider ap = new AddProvider(lastid);
                    if (ap.ShowDialog() == DialogResult.OK)
                    {
                        datasetProviders.Tables[0].Rows.Add(
                            Int32.Parse(ap.tb_idprovider.Text),
                            ap.tb_providername.Text,
                            Int32.Parse(ap.tb_count.Text),
                            DateTime.Parse(ap.tb_dateincoming.Text)
                            );
                    }
                    ap.Dispose();
                }
                else if (tabControl1.SelectedTab == tabProduct)
                {
                    int lastid = 1;
                    if (datasetProduct.Tables[0].Rows.Count > 0)
                    {
                        lastid = (int)datasetProduct.Tables[0].Rows[datasetProduct.Tables[0].Rows.Count - 1][0] + 1;
                    }
                    AddprodForm apf = new AddprodForm(lastid);
                    if (apf.ShowDialog() == DialogResult.OK)
                    {
                        datasetProduct.Tables[0].Rows.Add(
                            Int32.Parse(apf.tb_idproduct.Text),
                            apf.tb_nameproduct.Text,
                            apf.tb_typeproduct.Text,
                            Int32.Parse(apf.tb_provID.Text)
                            );
                    }
                    apf.Dispose();
                }
            }
            catch (Exception ex) { statuslbl.Text = ex.Message; }
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabProviders && dgvProviders.SelectedRows.Count > 0)
                {
                    DataRow editRow = datasetProviders.Tables[0].Rows[dgvProviders.SelectedRows[0].Index];
                    EditProviders editprov = new EditProviders(
                        (int)editRow[0], (string)editRow[1], (int)editRow[2], (DateTime)editRow[3]);
                    if (editprov.ShowDialog() == DialogResult.OK)
                    {
                        datasetProviders.Tables[0].Rows[dgvProviders.SelectedRows[0].Index].SetField(0, Int32.Parse(editprov.tb_idprovider.Text));
                        datasetProviders.Tables[0].Rows[dgvProviders.SelectedRows[0].Index].SetField(1, editprov.tb_providername.Text);
                        datasetProviders.Tables[0].Rows[dgvProviders.SelectedRows[0].Index].SetField(2, Int32.Parse(editprov.tb_count.Text));
                        datasetProviders.Tables[0].Rows[dgvProviders.SelectedRows[0].Index].SetField(3, DateTime.Parse(editprov.tb_dateincoming.Text));
                    }
                }
                else if (tabControl1.SelectedTab == tabProduct && dgvProduct.SelectedRows.Count > 0)
                {
                    DataRow editRow = datasetProduct.Tables[0].Rows[dgvProduct.SelectedRows[0].Index];
                    EditProduct editprod = new EditProduct(
                        (int)editRow[0], (string)editRow[1], (string)editRow[2], (int)editRow[3]);
                    if (editprod.ShowDialog() == DialogResult.OK)
                    {
                        datasetProduct.Tables[0].Rows[dgvProduct.SelectedRows[0].Index].SetField(0, Int32.Parse(editprod.tb_idproduct.Text));
                        datasetProduct.Tables[0].Rows[dgvProduct.SelectedRows[0].Index].SetField(1, editprod.tb_nameproduct.Text);
                        datasetProduct.Tables[0].Rows[dgvProduct.SelectedRows[0].Index].SetField(2, editprod.tb_typeproduct.Text);
                        datasetProduct.Tables[0].Rows[dgvProduct.SelectedRows[0].Index].SetField(3, Int32.Parse(editprod.tb_provID.Text));
                    }

                }
            }
            catch (Exception ex) { statuslbl.Text = ex.Message; }
        }
        private void Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialres = MessageBox.Show("Save to DB?", "Update Database", MessageBoxButtons.OKCancel);
            if (dialres == DialogResult.OK && adapterProviders != null && adapterProduct != null)
            {
                cmdbuilderProviders = new SqlCommandBuilder(adapterProviders);
                adapterProviders.DeleteCommand = cmdbuilderProviders.GetDeleteCommand();
                adapterProviders.InsertCommand = cmdbuilderProviders.GetInsertCommand();
                adapterProviders.UpdateCommand = cmdbuilderProviders.GetUpdateCommand();
                adapterProviders.Update(datasetProviders);

                cmdbuilderProduct = new SqlCommandBuilder(adapterProduct);
                adapterProduct.DeleteCommand = cmdbuilderProduct.GetDeleteCommand();
                adapterProduct.InsertCommand = cmdbuilderProduct.GetInsertCommand();
                adapterProduct.UpdateCommand = cmdbuilderProduct.GetUpdateCommand();
                adapterProduct.Update(datasetProduct);

            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(tabControl1.SelectedTab == tabProviders)
                {
                    if(dgvProviders.SelectedRows.Count > 0 && dgvProviders.SelectedRows[0].Cells[0].Value != null)
                    {
                        datasetProviders.Tables[0].Rows.RemoveAt(dgvProviders.SelectedRows[0].Index);
                    }
                }
                else if(tabControl1.SelectedTab == tabProduct)
                    if(dgvProduct.SelectedRows.Count > 0 && dgvProduct.SelectedRows[0].Cells[0].Value != null)
                    {
                        datasetProduct.Tables[0].Rows.RemoveAt(dgvProduct.SelectedRows[0].Index);
                    }
            }
            catch(Exception ex){ statuslbl.Text = ex.Message; }
        }
    }
}
