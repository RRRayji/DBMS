namespace PC_SHOP
{
    partial class CreationTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationTool));
            this.button_Create = new System.Windows.Forms.Button();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.comboBox_UsingDatabase = new System.Windows.Forms.ComboBox();
            this.label_UsingDatabase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Create
            // 
            this.button_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Create.Location = new System.Drawing.Point(20, 25);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 2;
            this.button_Create.Text = "1. Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.buttonCreate_Click);
            this.button_Create.MouseEnter += new System.EventHandler(this.button_Create_Enter);
            this.button_Create.MouseLeave += new System.EventHandler(this.button_Create_Leave);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Database",
            "Table"});
            this.comboBox_Type.Location = new System.Drawing.Point(145, 26);
            this.comboBox_Type.MaxDropDownItems = 2;
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(132, 21);
            this.comboBox_Type.TabIndex = 0;
            this.comboBox_Type.SelectedValueChanged += new System.EventHandler(this.comboBox_Type_SelectedValueChanged);
            // 
            // button_Update
            // 
            this.button_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Location = new System.Drawing.Point(20, 75);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "2. Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            this.button_Update.MouseEnter += new System.EventHandler(this.button_Update_Enter);
            this.button_Update.MouseLeave += new System.EventHandler(this.button_Update_Leave);
            // 
            // button_Delete
            // 
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Location = new System.Drawing.Point(20, 125);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "3. Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            this.button_Delete.MouseEnter += new System.EventHandler(this.button_Delete_Enter);
            this.button_Delete.MouseLeave += new System.EventHandler(this.button_Delete_Leave);
            // 
            // comboBox_UsingDatabase
            // 
            this.comboBox_UsingDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UsingDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_UsingDatabase.FormattingEnabled = true;
            this.comboBox_UsingDatabase.Items.AddRange(new object[] {
            "тут",
            "будут",
            "названия",
            "баз",
            "данных"});
            this.comboBox_UsingDatabase.Location = new System.Drawing.Point(145, 76);
            this.comboBox_UsingDatabase.Name = "comboBox_UsingDatabase";
            this.comboBox_UsingDatabase.Size = new System.Drawing.Size(132, 21);
            this.comboBox_UsingDatabase.TabIndex = 1;
            this.comboBox_UsingDatabase.Visible = false;
            this.comboBox_UsingDatabase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_UsingDatabase_KeyDown);
            // 
            // label_UsingDatabase
            // 
            this.label_UsingDatabase.AutoSize = true;
            this.label_UsingDatabase.BackColor = System.Drawing.SystemColors.Control;
            this.label_UsingDatabase.Location = new System.Drawing.Point(145, 60);
            this.label_UsingDatabase.Name = "label_UsingDatabase";
            this.label_UsingDatabase.Size = new System.Drawing.Size(90, 13);
            this.label_UsingDatabase.TabIndex = 5;
            this.label_UsingDatabase.Text = "Using database:";
            this.label_UsingDatabase.Visible = false;
            // 
            // CreationTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 171);
            this.Controls.Add(this.label_UsingDatabase);
            this.Controls.Add(this.comboBox_UsingDatabase);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.button_Create);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CreationTool";
            this.Text = "Creation Tool";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_CreationTool_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreationTool_KeyDown);
            this.Resize += new System.EventHandler(this.CreationTool_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ComboBox comboBox_UsingDatabase;
        private System.Windows.Forms.Label label_UsingDatabase;
    }
}

