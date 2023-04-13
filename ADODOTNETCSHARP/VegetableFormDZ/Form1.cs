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
using System.Data.Common;
using System.Data.Odbc;

namespace VegetableFormDZ
{
    public partial class VegetableBaseDB : Form
    {
        DbConnection conn = null;
        DbProviderFactory factory = null;
        DbDataAdapter dbDataAdapter = null;
        string providerName = "";
        public VegetableBaseDB()
        {
            InitializeComponent();
            btn_Execute_Request.Enabled = false;
        }

        
        private void Connection()
        {
            conn.ConnectionString = textBox1.Text;
            dbDataAdapter = factory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = conn.CreateCommand();
            dbDataAdapter.SelectCommand.CommandText = textBox2.Text.ToString();
            DataTable dt = new DataTable();
            dbDataAdapter.Fill(dt);
            datagridviev.DataSource = null;
            datagridviev.DataSource = dt;
        }

        private void btn_GetAllProviders_Click(object sender, EventArgs e)
        {
            DataTable dt = DbProviderFactories.GetFactoryClasses();
            datagridviev.DataSource = dt;
            comboBox_AllProviders.Items.Clear();
            foreach(DataRow dataRow in dt.Rows)
            {
                comboBox_AllProviders.Items.Add(dataRow["InvariantName"]);
            }
        }

        private void comboBox_AllProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            factory = DbProviderFactories.GetFactory(comboBox_AllProviders.SelectedItem.ToString());
            conn = factory.CreateConnection();
            providerName = GetConnectionStringByProvider(comboBox_AllProviders.SelectedItem.ToString());
            textBox1.Text = providerName;
        }
        static string GetConnectionStringByProvider(string providerName)
        {
            string provider = null;
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null) 
            {
                foreach(ConnectionStringSettings constr  in settings) 
                {
                    if (constr.ProviderName == providerName) 
                    {
                        provider = constr.ConnectionString;
                        break;
                    }
                }
            }
            return provider;
        }

        private void btn_Execute_Request_Click(object sender, EventArgs e)
        {
            Connection();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 10) btn_Execute_Request.Enabled = true;
            else btn_Execute_Request.Enabled = false;
        }
    }
}
