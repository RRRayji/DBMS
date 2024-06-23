namespace PC_SHOP
{
    partial class TableInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableInput));
            this.textBox_TableName = new System.Windows.Forms.TextBox();
            this.label_TableName = new System.Windows.Forms.Label();
            this.checkBox_PrimaryKey = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoIncrement = new System.Windows.Forms.CheckBox();
            this.textBox_VariableName = new System.Windows.Forms.TextBox();
            this.label_VariableName = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.richTextBox_Query = new System.Windows.Forms.RichTextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.comboBox_VariableType = new System.Windows.Forms.ComboBox();
            this.button_ForeignKey = new System.Windows.Forms.Button();
            this.checkBox_NotNull = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TableName.Location = new System.Drawing.Point(180, 15);
            this.textBox_TableName.MaxLength = 16;
            this.textBox_TableName.Name = "textBox_TableName";
            this.textBox_TableName.Size = new System.Drawing.Size(120, 22);
            this.textBox_TableName.TabIndex = 0;
            this.textBox_TableName.TextChanged += new System.EventHandler(this.textBox_TableName_TextChanged);
            this.textBox_TableName.Enter += new System.EventHandler(this.textBox_TableName_Enter);
            this.textBox_TableName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TableName_KeyPress);
            this.textBox_TableName.Leave += new System.EventHandler(this.textBox_TableName_Leave);
            // 
            // label_TableName
            // 
            this.label_TableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TableName.Location = new System.Drawing.Point(18, 19);
            this.label_TableName.Name = "label_TableName";
            this.label_TableName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_TableName.Size = new System.Drawing.Size(145, 13);
            this.label_TableName.TabIndex = 1;
            this.label_TableName.Text = "Enter Table Name";
            // 
            // checkBox_PrimaryKey
            // 
            this.checkBox_PrimaryKey.Location = new System.Drawing.Point(50, 139);
            this.checkBox_PrimaryKey.Name = "checkBox_PrimaryKey";
            this.checkBox_PrimaryKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_PrimaryKey.Size = new System.Drawing.Size(110, 17);
            this.checkBox_PrimaryKey.TabIndex = 2;
            this.checkBox_PrimaryKey.Text = "Primary Key";
            this.checkBox_PrimaryKey.UseVisualStyleBackColor = false;
            this.checkBox_PrimaryKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBox_PrimaryKey_KeyPress);
            // 
            // checkBox_AutoIncrement
            // 
            this.checkBox_AutoIncrement.Location = new System.Drawing.Point(50, 109);
            this.checkBox_AutoIncrement.Name = "checkBox_AutoIncrement";
            this.checkBox_AutoIncrement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_AutoIncrement.Size = new System.Drawing.Size(110, 17);
            this.checkBox_AutoIncrement.TabIndex = 3;
            this.checkBox_AutoIncrement.Text = "Auto Inc";
            this.checkBox_AutoIncrement.UseVisualStyleBackColor = true;
            this.checkBox_AutoIncrement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBox_AutoIncrement_KeyPress);
            // 
            // textBox_VariableName
            // 
            this.textBox_VariableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_VariableName.Location = new System.Drawing.Point(180, 45);
            this.textBox_VariableName.MaxLength = 16;
            this.textBox_VariableName.Name = "textBox_VariableName";
            this.textBox_VariableName.Size = new System.Drawing.Size(120, 22);
            this.textBox_VariableName.TabIndex = 4;
            this.textBox_VariableName.Enter += new System.EventHandler(this.textBox_VariableName_Enter);
            this.textBox_VariableName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_VariableName_KeyPress);
            this.textBox_VariableName.Leave += new System.EventHandler(this.textBox_VariableName_Leave);
            // 
            // label_VariableName
            // 
            this.label_VariableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_VariableName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label_VariableName.Location = new System.Drawing.Point(18, 49);
            this.label_VariableName.Name = "label_VariableName";
            this.label_VariableName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_VariableName.Size = new System.Drawing.Size(145, 13);
            this.label_VariableName.TabIndex = 6;
            this.label_VariableName.Text = "Enter Variable Name";
            // 
            // button_Add
            // 
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(180, 105);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(120, 22);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Add Variable";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            this.button_Add.MouseEnter += new System.EventHandler(this.button_Add_MouseEnter);
            this.button_Add.MouseLeave += new System.EventHandler(this.button_Add_MouseLeave);
            // 
            // richTextBox_Query
            // 
            this.richTextBox_Query.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox_Query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Query.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Query.Location = new System.Drawing.Point(320, 15);
            this.richTextBox_Query.Name = "richTextBox_Query";
            this.richTextBox_Query.ReadOnly = true;
            this.richTextBox_Query.Size = new System.Drawing.Size(265, 215);
            this.richTextBox_Query.TabIndex = 8;
            this.richTextBox_Query.Text = "";
            // 
            // button_Create
            // 
            this.button_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Create.Location = new System.Drawing.Point(20, 200);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(80, 30);
            this.button_Create.TabIndex = 9;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            this.button_Create.MouseEnter += new System.EventHandler(this.button_Create_MouseEnter);
            this.button_Create.MouseLeave += new System.EventHandler(this.button_Create_MouseLeave);
            // 
            // comboBox_VariableType
            // 
            this.comboBox_VariableType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_VariableType.FormattingEnabled = true;
            this.comboBox_VariableType.Items.AddRange(new object[] {
            "INT",
            "FLOAT",
            "CHAR",
            "VARCHAR",
            "DECIMAL",
            "BINARY",
            "DATE"});
            this.comboBox_VariableType.Location = new System.Drawing.Point(180, 75);
            this.comboBox_VariableType.Name = "comboBox_VariableType";
            this.comboBox_VariableType.Size = new System.Drawing.Size(120, 21);
            this.comboBox_VariableType.TabIndex = 10;
            this.comboBox_VariableType.Enter += new System.EventHandler(this.comboBox_VariableType_Enter);
            this.comboBox_VariableType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_VariableType_KeyPress);
            this.comboBox_VariableType.Leave += new System.EventHandler(this.comboBox_VariableType_Leave);
            // 
            // button_ForeignKey
            // 
            this.button_ForeignKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ForeignKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ForeignKey.Location = new System.Drawing.Point(180, 135);
            this.button_ForeignKey.Margin = new System.Windows.Forms.Padding(2);
            this.button_ForeignKey.Name = "button_ForeignKey";
            this.button_ForeignKey.Size = new System.Drawing.Size(120, 22);
            this.button_ForeignKey.TabIndex = 11;
            this.button_ForeignKey.Text = "Foreign Key";
            this.button_ForeignKey.UseVisualStyleBackColor = true;
            this.button_ForeignKey.Click += new System.EventHandler(this.button_ForeignKey_Click);
            this.button_ForeignKey.MouseEnter += new System.EventHandler(this.button_ForeignKey_MouseEnter);
            this.button_ForeignKey.MouseLeave += new System.EventHandler(this.button_ForeignKey_MouseLeave);
            // 
            // checkBox_NotNull
            // 
            this.checkBox_NotNull.Location = new System.Drawing.Point(50, 79);
            this.checkBox_NotNull.Name = "checkBox_NotNull";
            this.checkBox_NotNull.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_NotNull.Size = new System.Drawing.Size(110, 17);
            this.checkBox_NotNull.TabIndex = 12;
            this.checkBox_NotNull.Text = "Not Null";
            this.checkBox_NotNull.UseVisualStyleBackColor = false;
            this.checkBox_NotNull.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBox_NotNull_KeyPress);
            // 
            // TableInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 246);
            this.Controls.Add(this.checkBox_NotNull);
            this.Controls.Add(this.button_ForeignKey);
            this.Controls.Add(this.comboBox_VariableType);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.richTextBox_Query);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_VariableName);
            this.Controls.Add(this.textBox_VariableName);
            this.Controls.Add(this.checkBox_AutoIncrement);
            this.Controls.Add(this.checkBox_PrimaryKey);
            this.Controls.Add(this.label_TableName);
            this.Controls.Add(this.textBox_TableName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TableInput";
            this.Text = "Input Table Data";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableInput_FormClosed);
            this.Shown += new System.EventHandler(this.TableInput_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TableInput_KeyDown);
            this.Resize += new System.EventHandler(this.TableInput_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TableName;
        private System.Windows.Forms.Label label_TableName;
        private System.Windows.Forms.CheckBox checkBox_PrimaryKey;
        private System.Windows.Forms.CheckBox checkBox_AutoIncrement;
        private System.Windows.Forms.TextBox textBox_VariableName;
        private System.Windows.Forms.Label label_VariableName;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.RichTextBox richTextBox_Query;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.ComboBox comboBox_VariableType;
        private System.Windows.Forms.Button button_ForeignKey;
        private System.Windows.Forms.CheckBox checkBox_NotNull;
    }
}