namespace PC_SHOP
{
    partial class CharCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharCount));
            this.count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(12, 12);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(124, 22);
            this.count.TabIndex = 0;
            this.count.Enter += new System.EventHandler(this.count_Enter);
            this.count.Leave += new System.EventHandler(this.count_Leave);
            // 
            // CharCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 45);
            this.ControlBox = false;
            this.Controls.Add(this.count);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CharCount";
            this.Text = "Enter count of chars";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_CharCount_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_CharCount_KeyPress);
            this.Resize += new System.EventHandler(this.CharCount_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox count;
    }
}