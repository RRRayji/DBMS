namespace PC_SHOP
{
    partial class DatabaseInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseInput));
            this.textBox_DatabaseName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_DatabaseName
            // 
            this.textBox_DatabaseName.Location = new System.Drawing.Point(12, 12);
            this.textBox_DatabaseName.Name = "textBox_DatabaseName";
            this.textBox_DatabaseName.Size = new System.Drawing.Size(146, 22);
            this.textBox_DatabaseName.TabIndex = 0;
            this.textBox_DatabaseName.Enter += new System.EventHandler(this.textBox_DatabaseName_Enter);
            this.textBox_DatabaseName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DatabaseName_KeyDown);
            this.textBox_DatabaseName.Leave += new System.EventHandler(this.textBox_DatabaseName_Leave);
            // 
            // DatabaseInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 46);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_DatabaseName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseInput";
            this.Text = "Input database name";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseInput_FormClosed);
            this.Resize += new System.EventHandler(this.DatabaseInput_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_DatabaseName;
    }
}