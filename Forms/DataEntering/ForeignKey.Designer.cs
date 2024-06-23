namespace PC_SHOP
{
    partial class ForeignKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForeignKey));
            this.comboBox_FromTable = new System.Windows.Forms.ComboBox();
            this.label_FromTable = new System.Windows.Forms.Label();
            this.label_FromVariable = new System.Windows.Forms.Label();
            this.comboBox_FromVariable = new System.Windows.Forms.ComboBox();
            this.comboBox_Column = new System.Windows.Forms.ComboBox();
            this.label_Column = new System.Windows.Forms.Label();
            this.checkBox_Cascade = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox_FromTable
            // 
            this.comboBox_FromTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FromTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_FromTable.FormattingEnabled = true;
            this.comboBox_FromTable.Location = new System.Drawing.Point(150, 32);
            this.comboBox_FromTable.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_FromTable.Name = "comboBox_FromTable";
            this.comboBox_FromTable.Size = new System.Drawing.Size(108, 21);
            this.comboBox_FromTable.TabIndex = 1;
            this.comboBox_FromTable.SelectedIndexChanged += new System.EventHandler(this.comboBox_FromTable_SelectedIndexChanged);
            this.comboBox_FromTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_FromTable_KeyDown);
            // 
            // label_FromTable
            // 
            this.label_FromTable.AutoSize = true;
            this.label_FromTable.Location = new System.Drawing.Point(156, 18);
            this.label_FromTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FromTable.Name = "label_FromTable";
            this.label_FromTable.Size = new System.Drawing.Size(96, 13);
            this.label_FromTable.TabIndex = 1;
            this.label_FromTable.Text = "From which table";
            // 
            // label_FromVariable
            // 
            this.label_FromVariable.AutoSize = true;
            this.label_FromVariable.Location = new System.Drawing.Point(283, 18);
            this.label_FromVariable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FromVariable.Name = "label_FromVariable";
            this.label_FromVariable.Size = new System.Drawing.Size(110, 13);
            this.label_FromVariable.TabIndex = 3;
            this.label_FromVariable.Text = "From which variable";
            // 
            // comboBox_FromVariable
            // 
            this.comboBox_FromVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FromVariable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_FromVariable.FormattingEnabled = true;
            this.comboBox_FromVariable.Location = new System.Drawing.Point(285, 32);
            this.comboBox_FromVariable.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_FromVariable.Name = "comboBox_FromVariable";
            this.comboBox_FromVariable.Size = new System.Drawing.Size(108, 21);
            this.comboBox_FromVariable.TabIndex = 2;
            this.comboBox_FromVariable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_FromVariable_KeyDown);
            // 
            // comboBox_Column
            // 
            this.comboBox_Column.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Column.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Column.FormattingEnabled = true;
            this.comboBox_Column.Location = new System.Drawing.Point(15, 32);
            this.comboBox_Column.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Column.Name = "comboBox_Column";
            this.comboBox_Column.Size = new System.Drawing.Size(108, 21);
            this.comboBox_Column.TabIndex = 0;
            this.comboBox_Column.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_Column_KeyDown);
            // 
            // label_Column
            // 
            this.label_Column.AutoSize = true;
            this.label_Column.Location = new System.Drawing.Point(28, 18);
            this.label_Column.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Column.Name = "label_Column";
            this.label_Column.Size = new System.Drawing.Size(81, 13);
            this.label_Column.TabIndex = 6;
            this.label_Column.Text = "Which column";
            // 
            // checkBox_Cascade
            // 
            this.checkBox_Cascade.AutoSize = true;
            this.checkBox_Cascade.Location = new System.Drawing.Point(411, 33);
            this.checkBox_Cascade.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Cascade.Name = "checkBox_Cascade";
            this.checkBox_Cascade.Size = new System.Drawing.Size(134, 17);
            this.checkBox_Cascade.TabIndex = 3;
            this.checkBox_Cascade.Text = "ON DELETE CASCADE";
            this.checkBox_Cascade.UseVisualStyleBackColor = true;
            // 
            // ForeignKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 72);
            this.Controls.Add(this.checkBox_Cascade);
            this.Controls.Add(this.label_Column);
            this.Controls.Add(this.comboBox_Column);
            this.Controls.Add(this.label_FromVariable);
            this.Controls.Add(this.comboBox_FromVariable);
            this.Controls.Add(this.label_FromTable);
            this.Controls.Add(this.comboBox_FromTable);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ForeignKey";
            this.Text = "ForeignKey";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForeignKey_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForeignKey_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_FromTable;
        private System.Windows.Forms.Label label_FromTable;
        private System.Windows.Forms.Label label_FromVariable;
        private System.Windows.Forms.ComboBox comboBox_FromVariable;
        private System.Windows.Forms.ComboBox comboBox_Column;
        private System.Windows.Forms.Label label_Column;
        private System.Windows.Forms.CheckBox checkBox_Cascade;
    }
}