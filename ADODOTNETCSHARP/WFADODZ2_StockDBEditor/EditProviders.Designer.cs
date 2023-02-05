namespace WFADODZ2_StockDBEditor
{
    partial class EditProviders
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
            this.btn_addproviders = new System.Windows.Forms.Button();
            this.btn_canceladdprovider = new System.Windows.Forms.Button();
            this.tb_dateincoming = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.tb_providername = new System.Windows.Forms.TextBox();
            this.tb_idprovider = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addproviders
            // 
            this.btn_addproviders.Font = new System.Drawing.Font("SamsungOneUISCN 450", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addproviders.Location = new System.Drawing.Point(12, 157);
            this.btn_addproviders.Name = "btn_addproviders";
            this.btn_addproviders.Size = new System.Drawing.Size(307, 47);
            this.btn_addproviders.TabIndex = 19;
            this.btn_addproviders.Text = "Ok";
            this.btn_addproviders.UseVisualStyleBackColor = true;
            this.btn_addproviders.Click += new System.EventHandler(this.btn_addproviders_Click);
            // 
            // btn_canceladdprovider
            // 
            this.btn_canceladdprovider.Font = new System.Drawing.Font("SamsungOneUIKorean", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canceladdprovider.Location = new System.Drawing.Point(340, 157);
            this.btn_canceladdprovider.Name = "btn_canceladdprovider";
            this.btn_canceladdprovider.Size = new System.Drawing.Size(307, 47);
            this.btn_canceladdprovider.TabIndex = 18;
            this.btn_canceladdprovider.Text = "Cancel";
            this.btn_canceladdprovider.UseVisualStyleBackColor = true;
            this.btn_canceladdprovider.Click += new System.EventHandler(this.btn_canceladdprovider_Click);
            // 
            // tb_dateincoming
            // 
            this.tb_dateincoming.Location = new System.Drawing.Point(243, 131);
            this.tb_dateincoming.Name = "tb_dateincoming";
            this.tb_dateincoming.Size = new System.Drawing.Size(404, 20);
            this.tb_dateincoming.TabIndex = 17;
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(175, 91);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(472, 20);
            this.tb_count.TabIndex = 16;
            // 
            // tb_providername
            // 
            this.tb_providername.Location = new System.Drawing.Point(175, 56);
            this.tb_providername.Name = "tb_providername";
            this.tb_providername.Size = new System.Drawing.Size(472, 20);
            this.tb_providername.TabIndex = 15;
            // 
            // tb_idprovider
            // 
            this.tb_idprovider.Location = new System.Drawing.Point(175, 18);
            this.tb_idprovider.Name = "tb_idprovider";
            this.tb_idprovider.Size = new System.Drawing.Size(472, 20);
            this.tb_idprovider.TabIndex = 14;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(21, 134);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(185, 13);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "Ввести Дату в формате гггг-мм-дд";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(21, 94);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(66, 13);
            this.lbl_count.TabIndex = 12;
            this.lbl_count.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Наименование поставщика";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(21, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(69, 13);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "Номер в БД";
            // 
            // EditProviders
            // 
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
            this.Name = "EditProviders";
            this.Text = "EditProviders";
            this.Load += new System.EventHandler(this.EditProviders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addproviders;
        private System.Windows.Forms.Button btn_canceladdprovider;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.TextBox tb_dateincoming;
        public System.Windows.Forms.TextBox tb_count;
        public System.Windows.Forms.TextBox tb_providername;
        public System.Windows.Forms.TextBox tb_idprovider;
    }
}