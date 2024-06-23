namespace PC_SHOP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.maskedTextPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelNotRegistered = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Name";
            this.textBoxName.WordWrap = false;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // maskedTextPassword
            // 
            this.maskedTextPassword.BackColor = System.Drawing.Color.White;
            this.maskedTextPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextPassword.ForeColor = System.Drawing.Color.Black;
            this.maskedTextPassword.Location = new System.Drawing.Point(13, 53);
            this.maskedTextPassword.Name = "maskedTextPassword";
            this.maskedTextPassword.Size = new System.Drawing.Size(198, 22);
            this.maskedTextPassword.TabIndex = 1;
            this.maskedTextPassword.Text = "Password";
            this.maskedTextPassword.Enter += new System.EventHandler(this.maskedTextPassword_Enter);
            this.maskedTextPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextPassword_KeyPress);
            this.maskedTextPassword.Leave += new System.EventHandler(this.maskedTextPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnLogin.Location = new System.Drawing.Point(72, 107);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // labelNotRegistered
            // 
            this.labelNotRegistered.AutoSize = true;
            this.labelNotRegistered.BackColor = System.Drawing.Color.White;
            this.labelNotRegistered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNotRegistered.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelNotRegistered.ForeColor = System.Drawing.Color.Black;
            this.labelNotRegistered.Location = new System.Drawing.Point(119, 83);
            this.labelNotRegistered.Name = "labelNotRegistered";
            this.labelNotRegistered.Size = new System.Drawing.Size(96, 13);
            this.labelNotRegistered.TabIndex = 3;
            this.labelNotRegistered.Text = "Sign Up (Ctrl + R)";
            this.labelNotRegistered.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelNotRegistered_MouseClick);
            this.labelNotRegistered.MouseEnter += new System.EventHandler(this.labelNotRegistered_MouseEnter);
            this.labelNotRegistered.MouseLeave += new System.EventHandler(this.labelNotRegistered_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(224, 146);
            this.Controls.Add(this.labelNotRegistered);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.maskedTextPassword);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Log in";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelNotRegistered;
    }
}

