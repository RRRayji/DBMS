using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PC_SHOP
{
    public partial class ForeignKey : Form
    {
        public ForeignKey(string[] tableNames, string[] _variableTitles, string primaryVariableName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this._tableNames = tableNames;
            this._primaryVariableName = primaryVariableName;
            foreach (var variable in _variableTitles)
            {
                comboBox_Column.Items.Add(variable);
            }
            foreach (var tableName in _tableNames)
            {
                comboBox_FromTable.Items.Add(tableName);
            }
            comboBox_Column.SelectedIndex = 0;
            comboBox_FromTable.SelectedIndex = 0;
            comboBox_Column.Focus();
            InitColors();
        }
        public delegate void ValueReturnedEventHandler(string query, bool isPFK);
        public event ValueReturnedEventHandler ValueReturnedEvent;
        private string[] _tableNames;
        private string _primaryVariableName;
        private bool _isCancelled = true;
        private bool _isPFK = false;


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            comboBox_Column.BackColor = Colors.blue;
            comboBox_Column.ForeColor = Colors.lightBlue;
            comboBox_FromTable.BackColor = Colors.blue;
            comboBox_FromTable.ForeColor = Colors.lightBlue;
            comboBox_FromVariable.BackColor = Colors.blue;
            comboBox_FromVariable.ForeColor = Colors.lightBlue;
        }

        private void ForeignKey_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode == Keys.W && e.Shift && e.Control)
            {
                case true:
                    this.Close();
                    return;
                case false: break;
            }
            switch (e.KeyCode == Keys.S && e.Control)
            {
                case true:
                    _isCancelled = false;
                    this.Close();
                    return;
                case false: return;
            }
        }

        private void comboBox_FromTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.SetQuery($"select column_name from information_schema.columns where table_name = '{comboBox_FromTable.Text}';");
            System.Data.SqlClient.SqlDataReader reader = Connection.GetSqlCommand().ExecuteReader();
            while (reader.Read())
            {
                comboBox_FromVariable.Items.Add(reader[0].ToString());
            }
            comboBox_FromVariable.SelectedIndex = 0;
            reader.Close();
        }

        private void comboBox_Column_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) { case Keys.Enter: comboBox_FromTable.Focus(); return; }
        }

        private void comboBox_FromTable_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) { case Keys.Enter: comboBox_FromVariable.Focus(); return; }
        }

        private void comboBox_FromVariable_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) { case Keys.Enter: checkBox_Cascade.Focus(); return; }
        }

        private void radioButton_Cascade_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) { case Keys.Enter: this.Close(); return; }
        }

        private void ForeignKey_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (this._isCancelled)
            {
                case true:
                    ValueReturnedEvent.Invoke(null, false);
                    return;
                case false:
                    string query = $"\nALTER TABLE TableName ADD CONSTRAINT FK_TableName_{comboBox_FromTable.Text} FOREIGN KEY ({comboBox_Column.Text}) REFERENCES {comboBox_FromTable.Text}({comboBox_FromVariable.Text})";
                    switch (checkBox_Cascade.Checked)
                    {
                        case true:
                            query += " ON DELETE CASCADE";
                            break;
                        case false: break;
                    }
                    _isPFK = (comboBox_Column.Text == _primaryVariableName) ? true : false;
                    ValueReturnedEvent.Invoke($"{query};", _isPFK);
                    return;
            }
        }
    }
}
