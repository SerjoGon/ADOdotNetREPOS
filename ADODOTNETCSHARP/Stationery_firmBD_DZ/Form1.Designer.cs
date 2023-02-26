namespace Stationery_firmBD_DZ
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Product = new System.Windows.Forms.TabPage();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.tp_managers = new System.Windows.Forms.TabPage();
            this.dgv_Managers = new System.Windows.Forms.DataGridView();
            this.tp_firms = new System.Windows.Forms.TabPage();
            this.dgv_Firms = new System.Windows.Forms.DataGridView();
            this.tp_Sales = new System.Windows.Forms.TabPage();
            this.dgv_Sales = new System.Windows.Forms.DataGridView();
            this.tp_showsorts = new System.Windows.Forms.TabPage();
            this.dgv_Showsorts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolstriplbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tp_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.tp_managers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Managers)).BeginInit();
            this.tp_firms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firms)).BeginInit();
            this.tp_Sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sales)).BeginInit();
            this.tp_showsorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Showsorts)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Product);
            this.tabControl1.Controls.Add(this.tp_managers);
            this.tabControl1.Controls.Add(this.tp_firms);
            this.tabControl1.Controls.Add(this.tp_Sales);
            this.tabControl1.Controls.Add(this.tp_showsorts);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_Product
            // 
            this.tp_Product.Controls.Add(this.dgv_Product);
            this.tp_Product.Location = new System.Drawing.Point(4, 22);
            this.tp_Product.Name = "tp_Product";
            this.tp_Product.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Product.Size = new System.Drawing.Size(792, 400);
            this.tp_Product.TabIndex = 0;
            this.tp_Product.Text = "Product";
            this.tp_Product.UseVisualStyleBackColor = true;
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            this.dgv_Product.AllowUserToDeleteRows = false;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product.Location = new System.Drawing.Point(3, 3);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.Size = new System.Drawing.Size(786, 394);
            this.dgv_Product.TabIndex = 0;
            // 
            // tp_managers
            // 
            this.tp_managers.Controls.Add(this.dgv_Managers);
            this.tp_managers.Location = new System.Drawing.Point(4, 22);
            this.tp_managers.Name = "tp_managers";
            this.tp_managers.Padding = new System.Windows.Forms.Padding(3);
            this.tp_managers.Size = new System.Drawing.Size(792, 400);
            this.tp_managers.TabIndex = 1;
            this.tp_managers.Text = "Managers";
            this.tp_managers.UseVisualStyleBackColor = true;
            // 
            // dgv_Managers
            // 
            this.dgv_Managers.AllowUserToAddRows = false;
            this.dgv_Managers.AllowUserToDeleteRows = false;
            this.dgv_Managers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Managers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Managers.Location = new System.Drawing.Point(3, 3);
            this.dgv_Managers.Name = "dgv_Managers";
            this.dgv_Managers.ReadOnly = true;
            this.dgv_Managers.Size = new System.Drawing.Size(786, 394);
            this.dgv_Managers.TabIndex = 0;
            // 
            // tp_firms
            // 
            this.tp_firms.Controls.Add(this.dgv_Firms);
            this.tp_firms.Location = new System.Drawing.Point(4, 22);
            this.tp_firms.Name = "tp_firms";
            this.tp_firms.Padding = new System.Windows.Forms.Padding(3);
            this.tp_firms.Size = new System.Drawing.Size(792, 400);
            this.tp_firms.TabIndex = 2;
            this.tp_firms.Text = "Firms";
            this.tp_firms.UseVisualStyleBackColor = true;
            // 
            // dgv_Firms
            // 
            this.dgv_Firms.AllowUserToAddRows = false;
            this.dgv_Firms.AllowUserToDeleteRows = false;
            this.dgv_Firms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Firms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Firms.Location = new System.Drawing.Point(3, 3);
            this.dgv_Firms.Name = "dgv_Firms";
            this.dgv_Firms.ReadOnly = true;
            this.dgv_Firms.Size = new System.Drawing.Size(786, 394);
            this.dgv_Firms.TabIndex = 0;
            // 
            // tp_Sales
            // 
            this.tp_Sales.Controls.Add(this.dgv_Sales);
            this.tp_Sales.Location = new System.Drawing.Point(4, 22);
            this.tp_Sales.Name = "tp_Sales";
            this.tp_Sales.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Sales.Size = new System.Drawing.Size(792, 400);
            this.tp_Sales.TabIndex = 3;
            this.tp_Sales.Text = "Sales";
            this.tp_Sales.UseVisualStyleBackColor = true;
            // 
            // dgv_Sales
            // 
            this.dgv_Sales.AllowUserToAddRows = false;
            this.dgv_Sales.AllowUserToDeleteRows = false;
            this.dgv_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Sales.Location = new System.Drawing.Point(3, 3);
            this.dgv_Sales.Name = "dgv_Sales";
            this.dgv_Sales.ReadOnly = true;
            this.dgv_Sales.Size = new System.Drawing.Size(786, 394);
            this.dgv_Sales.TabIndex = 0;
            // 
            // tp_showsorts
            // 
            this.tp_showsorts.Controls.Add(this.dgv_Showsorts);
            this.tp_showsorts.Location = new System.Drawing.Point(4, 22);
            this.tp_showsorts.Name = "tp_showsorts";
            this.tp_showsorts.Padding = new System.Windows.Forms.Padding(3);
            this.tp_showsorts.Size = new System.Drawing.Size(792, 400);
            this.tp_showsorts.TabIndex = 4;
            this.tp_showsorts.Text = "Show Sorts";
            this.tp_showsorts.UseVisualStyleBackColor = true;
            // 
            // dgv_Showsorts
            // 
            this.dgv_Showsorts.AllowUserToAddRows = false;
            this.dgv_Showsorts.AllowUserToDeleteRows = false;
            this.dgv_Showsorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Showsorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Showsorts.Location = new System.Drawing.Point(3, 3);
            this.dgv_Showsorts.Name = "dgv_Showsorts";
            this.dgv_Showsorts.ReadOnly = true;
            this.dgv_Showsorts.Size = new System.Drawing.Size(786, 394);
            this.dgv_Showsorts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstriplbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolstriplbl
            // 
            this.toolstriplbl.Name = "toolstriplbl";
            this.toolstriplbl.Size = new System.Drawing.Size(28, 17);
            this.toolstriplbl.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DataBase";
            this.tabControl1.ResumeLayout(false);
            this.tp_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.tp_managers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Managers)).EndInit();
            this.tp_firms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firms)).EndInit();
            this.tp_Sales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sales)).EndInit();
            this.tp_showsorts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Showsorts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Product;
        private System.Windows.Forms.TabPage tp_managers;
        private System.Windows.Forms.TabPage tp_firms;
        private System.Windows.Forms.TabPage tp_Sales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolstriplbl;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.DataGridView dgv_Managers;
        private System.Windows.Forms.DataGridView dgv_Firms;
        private System.Windows.Forms.DataGridView dgv_Sales;
        private System.Windows.Forms.TabPage tp_showsorts;
        private System.Windows.Forms.DataGridView dgv_Showsorts;
    }
}

