namespace WFADODZ2_StockDBEditor
{
    partial class EditProduct
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
            this.tb_provID = new System.Windows.Forms.TextBox();
            this.tb_typeproduct = new System.Windows.Forms.TextBox();
            this.tb_nameproduct = new System.Windows.Forms.TextBox();
            this.tb_idproduct = new System.Windows.Forms.TextBox();
            this.lbl_provID = new System.Windows.Forms.Label();
            this.lbl_Typeproduct = new System.Windows.Forms.Label();
            this.lbl_Nameproduct = new System.Windows.Forms.Label();
            this.lbl_idproduct = new System.Windows.Forms.Label();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.btn_cancelproduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_provID
            // 
            this.tb_provID.Location = new System.Drawing.Point(202, 116);
            this.tb_provID.Name = "tb_provID";
            this.tb_provID.Size = new System.Drawing.Size(425, 20);
            this.tb_provID.TabIndex = 19;
            // 
            // tb_typeproduct
            // 
            this.tb_typeproduct.Location = new System.Drawing.Point(202, 80);
            this.tb_typeproduct.Name = "tb_typeproduct";
            this.tb_typeproduct.Size = new System.Drawing.Size(425, 20);
            this.tb_typeproduct.TabIndex = 18;
            // 
            // tb_nameproduct
            // 
            this.tb_nameproduct.Location = new System.Drawing.Point(202, 46);
            this.tb_nameproduct.Name = "tb_nameproduct";
            this.tb_nameproduct.Size = new System.Drawing.Size(425, 20);
            this.tb_nameproduct.TabIndex = 17;
            // 
            // tb_idproduct
            // 
            this.tb_idproduct.Location = new System.Drawing.Point(202, 10);
            this.tb_idproduct.Name = "tb_idproduct";
            this.tb_idproduct.Size = new System.Drawing.Size(425, 20);
            this.tb_idproduct.TabIndex = 16;
            // 
            // lbl_provID
            // 
            this.lbl_provID.AutoSize = true;
            this.lbl_provID.Location = new System.Drawing.Point(41, 119);
            this.lbl_provID.Name = "lbl_provID";
            this.lbl_provID.Size = new System.Drawing.Size(152, 13);
            this.lbl_provID.TabIndex = 15;
            this.lbl_provID.Text = "Идентификатор поставщика";
            // 
            // lbl_Typeproduct
            // 
            this.lbl_Typeproduct.AutoSize = true;
            this.lbl_Typeproduct.Location = new System.Drawing.Point(41, 83);
            this.lbl_Typeproduct.Name = "lbl_Typeproduct";
            this.lbl_Typeproduct.Size = new System.Drawing.Size(64, 13);
            this.lbl_Typeproduct.TabIndex = 14;
            this.lbl_Typeproduct.Text = "Тип товара";
            // 
            // lbl_Nameproduct
            // 
            this.lbl_Nameproduct.AutoSize = true;
            this.lbl_Nameproduct.Location = new System.Drawing.Point(41, 46);
            this.lbl_Nameproduct.Name = "lbl_Nameproduct";
            this.lbl_Nameproduct.Size = new System.Drawing.Size(83, 13);
            this.lbl_Nameproduct.TabIndex = 13;
            this.lbl_Nameproduct.Text = "Наименование";
            // 
            // lbl_idproduct
            // 
            this.lbl_idproduct.AutoSize = true;
            this.lbl_idproduct.Location = new System.Drawing.Point(41, 10);
            this.lbl_idproduct.Name = "lbl_idproduct";
            this.lbl_idproduct.Size = new System.Drawing.Size(69, 13);
            this.lbl_idproduct.TabIndex = 12;
            this.lbl_idproduct.Text = "Номер в БД";
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Font = new System.Drawing.Font("SamsungOneUISCN 450", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addproduct.Location = new System.Drawing.Point(32, 166);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(294, 46);
            this.btn_addproduct.TabIndex = 11;
            this.btn_addproduct.Text = "OK";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // btn_cancelproduct
            // 
            this.btn_cancelproduct.Font = new System.Drawing.Font("SamsungOneUISCN 450", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_cancelproduct.Location = new System.Drawing.Point(332, 166);
            this.btn_cancelproduct.Name = "btn_cancelproduct";
            this.btn_cancelproduct.Size = new System.Drawing.Size(295, 46);
            this.btn_cancelproduct.TabIndex = 10;
            this.btn_cancelproduct.Text = "Cancel";
            this.btn_cancelproduct.UseVisualStyleBackColor = true;
            this.btn_cancelproduct.Click += new System.EventHandler(this.btn_cancelproduct_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 223);
            this.Controls.Add(this.tb_provID);
            this.Controls.Add(this.tb_typeproduct);
            this.Controls.Add(this.tb_nameproduct);
            this.Controls.Add(this.tb_idproduct);
            this.Controls.Add(this.lbl_provID);
            this.Controls.Add(this.lbl_Typeproduct);
            this.Controls.Add(this.lbl_Nameproduct);
            this.Controls.Add(this.lbl_idproduct);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.btn_cancelproduct);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_provID;
        private System.Windows.Forms.Label lbl_Typeproduct;
        private System.Windows.Forms.Label lbl_Nameproduct;
        private System.Windows.Forms.Label lbl_idproduct;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.Button btn_cancelproduct;
        public System.Windows.Forms.TextBox tb_provID;
        public System.Windows.Forms.TextBox tb_typeproduct;
        public System.Windows.Forms.TextBox tb_nameproduct;
        public System.Windows.Forms.TextBox tb_idproduct;
    }
}