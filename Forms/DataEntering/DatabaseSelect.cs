using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class DatabaseSelect : Form
    {
        public DatabaseSelect()
        {
            InitializeComponent();
            InitColors();
            startSize[0] = this.Width;
            startSize[1] = this.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
            Connection.Reconnect();
            Connection.SetQuery("select name from sys.databases");
            System.Data.SqlClient.SqlDataReader reader = Connection.GetSqlCommand().ExecuteReader();
            while (reader.Read())
            {
                comboBox_DatabaseName.Items.Add(reader[0].ToString());
            }
            reader.Close();
            comboBox_DatabaseName.SelectedIndex = 0;
        }

        private bool _isCancelled = true;
        public delegate void ValueReturnedEventHandler (string databaseName, bool _isCancelled);
        public event ValueReturnedEventHandler ValueReturnedEvent;
        private int[] startSize = new int[2];


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            comboBox_DatabaseName.ForeColor = Colors.lightGrey;
            comboBox_DatabaseName.BackColor = Colors.blue;
        }

        private void SetStartSize()
        {
            this.Width = startSize[0];
            this.Height = startSize[1];
        }

        private void Form_DatabaseInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            ValueReturnedEvent.Invoke(comboBox_DatabaseName.Text, _isCancelled);
        }

        private void comboBox_DatabaseName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult result = MessageBox.Show("Are you sure want to delete this database?", "Confirm the action", MessageBoxButtons.OKCancel);
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

        private void DatabaseSelect_Resize(object sender, System.EventArgs e)
        {
            SetStartSize();
        }
    }
}
