namespace PC_SHOP
{
    partial class TableSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSelect));
            this.comboBox_TableName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TableName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_TableName.FormattingEnabled = true;
            this.comboBox_TableName.Location = new System.Drawing.Point(12, 12);
            this.comboBox_TableName.Name = "comboBox_TableName";
            this.comboBox_TableName.Size = new System.Drawing.Size(146, 21);
            this.comboBox_TableName.TabIndex = 1;
            this.comboBox_TableName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_TableName_KeyDown);
            // 
            // TableSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 45);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox_TableName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableSelect";
            this.Text = "Select table from ";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_TableSelect_FormClosed);
            this.Resize += new System.EventHandler(this.TableSelect_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_TableName;
    }
}