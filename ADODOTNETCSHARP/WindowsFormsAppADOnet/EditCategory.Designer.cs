namespace WindowsFormsAppADOnet
{
    partial class EditCategory
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(103, 24);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(262, 20);
            this.tb_id.TabIndex = 11;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(103, 70);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(262, 20);
            this.tb_name.TabIndex = 10;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_name.Location = new System.Drawing.Point(10, 60);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(70, 33);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "Name";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_id.Location = new System.Drawing.Point(16, 14);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(36, 33);
            this.lb_id.TabIndex = 8;
            this.lb_id.Text = "ID";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(195, 113);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(170, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "NOT OK";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(16, 113);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(173, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 154);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Name = "EditCategory";
            this.Text = "EditCategory";
            this.Load += new System.EventHandler(this.EditCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_id;
        public System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}