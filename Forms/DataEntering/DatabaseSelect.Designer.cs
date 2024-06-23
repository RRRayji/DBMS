namespace PC_SHOP
{
    partial class DatabaseSelect
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseSelect));
            this.comboBox_DatabaseName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_DatabaseName
            // 
            this.comboBox_DatabaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DatabaseName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_DatabaseName.FormattingEnabled = true;
            this.comboBox_DatabaseName.Location = new System.Drawing.Point(12, 12);
            this.comboBox_DatabaseName.Name = "comboBox_DatabaseName";
            this.comboBox_DatabaseName.Size = new System.Drawing.Size(146, 21);
            this.comboBox_DatabaseName.TabIndex = 0;
            this.comboBox_DatabaseName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_DatabaseName_KeyDown);
            // 
            // DatabaseSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 45);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox_DatabaseName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseSelect";
            this.Text = "Select database name";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_DatabaseInput_FormClosed);
            this.Resize += new System.EventHandler(this.DatabaseSelect_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_DatabaseName;
    }
}