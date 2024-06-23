namespace PC_SHOP
{
    partial class FindByKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindByKey));
            this.textBox_KeyValue = new System.Windows.Forms.TextBox();
            this.checkBox_Pre = new System.Windows.Forms.CheckBox();
            this.checkBox_Post = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_KeyValue
            // 
            this.textBox_KeyValue.Location = new System.Drawing.Point(20, 12);
            this.textBox_KeyValue.Name = "textBox_KeyValue";
            this.textBox_KeyValue.Size = new System.Drawing.Size(156, 22);
            this.textBox_KeyValue.TabIndex = 0;
            this.textBox_KeyValue.Enter += new System.EventHandler(this.textBox_KeyValue_Enter);
            this.textBox_KeyValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyValue_KeyDown);
            this.textBox_KeyValue.Leave += new System.EventHandler(this.textBox_KeyValue_Leave);
            // 
            // checkBox_Pre
            // 
            this.checkBox_Pre.AutoSize = true;
            this.checkBox_Pre.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.checkBox_Pre.Location = new System.Drawing.Point(20, 38);
            this.checkBox_Pre.Name = "checkBox_Pre";
            this.checkBox_Pre.Size = new System.Drawing.Size(73, 17);
            this.checkBox_Pre.TabIndex = 1;
            this.checkBox_Pre.Text = "%pattern";
            this.checkBox_Pre.UseVisualStyleBackColor = true;
            // 
            // checkBox_Post
            // 
            this.checkBox_Post.AutoSize = true;
            this.checkBox_Post.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.checkBox_Post.Location = new System.Drawing.Point(101, 38);
            this.checkBox_Post.Name = "checkBox_Post";
            this.checkBox_Post.Size = new System.Drawing.Size(73, 17);
            this.checkBox_Post.TabIndex = 2;
            this.checkBox_Post.Text = "pattern%";
            this.checkBox_Post.UseVisualStyleBackColor = true;
            // 
            // FindByKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 69);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox_Post);
            this.Controls.Add(this.checkBox_Pre);
            this.Controls.Add(this.textBox_KeyValue);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindByKey";
            this.Text = "Enter Key Value (pattern)";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindByKey_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindByKey_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_KeyValue;
        private System.Windows.Forms.CheckBox checkBox_Pre;
        private System.Windows.Forms.CheckBox checkBox_Post;
    }
}