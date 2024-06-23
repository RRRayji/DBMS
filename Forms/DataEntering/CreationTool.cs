using System;
using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class CreationTool : Form
    {
        public CreationTool()
        {
            InitializeComponent();
            InitColors();
            startSize[0] = this.Width;
            startSize[1] = this.Height;
            Connection.SetConnectionSettings("", "");
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox_Type.Focus();
            comboBox_Type.SelectedIndex = 0;
        }

        private Tables _tables;
        private TableInput _tableInput;
        private System.Collections.Generic.List<string> _databaseNames = new System.Collections.Generic.List<string>();
        private int[] startSize = new int[2];


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            button_Create.ForeColor = Colors.lightGrey;
            button_Create.BackColor = Colors.blue;
            button_Create.FlatAppearance.BorderColor = Colors.lightGrey;
            button_Create.FlatAppearance.BorderSize = 1;
            button_Update.ForeColor = Colors.lightGrey;
            button_Update.BackColor = Colors.blue;
            button_Update.FlatAppearance.BorderColor = Colors.lightGrey;
            button_Update.FlatAppearance.BorderSize = 1;
            button_Delete.ForeColor = Colors.lightGrey;
            button_Delete.BackColor = Colors.blue;
            button_Delete.FlatAppearance.BorderColor = Colors.lightGrey;
            button_Delete.FlatAppearance.BorderSize = 1;
            comboBox_Type.ForeColor = Colors.lightGrey;
            comboBox_Type.BackColor = Colors.blue;
            comboBox_UsingDatabase.ForeColor = Colors.lightGrey;
            comboBox_UsingDatabase.BackColor = Colors.blue;
            label_UsingDatabase.ForeColor = Colors.lightGrey;
            label_UsingDatabase.BackColor = Colors.darkBlue;
        }

        private void SetFocus()
        {
            switch (comboBox_UsingDatabase.Visible)
            {
                case true:
                    comboBox_UsingDatabase.Focus();
                    return;
                case false:
                    comboBox_Type.Focus();
                    return;
            }
        }

        private void SetStartSize()
        {
            this.Width = startSize[0];
            this.Height = startSize[1];
        }


        private void TablesFormClosedEvent()
        {
            this.Show();
            Connection.SetConnectionSettings("", "");
            Connection.Reconnect();
            SetFocus();
        }

        private void TableInputForm_ValueReturnedEvent(string query)
        {
            this.Show();
            switch (query)
            {
                case null:
                    return;
            }
            Connection.SetQuery(query);
            try
            {
                Connection.ExecuteQuery();
                MessageBox.Show("The table has been successfully created.");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to create table.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetFocus();
        }

        private void Form_DatabaseInput_ValueReturnedEvent(string databaseName, bool isCancelled)
        {
            this.Show();
            if (!isCancelled)
            {
                try
                {
                    if (databaseName == "PC_SHOP") Connection.SetConnectionSettings("", "");
                    Connection.Reconnect();
                    Connection.SetQuery(Connection.GetQueryForDatabaseCreate(Connection.environmentPath, databaseName));
                    Connection.ExecuteQuery();
                    MessageBox.Show("The database has been successfully created.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SetFocus();
        }

        private void Create()
        {
            this.Hide();
            if (comboBox_Type.Text == "Table")
            {
                Connection.environmentDatabaseName = comboBox_UsingDatabase.Text;
                Connection.SetConnectionSettings("", Connection.environmentDatabaseName);
                Connection.Reconnect();

                Connection.SetQuery($"select count(TABLE_NAME) from INFORMATION_SCHEMA.TABLES where TABLE_CATALOG = '{Connection.environmentDatabaseName}';");
                string[] titles = new string[(int)Connection.GetSqlCommand().ExecuteScalar()];
                Connection.SetQuery($"select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_CATALOG = '{Connection.environmentDatabaseName}';");
                System.Data.SqlClient.SqlDataReader reader = Connection.GetSqlCommand().ExecuteReader();
                ushort i = 0; 
                while (reader.Read())
                {
                    titles[i++] = reader[0].ToString();
                }
                reader.Close();
                _tableInput = new TableInput(ref titles);
                _tableInput.ValueReturnedEvent += TableInputForm_ValueReturnedEvent;
                _tableInput.Show();
            }
            else    //  for database
            {
                DatabaseInput db = new DatabaseInput();
                db.ValueReturnedEvent += Form_DatabaseInput_ValueReturnedEvent;
                db.Show();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void comboBox_UsingDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && e.Control)
            {
                comboBox_Type.Focus();
            }
        }

        private void Form_CreationTool_FormClosed(object sender, FormClosedEventArgs e)
        {
            Connection.Close();
            Application.Exit();
        }

        private void comboBox_Type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Type.Text == "Table")
            {
                Connection.Reconnect();
                Connection.SetQuery("select name from sys.databases");
                System.Data.SqlClient.SqlDataReader reader = Connection.GetSqlCommand().ExecuteReader();
                comboBox_UsingDatabase.Items.Clear();
                byte i = 0;
                while (reader.Read())
                {
                    _databaseNames.Add(reader[0].ToString());
                    comboBox_UsingDatabase.Items.Add(_databaseNames[i++]);
                }
                reader.Close();
                button_Update.Enabled = true;
                comboBox_UsingDatabase.SelectedIndex = 0;
                comboBox_UsingDatabase.Visible = true;
                label_UsingDatabase.Visible = true;
                comboBox_UsingDatabase.Focus();
            }
            else    //  for database
            {
                label_UsingDatabase.Visible = false;
                button_Update.Enabled = false;
                comboBox_UsingDatabase.SelectedIndex = 0;
                comboBox_UsingDatabase.Visible = false;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Connection.environmentDatabaseName = comboBox_UsingDatabase.Text;
            _tables = new Tables();
            _tables.TablesFormClosedEvent += TablesFormClosedEvent;
            Connection.Close();
            this.Hide();
            _tables.Show();
        }

        private void Form_DatabaseSelect_ValueReturnedEvent(string databaseName, bool isCancelled)
        {
            this.Show();
            if (!isCancelled)
            {
                try
                {
                    Connection.SetConnectionSettings("", "");
                    Connection.Reconnect();
                    Connection.SetQuery(Connection.GetQueryForDropDatabase(databaseName));
                    Connection.ExecuteQuery();
                    MessageBox.Show("The database has been successfully deleted.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SetFocus();
        }

        private void TableSelect_ValueReturnedEvent(string tableName, bool isCancelled)
        {
            this.Show();
            if (!isCancelled)
            {
                Connection.SetQuery($"Drop table {tableName};");
                if (Connection.ExecuteQuery() > 0)
                {
                    MessageBox.Show("The table has been successfully deleted.");
                }
            }
            SetFocus();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (comboBox_Type.Text == "Table")
            {
                Connection.environmentDatabaseName = comboBox_UsingDatabase.Text;
                Connection.SetConnectionSettings("", Connection.environmentDatabaseName);
                Connection.Reconnect();
                Connection.SetQuery($"select count(*) from information_schema.tables where table_catalog = '{Connection.environmentDatabaseName}';");
                if ((int)Connection.GetSqlCommand().ExecuteScalar() < 1)
                {
                    MessageBox.Show("No table found.");
                    this.Show();
                    SetFocus();
                    return;
                }
                Connection.SetConnectionSettings("", Connection.environmentDatabaseName);
                TableSelect ts = new TableSelect();
                ts.ValueReturnedEvent += TableSelect_ValueReturnedEvent;
                ts.Show();
            }
            else    //  for database
            {
                Connection.Reconnect();
                Connection.SetQuery($"select COUNT(*) from sys.databases");
                if ((int)Connection.GetSqlCommand().ExecuteScalar() < 1)
                {
                    MessageBox.Show("No database found.");
                    this.Show();
                    SetFocus();
                    return;
                }
                DatabaseSelect db = new DatabaseSelect();
                db.ValueReturnedEvent += Form_DatabaseSelect_ValueReturnedEvent;
                db.Show();
            }
        }

        private void CreationTool_Resize(object sender, EventArgs e)
        {
            SetStartSize();
        }

        private void CreationTool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)       //  1
            {
                Create();
            }
            else if (e.KeyCode == Keys.D2)  //  2
            {
                button_Update_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D3)  //  3
            {
                button_Delete_Click(sender, e);
            }
            else if (e.KeyCode == Keys.W && e.Shift && e.Control)
            {
                this.Close();
            }
        }

        private void button_Create_Enter(object sender, EventArgs e)
        {
            button_Create.ForeColor = Colors.lightBlue;
        }

        private void button_Create_Leave(object sender, EventArgs e)
        {
            button_Create.ForeColor = Colors.lightGrey;
        }

        private void button_Update_Enter(object sender, EventArgs e)
        {
            button_Update.ForeColor = Colors.lightBlue;
        }

        private void button_Update_Leave(object sender, EventArgs e)
        {
            button_Update.ForeColor = Colors.lightGrey;
        }

        private void button_Delete_Enter(object sender, EventArgs e)
        {
            button_Delete.ForeColor = Colors.lightBlue;
        }

        private void button_Delete_Leave(object sender, EventArgs e)
        {
            button_Delete.ForeColor = Colors.lightGrey;
        }
    }
}
