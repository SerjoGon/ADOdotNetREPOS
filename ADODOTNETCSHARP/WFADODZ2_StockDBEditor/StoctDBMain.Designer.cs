namespace WFADODZ2_StockDBEditor
{
    partial class Stock
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab_Control = new System.Windows.Forms.TabControl();
            this.tabProviders = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tabShow = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Showmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.tab_Control.SuspendLayout();
            this.tabProviders.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.tabProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tabShow.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_status,
            this.statuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts_status
            // 
            this.ts_status.Name = "ts_status";
            this.ts_status.Size = new System.Drawing.Size(0, 17);
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(28, 17);
            this.statuslbl.Text = "Info";
            // 
            // tab_Control
            // 
            this.tab_Control.Controls.Add(this.tabProviders);
            this.tab_Control.Controls.Add(this.tabProduct);
            this.tab_Control.Controls.Add(this.tabShow);
            this.tab_Control.Location = new System.Drawing.Point(0, 27);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.SelectedIndex = 0;
            this.tab_Control.Size = new System.Drawing.Size(800, 398);
            this.tab_Control.TabIndex = 6;
            // 
            // tabProviders
            // 
            this.tabProviders.Controls.Add(this.panel1);
            this.tabProviders.Location = new System.Drawing.Point(4, 22);
            this.tabProviders.Name = "tabProviders";
            this.tabProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tabProviders.Size = new System.Drawing.Size(792, 372);
            this.tabProviders.TabIndex = 0;
            this.tabProviders.Text = "Providers";
            this.tabProviders.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProviders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 366);
            this.panel1.TabIndex = 0;
            // 
            // dgvProviders
            // 
            this.dgvProviders.AllowUserToDeleteRows = false;
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProviders.Location = new System.Drawing.Point(0, 0);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.ReadOnly = true;
            this.dgvProviders.Size = new System.Drawing.Size(786, 366);
            this.dgvProviders.TabIndex = 0;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.panel2);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(792, 372);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 366);
            this.panel2.TabIndex = 1;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(786, 366);
            this.dgvProduct.TabIndex = 1;
            // 
            // tabShow
            // 
            this.tabShow.Controls.Add(this.dgvShow);
            this.tabShow.Location = new System.Drawing.Point(4, 22);
            this.tabShow.Name = "tabShow";
            this.tabShow.Padding = new System.Windows.Forms.Padding(3);
            this.tabShow.Size = new System.Drawing.Size(792, 372);
            this.tabShow.TabIndex = 2;
            this.tabShow.Text = "Show";
            this.tabShow.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDBToolStripMenuItem,
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.Showmenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToDBToolStripMenuItem
            // 
            this.connectToDBToolStripMenuItem.Name = "connectToDBToolStripMenuItem";
            this.connectToDBToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.connectToDBToolStripMenuItem.Text = "Connect to DB";
            this.connectToDBToolStripMenuItem.Click += new System.EventHandler(this.connectToBDToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.EditToolStripMenuItem.Text = "Редактировать";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.DeleteToolStripMenuItem.Text = "Удалить строку";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // Showmenu
            // 
            this.Showmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mINToolStripMenuItem,
            this.mAXToolStripMenuItem,
            this.aVGToolStripMenuItem});
            this.Showmenu.Name = "Showmenu";
            this.Showmenu.Size = new System.Drawing.Size(69, 20);
            this.Showmenu.Text = "Показать";
            // 
            // mINToolStripMenuItem
            // 
            this.mINToolStripMenuItem.Name = "mINToolStripMenuItem";
            this.mINToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.mINToolStripMenuItem.Text = "Мин кол-во товара";
            this.mINToolStripMenuItem.Click += new System.EventHandler(this.mINToolStripMenuItem_Click);
            // 
            // mAXToolStripMenuItem
            // 
            this.mAXToolStripMenuItem.Name = "mAXToolStripMenuItem";
            this.mAXToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.mAXToolStripMenuItem.Text = "Макс кол-во товара";
            this.mAXToolStripMenuItem.Click += new System.EventHandler(this.mAXToolStripMenuItem_Click);
            // 
            // aVGToolStripMenuItem
            // 
            this.aVGToolStripMenuItem.Name = "aVGToolStripMenuItem";
            this.aVGToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.aVGToolStripMenuItem.Text = "Средняя по кол-во товара";
            this.aVGToolStripMenuItem.Click += new System.EventHandler(this.aVGToolStripMenuItem_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(3, 3);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(786, 366);
            this.dgvShow.TabIndex = 0;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_Control);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Stock";
            this.Text = "StockDB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stock_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tab_Control.ResumeLayout(false);
            this.tabProviders.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tabShow.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts_status;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
        private System.Windows.Forms.TabControl tab_Control;
        private System.Windows.Forms.TabPage tabProviders;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToDBToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProviders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.TabPage tabShow;
        private System.Windows.Forms.ToolStripMenuItem Showmenu;
        private System.Windows.Forms.ToolStripMenuItem mINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVGToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvShow;
    }
}

