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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageBook = new System.Windows.Forms.TabPage();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.pageStatistics = new System.Windows.Forms.TabPage();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.pageStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.addBookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
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
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 715);
            this.panel1.TabIndex = 6;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageBook);
            this.tabControl.Controls.Add(this.pageStatistics);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1184, 715);
            this.tabControl.TabIndex = 0;
            // 
            // pageBook
            // 
            this.pageBook.Controls.Add(this.dgv1);
            this.pageBook.Location = new System.Drawing.Point(4, 22);
            this.pageBook.Name = "pageBook";
            this.pageBook.Padding = new System.Windows.Forms.Padding(3);
            this.pageBook.Size = new System.Drawing.Size(1176, 689);
            this.pageBook.TabIndex = 0;
            this.pageBook.Text = "Books";
            this.pageBook.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(3, 3);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(1170, 683);
            this.dgv1.TabIndex = 0;
            // 
            // pageStatistics
            // 
            this.pageStatistics.Controls.Add(this.dgv2);
            this.pageStatistics.Location = new System.Drawing.Point(4, 22);
            this.pageStatistics.Name = "pageStatistics";
            this.pageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.pageStatistics.Size = new System.Drawing.Size(1176, 689);
            this.pageStatistics.TabIndex = 1;
            this.pageStatistics.Text = "Статистика";
            this.pageStatistics.UseVisualStyleBackColor = true;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(3, 3);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.Size = new System.Drawing.Size(1170, 680);
            this.dgv2.TabIndex = 1;
            // 
            // BookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookShop";
            this.Text = "BookShopTable";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.pageBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.pageStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageBook;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TabPage pageStatistics;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMonthsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topOnYearToolStripMenuItem;
    }
}

