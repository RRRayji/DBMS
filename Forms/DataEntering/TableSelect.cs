using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class TableSelect : Form
    {
        public TableSelect()
        {
            InitializeComponent();
            InitColors();
            startSize[0] = this.Width;
            startSize[1] = this.Height;
            this.Text += Connection.environmentDatabaseName;
            this.StartPosition = FormStartPosition.CenterScreen;
            Connection.Reconnect();
            Connection.SetQuery($"select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_CATALOG = '{Connection.environmentDatabaseName}';");
            System.Data.SqlClient.SqlDataReader reader = Connection.GetSqlCommand().ExecuteReader();
            while(reader.Read())
            {
                comboBox_TableName.Items.Add(reader[0].ToString());
            }
            reader.Close();
            comboBox_TableName.SelectedIndex = 0;
        }

        private bool _isCancelled = true;
        public delegate void ValueReturnedEventHandler(string tableName, bool _isCancelled);
        public event ValueReturnedEventHandler ValueReturnedEvent;
        private int[] startSize = new int[2];


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            comboBox_TableName.ForeColor = Colors.lightGrey;
            comboBox_TableName.BackColor = Colors.blue;
        }

        private void SetStartSize()
        {
            this.Width = startSize[0];
            this.Height = startSize[1];
        }

        private void comboBox_TableName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult result = MessageBox.Show("Are you sure want to delete this table?", "Confirm the action", MessageBoxButtons.OKCancel);
                switch (result.ToString() == "OK")
                {
                    case true:
                        _isCancelled = false;
                        this.Close();
                        return;
                    case false: return;
                }
            }
            else if ((e.KeyCode == Keys.Escape) || (e.KeyCode == Keys.W && e.Shift && e.Control))
            {
                this.Close();
            }
        }

        private void Form_TableSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            ValueReturnedEvent.Invoke(comboBox_TableName.Text, _isCancelled);
        }

        private void TableSelect_Resize(object sender, System.EventArgs e)
        {
            SetStartSize();
        }
    }
}
