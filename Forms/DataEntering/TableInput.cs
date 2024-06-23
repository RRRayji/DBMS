using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class TableInput : Form
    {
        public TableInput(ref string[] titles)
        {
            InitializeComponent();
            InitColors();
            this.StartPosition = FormStartPosition.CenterScreen;
            CurrentRow.ClearCurrentData();
            comboBox_VariableType.SelectedIndex = 0;
            this._titles = titles;
            _startSize[0] = this.Width;//552;
            _startSize[1] = this.Height;//279;
            Set_startSize();
            CurrentRow.separator = "\n  ";
            CurrentRow.openP = (byte)(_query.IndexOf('(', 14) + 1);
        }

        private bool isCreation = false;
        private string _query = "CREATE TABLE  (";
        private string _refQuery = null;
        public delegate void ValueReturnedEventHandler(string query);
        public event ValueReturnedEventHandler ValueReturnedEvent;
        private string[] _titles;
        private System.Collections.Generic.List<string> _variableNames = new System.Collections.Generic.List<string>();
        private int[] _startSize = new int[2];
        private string _primaryVariableName = null;


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            textBox_TableName.ForeColor = Colors.lightGrey;
            textBox_TableName.BackColor = Colors.blue;
            textBox_VariableName.ForeColor = Colors.lightGrey;
            textBox_VariableName.BackColor = Colors.blue;
            comboBox_VariableType.ForeColor = Colors.lightGrey;
            comboBox_VariableType.BackColor = Colors.blue;
            richTextBox_Query.ForeColor = Colors.lightBlue;
            richTextBox_Query.BackColor = Colors.blue;
            button_Create.ForeColor = Colors.lightGrey;
            button_Create.BackColor = Colors.blue;
            button_Create.FlatAppearance.BorderColor = Colors.lightGrey;
            button_Create.FlatAppearance.BorderSize = 1;
            button_Add.ForeColor = Colors.lightGrey;
            button_Add.BackColor = Colors.blue;
            button_Add.FlatAppearance.BorderColor = Colors.lightGrey;
            button_Add.FlatAppearance.BorderSize = 1;
            button_ForeignKey.ForeColor = Colors.lightGrey;
            button_ForeignKey.BackColor = Colors.blue;
            button_ForeignKey.FlatAppearance.BorderColor = Colors.lightGrey;
            button_ForeignKey.FlatAppearance.BorderSize = 1;
        }

        private void Update_richTextBox_Query()
        {
            switch (_refQuery)
            {
                case null:
                    richTextBox_Query.Text = (CurrentRow.Text != null) ? _query.Insert(_query.IndexOf(CurrentRow.Text) - 1, ">") : _query;
                    return;
                default:
                    switch (CurrentRow.Text != null)
                    {
                        case true:
                            if (_query.IndexOf(CurrentRow.Text) == -1 && CurrentRow.rowsCount > 0)
                            {
                                CurrentRow.id = 0;
                                CurrentRow.SetText(_query);
                            }
                            richTextBox_Query.Text = $"{_query.Insert(_query.IndexOf(CurrentRow.Text) - 1, ">")}\n);\n{_refQuery}";
                            return;
                        case false:
                            richTextBox_Query.Text = $"{_query}\n);\n{_refQuery}";
                            return;
                    }
                    return;
            }
        }

        private void Set_startSize()
        {
            this.Width = _startSize[0];
            this.Height = _startSize[1];
        }

        private bool CheckTypeValid()
        {
            for (byte i = 0; i < comboBox_VariableType.Items.Count; ++i)
            {
                if (comboBox_VariableType.Text.Length >= comboBox_VariableType.Items[i].ToString().Length && comboBox_VariableType.Text.ToUpper().Substring(0, comboBox_VariableType.Items[i].ToString().Length) == comboBox_VariableType.Items[i].ToString())
                    return true;
            }
            return false;
        }

        private void Add()
        {
            switch (CheckTypeValid())
            {
                case true:
                    break;
                case false:
                    MessageBox.Show("Invalid type name. It should look like this: decimal(10,2).", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox_VariableType.Text = comboBox_VariableType.Items[0].ToString();
                    comboBox_VariableType.Focus();
                    return;
            }
            foreach (string var in _variableNames)
            {
                switch (textBox_VariableName.Text == var)
                {
                    case true:
                        MessageBox.Show("A variable with the same name already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox_VariableName.Text = "";
                        textBox_VariableName.Focus();
                        return;
                    case false: continue;
                }
            }

            ++CurrentRow.id;
            _variableNames.Add(textBox_VariableName.Text);
            if (_query[_query.Length - 1] != '(')
            {
                _query += $",{CurrentRow.separator}";
            }
            else _query += CurrentRow.separator;
            _query += textBox_VariableName.Text + " " + comboBox_VariableType.Text.ToUpper();
            _query += (checkBox_AutoIncrement.Checked) ? " IDENTITY(1, 1)" : "";
            if (checkBox_NotNull.Checked)
            {
                _query += " NOT NULL";
                checkBox_NotNull.CheckState = CheckState.Unchecked;
            }

            CurrentRow.SetLastText(_query);
            
            if (checkBox_PrimaryKey.Checked)
            {
                _refQuery += $"\nALTER TABLE TableName ADD CONSTRAINT PK_TableName PRIMARY KEY ({textBox_VariableName.Text});";
                _primaryVariableName = textBox_VariableName.Text;

                checkBox_PrimaryKey.CheckState = CheckState.Unchecked;
                checkBox_PrimaryKey.Hide();
            }

            Update_richTextBox_Query();
            checkBox_AutoIncrement.CheckState = CheckState.Unchecked;
            textBox_VariableName.Text = "";
            comboBox_VariableType.SelectedIndex = 0;
            textBox_VariableName.Focus();
        }

        private void Create()
        {
            if (_variableNames.Count < 1)
            {
                MessageBox.Show("There are no variables in this table.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (_titles.Contains(textBox_TableName.Text))
            {
            case true:
                MessageBox.Show("A table with the same name already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_TableName.Text = "";
                textBox_TableName.Focus();
                return;
            case false:
                switch (textBox_TableName.Text.Length > 1)
                {
                case true:
                    isCreation = true;
                    _query += ");";
                    _query += _refQuery;
                    _query = _query.Replace("TableName", textBox_TableName.Text);
                    _query = _query.Replace("\n", "");
                    this.Close();
                    return;
                case false:
                    MessageBox.Show("Two and more characters are required in the table name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_TableName.Text = "";
                    textBox_TableName.Focus();
                    return;
                }
                return;
            }
        }

        private void textBox_TableName_TextChanged(object sender, EventArgs e)
        {
            _query = _query.Remove(13, _query.IndexOf(" ", 13) - 13);
            _query = _query.Insert(13, textBox_TableName.Text);
            Update_richTextBox_Query();
            CurrentRow.openP = (byte)(_query.IndexOf('(', 14) + 1);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void textBox_TableName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox_VariableName.Focus();
            }
        }

        private void textBox_VariableName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboBox_VariableType.Focus();
            }
        }

        private void comboBox_VariableType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string selected = comboBox_VariableType.Text.ToUpper();
                if (selected == "CHAR" || selected == "VARCHAR")
                {
                    CharCount count = new CharCount();
                    count.ValueReturnedEvent += From_CharCount_ValueReturnedEvent;
                    count.Show();
                }
                else if (!checkBox_NotNull.Checked) checkBox_NotNull.Focus();
                else if (!checkBox_AutoIncrement.Checked) checkBox_AutoIncrement.Focus();
                else if (checkBox_PrimaryKey.Visible && !checkBox_PrimaryKey.Checked) checkBox_PrimaryKey.Focus();
                else Add();
            }
        }

        private void From_CharCount_ValueReturnedEvent(string count)
        {
            comboBox_VariableType.Text += $"({count})";
            button_Add.Focus();
        }


        private void checkBox_NotNull_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkBox_AutoIncrement.Focus();
            }
        }

        private void checkBox_AutoIncrement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                switch (checkBox_PrimaryKey.Visible)
                {
                    case true:
                        checkBox_PrimaryKey.Focus();
                        return;
                    case false:
                        Add();
                        return;
                }
            }
        }

        private void checkBox_PrimaryKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add();
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void TableInput_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter && e.Control))
            {
                ForeignKey();
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                Create();
            }
            else if (e.KeyCode == Keys.W && e.Shift && e.Control)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Up && !comboBox_VariableType.Focused)
            {
                --CurrentRow.id;
                CurrentRow.SetText(_query);
                Update_richTextBox_Query();
            }
            else if (e.KeyCode == Keys.Down && !comboBox_VariableType.Focused)
            {
                ++CurrentRow.id;
                CurrentRow.SetText(_query);
                Update_richTextBox_Query();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                switch (CurrentRow.rowsCount > 0)
                {
                    case true:
                        if (_primaryVariableName == CurrentRow.Delete(ref _query, ref _refQuery, ref _variableNames))
                        {
                            checkBox_PrimaryKey.Show();
                            _primaryVariableName = null;
                        }
                        Update_richTextBox_Query();
                        return;
                    case false:
                        MessageBox.Show("There are no variables in this table.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }
            }
            else if (e.KeyCode == Keys.PageUp)
            {
                MessageBox.Show($"'{_query}'\n{CurrentRow.rowsCount}", "TABLE QUERY");
            }
        }

        private void TableInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch(isCreation)
            {
                case true:
                    ValueReturnedEvent.Invoke(_query);
                    return;
                case false:
                    ValueReturnedEvent.Invoke(null);
                    return;
            }
        }

        private void TableInput_Resize(object sender, EventArgs e)
        {
            Set_startSize();
        }

        private void PFK_Handler()
        {
            string value = CurrentRow.FindByKey(_refQuery, $"PRIMARY KEY ({_primaryVariableName})", "\n");
            switch (value)
            {
                case null:
                    MessageBox.Show("Primary key value not found.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                default:
                    value = CurrentRow.FindByKey(_query, _primaryVariableName);
                    if (value.Contains(" NOT NULL")) return;
                    if (CurrentRow.closeSepId > 0)
                        _query = _query.Insert(CurrentRow.closeSepId - 1, " NOT NULL");
                    else
                        _query += " NOT NULL";
                    return;
            }
        }

        private void ForeignKey_ValueReturnedEvent(string query, bool isPFK)
        {
            switch (query)
            {
                case null:
                    this.Show();
                    return;
                default:
                    if (isPFK) PFK_Handler();
                    if (!_refQuery.Replace(" ON DELETE CASCADE", "").Contains(query.Replace(" ON DELETE CASCADE", ""))) this._refQuery += query;
                    else MessageBox.Show("This Foreign Key has already been declared.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Update_richTextBox_Query();
                    this.Show();
                    textBox_VariableName.Focus();
                    return;
            }
        }

        private void ForeignKey()
        {
            Connection.Reconnect();
            System.Collections.Generic.List<string> tableNames = new System.Collections.Generic.List<string>();
            Connection.SetQuery($"select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_CATALOG = '{Connection.environmentDatabaseName}';");
            System.Data.SqlClient.SqlDataReader reader = Connection.GetSqlCommand().ExecuteReader();
            while (reader.Read())
            {
                switch (reader[0].ToString())
                {
                    case "Account":
                        continue;
                    default:
                        tableNames.Add(reader[0].ToString());
                        continue;
                }
            }
            reader.Close();

            switch (tableNames.Count > 0 && _variableNames.Count > 0)
            {
                case true:
                    this.Hide();
                    ForeignKey fk = new ForeignKey(tableNames.ToArray(), _variableNames.ToArray(), _primaryVariableName);
                    fk.ValueReturnedEvent += ForeignKey_ValueReturnedEvent;
                    fk.Show();
                    return;
                case false:
                    MessageBox.Show("There is no more tables in current database or variables in new table.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
        }

        private void button_ForeignKey_Click(object sender, EventArgs e)
        {
            ForeignKey();
        }

        private void textBox_TableName_Enter(object sender, EventArgs e)
        {
            textBox_TableName.ForeColor = Colors.lightBlue;
        }

        private void textBox_TableName_Leave(object sender, EventArgs e)
        {
            textBox_TableName.ForeColor = Colors.lightGrey;
        }

        private void textBox_VariableName_Enter(object sender, EventArgs e)
        {
            textBox_VariableName.ForeColor = Colors.lightBlue;
        }

        private void textBox_VariableName_Leave(object sender, EventArgs e)
        {
            textBox_VariableName.ForeColor = Colors.lightGrey;
        }

        private void comboBox_VariableType_Enter(object sender, EventArgs e)
        {
            comboBox_VariableType.ForeColor = Colors.lightBlue;
        }

        private void comboBox_VariableType_Leave(object sender, EventArgs e)
        {
            comboBox_VariableType.ForeColor = Colors.lightGrey;
        }

        private void button_Add_MouseEnter(object sender, EventArgs e)
        {
            button_Add.ForeColor = Colors.lightBlue;
        }

        private void button_Add_MouseLeave(object sender, EventArgs e)
        {
            button_Add.ForeColor = Colors.lightGrey;
        }

        private void button_ForeignKey_MouseEnter(object sender, EventArgs e)
        {
            button_ForeignKey.ForeColor = Colors.lightBlue;
        }

        private void button_ForeignKey_MouseLeave(object sender, EventArgs e)
        {
            button_ForeignKey.ForeColor = Colors.lightGrey;
        }

        private void button_Create_MouseEnter(object sender, EventArgs e)
        {
            button_Create.ForeColor = Colors.lightBlue;
        }

        private void button_Create_MouseLeave(object sender, EventArgs e)
        {
            button_Create.ForeColor = Colors.lightGrey;
        }
        private abstract class CurrentRow
        {
            public static byte openP = 0;
            public static sbyte id = -1;
            public static string separator = null;
            public static sbyte rowsCount { get; private set; }
            public static ushort openSepId { get; private set; }
            public static ushort closeSepId { get; private set; }
            public static string Text { get; private set; }


            public static void ClearCurrentData()
            {
                id = -1;
                openP = 0;
                openSepId = closeSepId = 0;
                Text = null;
            }

            public static void SetLastText(string query)
            {
                if (rowsCount < 0) rowsCount = 0;
                id = rowsCount;
                ++rowsCount;
                openSepId = (ushort)query.LastIndexOf(separator);
                closeSepId = (ushort)query.Length;
                Text = query.Substring(openSepId, closeSepId - openSepId).Replace(separator, "");
                return;
            }

            public static void SetText(string query)
            {
                if (rowsCount < 1) return;
                openSepId = closeSepId = 0;
                if (CurrentRow.id < 0) CurrentRow.id = (sbyte)(rowsCount - 1);
                else if (CurrentRow.id >= rowsCount) CurrentRow.id = 0;
                sbyte currentIter = -1;
                for (ushort i = openP; i < query.Length - separator.Length; ++i)
                {
                    string sub = query.Substring(i, separator.Length);
                    if (sub == separator)
                    {
                        ++currentIter;
                        if (currentIter == CurrentRow.id)
                        {
                            openSepId = i;
                        }
                        else if (currentIter == CurrentRow.id + 1)
                        {
                            closeSepId = i;
                            break;
                        }
                    }
                }
                Text = query.Substring(openSepId, (closeSepId > 0) ? closeSepId - openSepId : query.Length - openSepId).Replace(separator, "");
            }

            public static void SetText(string query, bool isRefQuery)
            {
                if (rowsCount < 1) return;
                openSepId = closeSepId = 0;
                if (CurrentRow.id < 0) CurrentRow.id = (sbyte)(rowsCount - 1);
                else if (CurrentRow.id >= rowsCount) CurrentRow.id = 0;
                sbyte currentIter = -1;
                for (ushort i = ushort.MinValue; i < query.Length - separator.Length; ++i)
                {
                    string sub = query.Substring(i, separator.Length);
                    if (sub == separator)
                    {
                        ++currentIter;
                        if (currentIter == CurrentRow.id)
                        {
                            openSepId = i;
                        }
                        else if (currentIter == CurrentRow.id + 1)
                        {
                            closeSepId = i;
                            break;
                        }
                    }
                }
                Text = query.Substring(openSepId, (closeSepId > 0) ? closeSepId - openSepId : query.Length - openSepId).Replace(separator, "");
            }

            public static void SetTextContains(string query)
            {
                if (rowsCount < 1) return;
                openSepId = closeSepId = 0;
                if (CurrentRow.id < 0) CurrentRow.id = (sbyte)(rowsCount - 1);
                else if (CurrentRow.id >= rowsCount) CurrentRow.id = 0;
                int id = query.IndexOf(separator);
                if (id == -1) return;
            }

            public static string FindByKey(string query, string keyValue)
            {
                CurrentRow.id = 0;
                for (; CurrentRow.id < rowsCount; ++CurrentRow.id)
                {
                    SetText(query);
                    switch (Text.Contains(keyValue))
                    {
                        case true:
                            return Text;
                        case false:
                            continue;
                    }
                }
                return null;
            }

            public static string FindByKey(string query, string keyValue, string customSeparator)
            {
                string buff = separator;
                separator = customSeparator;
                CurrentRow.id = 0;
                for (; CurrentRow.id < rowsCount; ++CurrentRow.id)
                {
                    SetText(query, true);
                    switch (Text.Contains(keyValue))
                    {
                        case true:
                            separator = buff;
                            return Text;
                        case false:
                            continue;
                    }
                }
                separator = buff;
                return null;
            }

            public static string Delete(ref string query, ref string refQuery, ref List<string> variables)
            {
                query = query.Replace(separator + Text, "");
                string currentVaribleName = Text.Substring(0, Text.IndexOf(" "));
                variables.Remove(currentVaribleName);
                string value = FindByKey(refQuery, $" ({currentVaribleName})", "\n");
                while (value != null)
                {
                    refQuery = refQuery.Replace($"\n{value}", "");
                    value = FindByKey(refQuery, $" ({currentVaribleName})", "\n");    //  Наебалово - всё хуйня. Переписывай.
                }
                --rowsCount;
                Text = null;
                CurrentRow.id = 0;
                SetText(query);
                if (rowsCount < 2 && query[query.Length - 1] == ',') query = query.Remove(query.Length - 1, 1);
                return currentVaribleName;
            }
        }

        private void TableInput_Shown(object sender, EventArgs e)
        {
            CustomFont.Set_JetBrainsMono();
        }
    }
}
