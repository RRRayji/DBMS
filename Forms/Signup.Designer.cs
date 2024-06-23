namespace PC_SHOP
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.maskedTextPassword = new System.Windows.Forms.MaskedTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.maskedTextPasswordRepeat = new System.Windows.Forms.MaskedTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextPassword
            // 
            this.maskedTextPassword.BackColor = System.Drawing.Color.White;
            this.maskedTextPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextPassword.ForeColor = System.Drawing.Color.Black;
            this.maskedTextPassword.Location = new System.Drawing.Point(13, 53);
            this.maskedTextPassword.Name = "maskedTextPassword";
            this.maskedTextPassword.Size = new System.Drawing.Size(198, 22);
            this.maskedTextPassword.TabIndex = 3;
            this.maskedTextPassword.Text = "Password";
            this.maskedTextPassword.Enter += new System.EventHandler(this.maskedTextPassword_Enter);
            this.maskedTextPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextPassword_KeyPress);
            this.maskedTextPassword.Leave += new System.EventHandler(this.maskedTextPassword_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(13, 13);
            this.textBoxName.MaxLength = 24;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 22);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Text = "Name";
            this.textBoxName.WordWrap = false;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // maskedTextPasswordRepeat
            // 
            this.maskedTextPasswordRepeat.BackColor = System.Drawing.Color.White;
            this.maskedTextPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextPasswordRepeat.ForeColor = System.Drawing.Color.Black;
            this.maskedTextPasswordRepeat.Location = new System.Drawing.Point(13, 93);
            this.maskedTextPasswordRepeat.Name = "maskedTextPasswordRepeat";
            this.maskedTextPasswordRepeat.Size = new System.Drawing.Size(198, 22);
            this.maskedTextPasswordRepeat.TabIndex = 4;
            this.maskedTextPasswordRepeat.Text = "Password repeat";
            this.maskedTextPasswordRepeat.Enter += new System.EventHandler(this.maskedTextPasswordRepeat_Enter);
            this.maskedTextPasswordRepeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextPasswordRepeat_KeyPress);
            this.maskedTextPasswordRepeat.Leave += new System.EventHandler(this.maskedTextPasswordRepeat_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(72, 147);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(80, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelBack.ForeColor = System.Drawing.Color.Black;
            this.labelBack.Location = new System.Drawing.Point(89, 123);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(127, 13);
            this.labelBack.TabIndex = 6;
            this.labelBack.Text = "Back to Log in (Ctrl + R)";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            this.labelBack.MouseEnter += new System.EventHandler(this.labelBack_MouseEnter);
            this.labelBack.MouseLeave += new System.EventHandler(this.labelBack_MouseLeave);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(224, 186);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.maskedTextPasswordRepeat);
            this.Controls.Add(this.maskedTextPassword);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Signup";
            this.Text = "Sign up";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Signup_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Signup_KeyDown);
            this.Resize += new System.EventHandler(this.Signup_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextPasswordRepeat;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelBack;
    }
}