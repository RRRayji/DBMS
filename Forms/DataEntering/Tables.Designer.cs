namespace PC_SHOP
{
    partial class Tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip_Connection = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Connection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton_Menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Menu = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip_Connection.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(11, 57);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 24;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(562, 293);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // statusStrip_Connection
            // 
            this.statusStrip_Connection.AllowMerge = false;
            this.statusStrip_Connection.BackColor = System.Drawing.Color.White;
            this.statusStrip_Connection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip_Connection.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip_Connection.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Connection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Connection,
            this.toolStripDropDownButton_Menu});
            this.statusStrip_Connection.Location = new System.Drawing.Point(0, 0);
            this.statusStrip_Connection.Name = "statusStrip_Connection";
            this.statusStrip_Connection.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip_Connection.Size = new System.Drawing.Size(584, 22);
            this.statusStrip_Connection.SizingGrip = false;
            this.statusStrip_Connection.TabIndex = 2;
            // 
            // toolStripStatusLabel_Connection
            // 
            this.toolStripStatusLabel_Connection.ActiveLinkColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_Connection.Name = "toolStripStatusLabel_Connection";
            this.toolStripStatusLabel_Connection.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel_Connection.Text = "Current connection";
            // 
            // toolStripDropDownButton_Menu
            // 
            this.toolStripDropDownButton_Menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripDropDownButton_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.reconnectToolStripMenuItem,
            this.findToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.toolStripDropDownButton_Menu.ForeColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton_Menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Menu.Name = "toolStripDropDownButton_Menu";
            this.toolStripDropDownButton_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripDropDownButton_Menu.ShowDropDownArrow = false;
            this.toolStripDropDownButton_Menu.Size = new System.Drawing.Size(32, 20);
            this.toolStripDropDownButton_Menu.Text = "• • •";
            this.toolStripDropDownButton_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripDropDownButton_Menu.DropDownClosed += new System.EventHandler(this.toolStripDropDownButton_Menu_DropDownClosed);
            this.toolStripDropDownButton_Menu.DropDownOpened += new System.EventHandler(this.toolStripDropDownButton_Menu_DropDownOpened);
            this.toolStripDropDownButton_Menu.MouseEnter += new System.EventHandler(this.toolStripDropDownButton_Menu_MouseEnter);
            this.toolStripDropDownButton_Menu.MouseLeave += new System.EventHandler(this.toolStripDropDownButton_Menu_MouseLeave);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add New Row";
            this.addToolStripMenuItem.ToolTipText = "Ctrl + N";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            this.addToolStripMenuItem.MouseEnter += new System.EventHandler(this.addToolStripMenuItem_MouseEnter);
            this.addToolStripMenuItem.MouseLeave += new System.EventHandler(this.addToolStripMenuItem_MouseLeave);
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            this.reconnectToolStripMenuItem.ToolTipText = "Ctrl + R";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            this.reconnectToolStripMenuItem.MouseEnter += new System.EventHandler(this.reconnectToolStripMenuItem_MouseEnter);
            this.reconnectToolStripMenuItem.MouseLeave += new System.EventHandler(this.reconnectToolStripMenuItem_MouseLeave);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.findToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findToolStripMenuItem.Text = "Find All Data By Key";
            this.findToolStripMenuItem.ToolTipText = "Ctrl + F";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            this.findToolStripMenuItem.MouseEnter += new System.EventHandler(this.findToolStripMenuItem_MouseEnter);
            this.findToolStripMenuItem.MouseLeave += new System.EventHandler(this.findToolStripMenuItem_MouseLeave);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete Selected Row";
            this.deleteToolStripMenuItem.ToolTipText = "Ctrl + D";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            this.deleteToolStripMenuItem.MouseEnter += new System.EventHandler(this.deleteToolStripMenuItem_MouseEnter);
            this.deleteToolStripMenuItem.MouseLeave += new System.EventHandler(this.deleteToolStripMenuItem_MouseLeave);
            // 
            // toolStrip_Menu
            // 
            this.toolStrip_Menu.BackColor = System.Drawing.Color.White;
            this.toolStrip_Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_Menu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.toolStrip_Menu.Location = new System.Drawing.Point(0, 22);
            this.toolStrip_Menu.Name = "toolStrip_Menu";
            this.toolStrip_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_Menu.Size = new System.Drawing.Size(584, 25);
            this.toolStrip_Menu.TabIndex = 0;
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.toolStrip_Menu);
            this.Controls.Add(this.statusStrip_Connection);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "Tables";
            this.Text = "Tables form";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tables_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Tables_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tables_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip_Connection.ResumeLayout(false);
            this.statusStrip_Connection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Connection;
        private System.Windows.Forms.StatusStrip statusStrip_Connection;
        private System.Windows.Forms.ToolStrip toolStrip_Menu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Menu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
    }
}