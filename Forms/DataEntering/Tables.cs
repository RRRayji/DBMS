using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
            InitColors();
            this.StartPosition = FormStartPosition.CenterScreen;

            toolStripStatusLabel_Connection.Text = Connection.environmentDatabaseName;
            Connection.SetConnectionSettings("", Connection.environmentDatabaseName);
            Connection.Reconnect();
            Connection.SetQuery($"select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_CATALOG = '{Connection.environmentDatabaseName}';");


            System.Data.SqlClient.SqlDataReader reader = Connection.GetSqlCommand().ExecuteReader();
            while (reader.Read())
            {
                switch (Connection.environmentDatabaseName == "PC_SHOP" && reader[0].ToString() == "Account") { case true: continue; }
                ToolStripDropDownButton newItem = new ToolStripDropDownButton(reader[0].ToString());
                newItem.DoubleClickEnabled = true;
                newItem.DoubleClick += DropDownButton_DoubleClick;
                newItem.DropDownOpened += DropDownOpened;
                newItem.ForeColor = Colors.darkBlue;
                ToolStripMenuItem itemOpen = new ToolStripMenuItem("Open");
                itemOpen.ForeColor = Colors.darkBlue;
                itemOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
                ToolStripMenuItem itemSave = new ToolStripMenuItem("Save");
                itemSave.ForeColor = Colors.darkBlue;
                itemSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
                ToolStripMenuItem itemClose = new ToolStripMenuItem("Close");
                itemClose.ForeColor = Colors.darkBlue;
                itemClose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
                newItem.DropDownItems.Add(itemOpen);
                newItem.DropDownItems.Add(itemSave);
                newItem.DropDownItems.Add(itemClose);
                toolStrip_Menu.Items.Add(newItem);
            }
            reader.Close();

            ResizeWindow();
        }
        public delegate void TablesFormClosedEventHandler();
        public event TablesFormClosedEventHandler TablesFormClosedEvent;
        private bool isDropDownMenuActive = false;

        private string _menuCheckedTable = "";
        private string _toUpdateItems = "";


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            toolStripStatusLabel_Connection.ForeColor = Colors.lightGrey;
            toolStripStatusLabel_Connection.BackColor = Colors.blue;
            statusStrip_Connection.ForeColor = Colors.lightBlue;
            statusStrip_Connection.BackColor = Colors.darkBlue;
            dataGridView.ForeColor = System.Drawing.Color.Black;
            dataGridView.BackColor = Colors.blue;
            toolStripDropDownButton_Menu.ForeColor = Colors.lightBlue;
            toolStripDropDownButton_Menu.BackColor = Colors.darkBlue;
            toolStrip_Menu.ForeColor = Colors.darkBlue;
            toolStrip_Menu.BackColor = Colors.lightBlue;
            addToolStripMenuItem.ForeColor = Colors.lightGrey;
            addToolStripMenuItem.BackColor = Colors.darkBlue;
            findToolStripMenuItem.ForeColor = Colors.lightGrey;
            findToolStripMenuItem.BackColor = Colors.darkBlue;
            deleteToolStripMenuItem.ForeColor = Colors.lightGrey;
            deleteToolStripMenuItem.BackColor = Colors.darkBlue;
            reconnectToolStripMenuItem.ForeColor = Colors.lightGrey;
            reconnectToolStripMenuItem.BackColor = Colors.darkBlue;
        }

        private new void Refresh()
        {
            dataGridView.DataSource = Connection.SelectDataFromTable($"select * from {_menuCheckedTable};");
            FindWidthOfCells();
        }

        private void DropDownButton_DoubleClick(object sender, EventArgs e)
        {
            Open();
        }

        private void DropDownOpened(object sender, EventArgs e)
        {
            for (ushort i = 0; i < toolStrip_Menu.Items.Count; ++i)
            {
                if (toolStrip_Menu.Items[i].Selected)
                {
                    _menuCheckedTable = toolStrip_Menu.Items[i].Text;
                    return;
                }
            }
        }

        private void FindWidthOfCells()
        {
            switch (dataGridView.ColumnCount)
            {
                case 0:
                    return;
                default:
                    ushort size = (ushort)((dataGridView.Width - dataGridView.RowHeadersWidth) / dataGridView.ColumnCount);
                    for (byte i = 0; i < dataGridView.ColumnCount; ++i)
                    {
                        dataGridView.Columns[i].Width = size;
                    }
                    return;
            }
        }

        private void FindDataGridViewSize()
        {
            byte locX = (byte)dataGridView.Location.X, locY = (byte)dataGridView.Location.Y;
            dataGridView.Width = (ushort)(this.Width - locX - 27);
            dataGridView.Height = (ushort)(this.Height - locY - 48);
        }

        private void FindDropDownMenuLeftMargin()
        {
            int left = statusStrip_Connection.Width - toolStripStatusLabel_Connection.Width - 37;
            toolStripDropDownButton_Menu.Margin = new Padding(left, 0, 0, 0);
        }

        private void ResizeWindow()
        {
            FindDataGridViewSize();
            FindDropDownMenuLeftMargin();
        }

        private void Open()
        {
            toolStripStatusLabel_Connection.Text = $"{Connection.environmentDatabaseName} :: {_menuCheckedTable}";
            toolStripStatusLabel_Connection.ForeColor = Colors.lightBlue;
            FindDropDownMenuLeftMargin();
            Connection.SetConnectionSettings("", Connection.environmentDatabaseName);
            Connection.Reconnect();
            string query = $"select * from {_menuCheckedTable};";
            dataGridView.DataSource = Connection.SelectDataFromTable(query);
            FindWidthOfCells();
            _toUpdateItems = "";

            for (ushort i = 0; i < toolStrip_Menu.Items.Count; ++i)
            {
                if (toolStrip_Menu.Items[i].Text == _menuCheckedTable) continue;
                toolStrip_Menu.Items[i].Enabled = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void SaveTable()
        {
            switch (_toUpdateItems)
            {
                case "": return;
            }
            switch (dataGridView.DataSource)
            {
                case null: return;
            }
            Connection.SetQuery(_toUpdateItems);
            Connection.ExecuteQuery();
            _toUpdateItems = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTable();
        }

        private void CloseTable()
        {
            toolStripStatusLabel_Connection.Text = Connection.environmentDatabaseName;
            toolStripStatusLabel_Connection.ForeColor = Colors.lightGrey;
            FindDropDownMenuLeftMargin();
            dataGridView.DataSource = null;
            _toUpdateItems = "";
            _menuCheckedTable = "";
            Connection.Close();

            for (ushort i = 0; i < toolStrip_Menu.Items.Count; ++i)
            {
                toolStrip_Menu.Items[i].Enabled = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseTable();
        }

        private void Tables_SizeChanged(object sender, EventArgs e)
        {
            ResizeWindow();
            FindWidthOfCells();
        }

        private void Tables_KeyDown(object sender, KeyEventArgs e)
        {
            if (_menuCheckedTable != "" && e.KeyCode == Keys.N && e.Control)
            {
                AddRow();
            }
            else if (_menuCheckedTable != "" && e.KeyCode == Keys.R && e.Control)
            {
                Reconnect();
            }
            else if (_menuCheckedTable != "" && e.KeyCode == Keys.F && e.Control)
            {
                FindByKeyValue();
            }
            else if (_menuCheckedTable != "" && e.KeyCode == Keys.S && e.Control)
            {
                SaveTable();
            }
            else if (_menuCheckedTable != "" && e.KeyCode == Keys.D && e.Control)
            {
                DeleteRow();
            }
            else if (e.KeyCode == Keys.W && e.Shift && e.Control)
            {
                switch (_menuCheckedTable == "")
                {
                    case true:
                        this.Close();
                        return;
                    case false:
                        CloseTable();
                        return;
                }
            }
            else if (_menuCheckedTable != "" && e.KeyCode == Keys.W && e.Control)
            {
                CloseTable();
            }
        }

        private void Tables_FormClosed(object sender, FormClosedEventArgs e)
        {
            Connection.Close();
            if (TablesFormClosedEvent != null) TablesFormClosedEvent.Invoke();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show($"update {_menuCheckedTable} set {dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].Name} = '{dataGridView.CurrentCell.Value}' where {dataGridView.Columns[0].Name} = {dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value}");
            _toUpdateItems += $"update {_menuCheckedTable} set {dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].Name} = '{dataGridView.CurrentCell.Value}' where {dataGridView.Columns[0].Name} = {dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value}";
        }

        private void toolStripDropDownButton_Menu_DropDownOpened(object sender, EventArgs e)
        {
            isDropDownMenuActive = true;
            toolStripDropDownButton_Menu.ForeColor = Colors.darkBlue;
            switch (_menuCheckedTable)
            {
                case "":
                    addToolStripMenuItem.Enabled = false;
                    reconnectToolStripMenuItem.Enabled = false;
                    findToolStripMenuItem.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    return;
                default:
                    addToolStripMenuItem.Enabled = true;
                    reconnectToolStripMenuItem.Enabled = true;
                    findToolStripMenuItem.Enabled = true;
                    deleteToolStripMenuItem.Enabled = true;
                    return;
            }
        }

        private void toolStripDropDownButton_Menu_DropDownClosed(object sender, EventArgs e)
        {
            isDropDownMenuActive = false;
            toolStripDropDownButton_Menu.ForeColor = Colors.lightGrey;
        }

        private void toolStripDropDownButton_Menu_MouseEnter(object sender, EventArgs e)
        {
            switch (isDropDownMenuActive)
            {
                case false:
                    toolStripDropDownButton_Menu.ForeColor = Colors.darkBlue;
                    return;
            }
        }

        private void toolStripDropDownButton_Menu_MouseLeave(object sender, EventArgs e)
        {
            switch (isDropDownMenuActive)
            {
                case false:
                    toolStripDropDownButton_Menu.ForeColor = Colors.lightGrey;
                    return;
            }
        }

        private void addToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            addToolStripMenuItem.ForeColor = Colors.darkBlue;
            addToolStripMenuItem.BackColor = Colors.lightGrey;
        }

        private void addToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            addToolStripMenuItem.ForeColor = Colors.lightGrey;
            addToolStripMenuItem.BackColor = Colors.darkBlue;
        }

        private void findToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            findToolStripMenuItem.ForeColor = Colors.darkBlue;
            findToolStripMenuItem.BackColor = Colors.lightGrey;
        }

        private void findToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            findToolStripMenuItem.ForeColor = Colors.lightGrey;
            findToolStripMenuItem.BackColor = Colors.darkBlue;
        }

        private void deleteToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            deleteToolStripMenuItem.ForeColor = Colors.darkBlue;
            deleteToolStripMenuItem.BackColor = Colors.lightGrey;
        }

        private void deleteToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            deleteToolStripMenuItem.ForeColor = Colors.lightGrey;
            deleteToolStripMenuItem.BackColor = Colors.darkBlue;
        }

        private void AddRow_ValueReturnedEvent(string queryString, bool isCancelled)
        {
            switch (isCancelled)
            {
                case true:
                    return;
            }

            Connection.SetQuery(queryString);
            try
            {
                Connection.ExecuteQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("Failed to add new row.\nYou may have entered the ID when it is auto-incremented", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Refresh();
            _toUpdateItems = "";
        }

        private void AddRow()
        {
            AddRow addRow = new AddRow(_menuCheckedTable);
            addRow.ValueReturnedEvent += AddRow_ValueReturnedEvent;
            addRow.Show();
            addRow.Focus();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private bool IsNumber(ref string pattern)
        {
            char[] numbers = "0123456789".ToCharArray();
            for (ushort i = 0; i < pattern.Length; ++i)
            {
                switch (numbers.Contains<char>(pattern[i]))
                {
                    case true:
                        continue;
                    case false:
                        return false;
                }
            }
            return true;
        }

        private void FindByKey_ValueReturnedEvent(string pattern, bool isCancelled)
        {
            switch (isCancelled)
            {
                case true: return;
                case false:
                    //pattern = (IsNumber(ref pattern)) ? pattern : $"'{pattern}'";
                    string queryString = $"select * from {this._menuCheckedTable} where {dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].Name} like '{pattern}'";
                    try
                    {
                        DataTable dt = Connection.SelectDataFromTable(queryString);
                        switch (dt.Rows.Count > 0)
                        {
                            case true:
                                dataGridView.DataSource = dt;
                                FindWidthOfCells();
                                return;
                            case false:
                                Refresh();
                                MessageBox.Show("Invalid key value.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to find rows by key value.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
            }
            
        }

        private void FindByKeyValue()
        {
            FindByKey fbk = new FindByKey();
            fbk.ValueReturnedEvent += FindByKey_ValueReturnedEvent;
            fbk.Show();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindByKeyValue();
        }

        private void DeleteRow()
        {
            DialogResult result = MessageBox.Show("Are you sure want to delete this row?", "Confirm the action", MessageBoxButtons.OKCancel);
            switch (result.ToString() == "OK")
            {
                case true:
                    string currentValue = (dataGridView.CurrentCell.ValueType == typeof(string)) ? $"'{dataGridView.CurrentCell.Value}'" : dataGridView.CurrentCell.Value.ToString();
                    string queryString = $"delete from {_menuCheckedTable} where {dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].Name} = {currentValue}";

                    Connection.SetQuery(queryString);
                    if (Connection.ExecuteQuery() < 1)
                        MessageBox.Show("Failed to remove selected row.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Refresh();
                    return;
                case false: return;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void Reconnect()
        {
            switch (_menuCheckedTable)
            {
                case "":
                    return;
                default:
                    Open();
                    return;
            }
        }

        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reconnect();
        }

        private void reconnectToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            reconnectToolStripMenuItem.ForeColor = Colors.darkBlue;
            reconnectToolStripMenuItem.BackColor = Colors.lightGrey;
        }

        private void reconnectToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            reconnectToolStripMenuItem.ForeColor = Colors.lightGrey;
            reconnectToolStripMenuItem.BackColor = Colors.darkBlue;
        }
    }
}