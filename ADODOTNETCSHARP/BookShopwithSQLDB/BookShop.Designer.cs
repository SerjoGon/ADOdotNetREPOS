namespace BookShopwithSQLDB
{
    partial class BookShop
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMonthsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topOnYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.bookShopDBNEWDataSet = new BookShopwithSQLDB.BookShopDBNEWDataSet();
            this.bookTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableTableAdapter = new BookShopwithSQLDB.BookShopDBNEWDataSetTableAdapters.BookTableTableAdapter();
            this.addrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShopDBNEWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.addBookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.addrowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.editBookToolStripMenuItem.Text = "Edit Book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.deleteBookToolStripMenuItem.Text = "Delete Book";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topTodayToolStripMenuItem,
            this.topWeekToolStripMenuItem,
            this.topMonthsToolStripMenuItem,
            this.topOnYearToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // topTodayToolStripMenuItem
            // 
            this.topTodayToolStripMenuItem.Name = "topTodayToolStripMenuItem";
            this.topTodayToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.topTodayToolStripMenuItem.Text = "Top today";
            // 
            // topWeekToolStripMenuItem
            // 
            this.topWeekToolStripMenuItem.Name = "topWeekToolStripMenuItem";
            this.topWeekToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.topWeekToolStripMenuItem.Text = "Top of the week";
            // 
            // topMonthsToolStripMenuItem
            // 
            this.topMonthsToolStripMenuItem.Name = "topMonthsToolStripMenuItem";
            this.topMonthsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.topMonthsToolStripMenuItem.Text = "Top of the months";
            this.topMonthsToolStripMenuItem.Click += new System.EventHandler(this.topMonthsToolStripMenuItem_Click);
            // 
            // topOnYearToolStripMenuItem
            // 
            this.topOnYearToolStripMenuItem.Name = "topOnYearToolStripMenuItem";
            this.topOnYearToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.topOnYearToolStripMenuItem.Text = "Top of the year";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts_status
            // 
            this.ts_status.Name = "ts_status";
            this.ts_status.Size = new System.Drawing.Size(34, 17);
            this.ts_status.Text = "INFO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 571);
            this.panel1.TabIndex = 6;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(945, 571);
            this.dgv1.TabIndex = 0;
            // 
            // bookShopDBNEWDataSet
            // 
            this.bookShopDBNEWDataSet.DataSetName = "BookShopDBNEWDataSet";
            this.bookShopDBNEWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableBindingSource
            // 
            this.bookTableBindingSource.DataMember = "BookTable";
            this.bookTableBindingSource.DataSource = this.bookShopDBNEWDataSet;
            // 
            // bookTableTableAdapter
            // 
            this.bookTableTableAdapter.ClearBeforeFill = true;
            // 
            // addrowToolStripMenuItem
            // 
            this.addrowToolStripMenuItem.Name = "addrowToolStripMenuItem";
            this.addrowToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.addrowToolStripMenuItem.Text = "addrow";
            this.addrowToolStripMenuItem.Click += new System.EventHandler(this.addrowToolStripMenuItem_Click);
            // 
            // BookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookShop";
            this.Text = "BookShopTable";
            this.Load += new System.EventHandler(this.BookShop_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShopDBNEWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMonthsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topOnYearToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv1;
        private BookShopDBNEWDataSet bookShopDBNEWDataSet;
        private System.Windows.Forms.BindingSource bookTableBindingSource;
        private BookShopDBNEWDataSetTableAdapters.BookTableTableAdapter bookTableTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem addrowToolStripMenuItem;
    }
}

