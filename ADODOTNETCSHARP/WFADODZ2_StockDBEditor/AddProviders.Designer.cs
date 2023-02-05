namespace WFADODZ2_StockDBEditor
{
    partial class AddProvider
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.tb_idprovider = new System.Windows.Forms.TextBox();
            this.tb_providername = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.tb_dateincoming = new System.Windows.Forms.TextBox();
            this.btn_canceladdprovider = new System.Windows.Forms.Button();
            this.btn_addproviders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(21, 28);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(69, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Номер в БД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование поставщика";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(21, 101);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(66, 13);
            this.lbl_count.TabIndex = 2;
            this.lbl_count.Text = "Количество";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(21, 141);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(185, 13);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Ввести Дату в формате гггг-мм-дд";
            // 
            // tb_idprovider
            // 
            this.tb_idprovider.Location = new System.Drawing.Point(175, 25);
            this.tb_idprovider.Name = "tb_idprovider";
            this.tb_idprovider.Size = new System.Drawing.Size(472, 20);
            this.tb_idprovider.TabIndex = 4;
            // 
            // tb_providername
            // 
            this.tb_providername.Location = new System.Drawing.Point(175, 63);
            this.tb_providername.Name = "tb_providername";
            this.tb_providername.Size = new System.Drawing.Size(472, 20);
            this.tb_providername.TabIndex = 5;
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(175, 98);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(472, 20);
            this.tb_count.TabIndex = 6;
            // 
            // tb_dateincoming
            // 
            this.tb_dateincoming.Location = new System.Drawing.Point(243, 138);
            this.tb_dateincoming.Name = "tb_dateincoming";
            this.tb_dateincoming.Size = new System.Drawing.Size(404, 20);
            this.tb_dateincoming.TabIndex = 7;
            // 
            // btn_canceladdprovider
            // 
            this.btn_canceladdprovider.Font = new System.Drawing.Font("SamsungOneUIKorean", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canceladdprovider.Location = new System.Drawing.Point(340, 164);
            this.btn_canceladdprovider.Name = "btn_canceladdprovider";
            this.btn_canceladdprovider.Size = new System.Drawing.Size(307, 47);
            this.btn_canceladdprovider.TabIndex = 8;
            this.btn_canceladdprovider.Text = "Cancel";
            this.btn_canceladdprovider.UseVisualStyleBackColor = true;
            this.btn_canceladdprovider.Click += new System.EventHandler(this.btn_canceladdprovider_Click);
            // 
            // btn_addproviders
            // 
            this.btn_addproviders.Font = new System.Drawing.Font("SamsungOneUISCN 450", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addproviders.Location = new System.Drawing.Point(12, 164);
            this.btn_addproviders.Name = "btn_addproviders";
            this.btn_addproviders.Size = new System.Drawing.Size(307, 47);
            this.btn_addproviders.TabIndex = 9;
            this.btn_addproviders.Text = "Ok";
            this.btn_addproviders.UseVisualStyleBackColor = true;
            this.btn_addproviders.Click += new System.EventHandler(this.btn_addproviders_Click);
            // 
            // AddProvider
            // 
            this.AcceptButton = this.btn_addproviders;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 223);
            this.Controls.Add(this.btn_addproviders);
            this.Controls.Add(this.btn_canceladdprovider);
            this.Controls.Add(this.tb_dateincoming);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.tb_providername);
            this.Controls.Add(this.tb_idprovider);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_id);
            this.Name = "AddProvider";
            this.Text = "Добавить Поставщика";
            this.Load += new System.EventHandler(this.addProviders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_canceladdprovider;
        private System.Windows.Forms.Button btn_addproviders;
        public System.Windows.Forms.TextBox tb_idprovider;
        public System.Windows.Forms.TextBox tb_providername;
        public System.Windows.Forms.TextBox tb_count;
        public System.Windows.Forms.TextBox tb_dateincoming;
    }
}