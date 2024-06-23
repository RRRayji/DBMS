namespace PC_SHOP
{
    partial class AddRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRow));
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Data
            // 
            this.textBox_Data.BackColor = System.Drawing.Color.White;
            this.textBox_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Data.ForeColor = System.Drawing.Color.Black;
            this.textBox_Data.Location = new System.Drawing.Point(12, 13);
            this.textBox_Data.MaxLength = 24;
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(200, 22);
            this.textBox_Data.TabIndex = 0;
            this.textBox_Data.WordWrap = false;
            this.textBox_Data.Enter += new System.EventHandler(this.textBox_Data_Enter);
            this.textBox_Data.Leave += new System.EventHandler(this.textBox_Data_Leave);
            // 
            // AddRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(224, 48);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_Data);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRow";
            this.Text = "Add New Row";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddRow_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddRow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Data;
    }
}