using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class AddRow : Form
    {
        public AddRow(string currentTable)
        {
            InitializeComponent();
            InitColors();
            startSize[0] = this.Width;
            startSize[1] = this.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
            this._currentTable = currentTable;

            Connection.SetQuery($"SELECT COUNT(COLUMN_NAME) FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME='{this._currentTable}' AND CONSTRAINT_NAME LIKE 'PK%';");
            ushort idpk = ushort.Parse(Connection.GetSqlCommand().ExecuteScalar().ToString());
            
            if (idpk > 0)
            {
                Connection.SetQuery($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME='{this._currentTable}' AND CONSTRAINT_NAME LIKE 'PK%';");
                _columnExtra = Connection.GetSqlCommand().ExecuteScalar().ToString();
            }

            this._query = $"insert into {this._currentTable}(";

            Connection.SetQuery($"select count(*) from information_schema.columns where table_name = '{this._currentTable}';");
            if (idpk > 0) _columns = new string[int.Parse(Connection.GetSqlCommand().ExecuteScalar().ToString()) - 1];
            else _columns = new string[(int)Connection.GetSqlCommand().ExecuteScalar()];

            _currentStep = 0;
            Connection.SetQuery($"select column_name from information_schema.columns where table_name = '{this._currentTable}';");
            System.Data.SqlClient.SqlDataReader reader = Connection.GetSqlCommand().ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == _columnExtra) continue;
                _columns[_currentStep] = reader[0].ToString();
                if (_query[_query.Length - 1] != '(') _query += ", ";
                _query += $"{_columns[_currentStep]}";
                ++_currentStep;
            }
            reader.Close();
            this._query += ") values(";

            _currentStep = 0;
            short length = (short)(this.Width / 12);
            string newTitle = (_columns[_currentStep].Length > length) ? (_columns[_currentStep].Substring(0, length) + "...") : _columns[_currentStep];
            this.Text = $"ENTER DATA: {newTitle}";
            this.textBox_Data.Focus();
            if (_columnExtra == _columns[_currentStep]) IDisPK();
        }
        private string _query = "", _currentTable;
        private string[] _columns;
        private byte _currentStep;
        private string _columnExtra = null;

        private bool _isCancelled = true;
        public delegate void ValueReturnedEventHandler(string databaseName, bool _isCancelled);
        public event ValueReturnedEventHandler ValueReturnedEvent;
        private int[] startSize = new int[2];


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            textBox_Data.ForeColor = Colors.lightGrey;
            textBox_Data.BackColor = Colors.blue;
        }



        private void EnterNextData()
        {
            if (_query[_query.Length - 1] != '(') _query += ", ";
            Connection.SetQuery($"select data_type from information_schema.columns where table_name = '{this._currentTable}' and column_name = '{_columns[_currentStep]}'");
            string columnDataType = Connection.GetSqlCommand().ExecuteScalar().ToString().ToUpper();
            bool isString = (columnDataType.Contains("CHAR") || columnDataType.Contains("VARCHAR"));
            _query += (isString) ? $"'{textBox_Data.Text}'" : $"{textBox_Data.Text}";
            textBox_Data.Text = "";
            Update();
        }

        private void IDisPK()
        {
            _query = _query.Replace(_columns[_currentStep], "");
            _query = _query.Replace("(, ", "(");
            Update();
        }

        private new void Update()
        {
            if (++_currentStep == _columns.Length)
            {
                Exit();
                return;
            }
            short length = (short)(this.Width / 12);
            string newTitle = (_columns[_currentStep].Length > length) ? (_columns[_currentStep].Substring(0, length) + "...") : _columns[_currentStep];
            this.Text = $"ENTER DATA: {newTitle}";
            textBox_Data.Text = "";
            textBox_Data.Focus();
            if (_columnExtra == _columns[_currentStep]) IDisPK();
        }

        private void AddRow_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox_Data.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                EnterNextData();
            }
            else if ((e.KeyCode == Keys.Escape) || (e.KeyCode == Keys.W && e.Shift && e.Control))
            {
                this._query = null;
                this.Close();
            }
        }

        private void AddRow_FormClosed(object sender, FormClosedEventArgs e)
        {
            ValueReturnedEvent.Invoke(_query, _isCancelled);
        }

        private void textBox_Data_Enter(object sender, System.EventArgs e)
        {
            textBox_Data.ForeColor = Colors.lightBlue;
        }

        private void textBox_Data_Leave(object sender, System.EventArgs e)
        {
            textBox_Data.ForeColor = Colors.lightGrey;
        }

        private void Exit()
        {
            _query += ");";
            _isCancelled = false;
            //MessageBox.Show(_query);
            this.Close();
        }
    }
}
