namespace VegetableFormDZ
{
    partial class VegetableBaseDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.striplbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.datagridviev = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Execute_Request = new System.Windows.Forms.Button();
            this.btn_GetAllProviders = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_AllProviders = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviev)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl,
            this.striplbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 17);
            // 
            // striplbl
            // 
            this.striplbl.Name = "striplbl";
            this.striplbl.Size = new System.Drawing.Size(0, 17);
            // 
            // datagridviev
            // 
            this.datagridviev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviev.Location = new System.Drawing.Point(0, 144);
            this.datagridviev.Name = "datagridviev";
            this.datagridviev.Size = new System.Drawing.Size(800, 281);
            this.datagridviev.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Execute_Request);
            this.panel1.Controls.Add(this.btn_GetAllProviders);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox_AllProviders);
            this.panel1.Controls.Add(this.datagridviev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 8;
            // 
            // btn_Execute_Request
            // 
            this.btn_Execute_Request.Location = new System.Drawing.Point(670, 115);
            this.btn_Execute_Request.Name = "btn_Execute_Request";
            this.btn_Execute_Request.Size = new System.Drawing.Size(118, 23);
            this.btn_Execute_Request.TabIndex = 10;
            this.btn_Execute_Request.Text = "Выполнить запрос";
            this.btn_Execute_Request.UseVisualStyleBackColor = true;
            this.btn_Execute_Request.Click += new System.EventHandler(this.btn_Execute_Request_Click);
            // 
            // btn_GetAllProviders
            // 
            this.btn_GetAllProviders.Location = new System.Drawing.Point(698, 12);
            this.btn_GetAllProviders.Name = "btn_GetAllProviders";
            this.btn_GetAllProviders.Size = new System.Drawing.Size(90, 23);
            this.btn_GetAllProviders.TabIndex = 9;
            this.btn_GetAllProviders.Text = "Поставщики";
            this.btn_GetAllProviders.UseVisualStyleBackColor = true;
            this.btn_GetAllProviders.Click += new System.EventHandler(this.btn_GetAllProviders_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SQL запрос:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Строка подключения";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(664, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(797, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox_AllProviders
            // 
            this.comboBox_AllProviders.FormattingEnabled = true;
            this.comboBox_AllProviders.Location = new System.Drawing.Point(0, 12);
            this.comboBox_AllProviders.Name = "comboBox_AllProviders";
            this.comboBox_AllProviders.Size = new System.Drawing.Size(377, 21);
            this.comboBox_AllProviders.TabIndex = 4;
            this.comboBox_AllProviders.SelectedIndexChanged += new System.EventHandler(this.comboBox_AllProviders_SelectedIndexChanged);
            // 
            // VegetableBaseDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.Name = "VegetableBaseDB";
            this.Text = "VegetableBase";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviev)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
        private System.Windows.Forms.ToolStripStatusLabel striplbl;
        private System.Windows.Forms.DataGridView datagridviev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Execute_Request;
        private System.Windows.Forms.Button btn_GetAllProviders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox_AllProviders;
    }
}

