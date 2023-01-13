namespace WindowsFormswithADO
{
    partial class Form1
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
            this.btn_request = new System.Windows.Forms.Button();
            this.dgv_request = new System.Windows.Forms.DataGridView();
            this.tb_request = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_request)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_request
            // 
            this.btn_request.Location = new System.Drawing.Point(713, 12);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(75, 23);
            this.btn_request.TabIndex = 0;
            this.btn_request.Text = "Кнопка";
            this.btn_request.UseVisualStyleBackColor = true;
            // 
            // dgv_request
            // 
            this.dgv_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_request.Location = new System.Drawing.Point(12, 41);
            this.dgv_request.Name = "dgv_request";
            this.dgv_request.Size = new System.Drawing.Size(776, 397);
            this.dgv_request.TabIndex = 1;
            // 
            // tb_request
            // 
            this.tb_request.Location = new System.Drawing.Point(12, 15);
            this.tb_request.Name = "tb_request";
            this.tb_request.Size = new System.Drawing.Size(695, 20);
            this.tb_request.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_request);
            this.Controls.Add(this.dgv_request);
            this.Controls.Add(this.btn_request);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.DataGridView dgv_request;
        private System.Windows.Forms.TextBox tb_request;
    }
}

