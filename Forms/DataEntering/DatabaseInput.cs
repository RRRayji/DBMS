using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class DatabaseInput : Form
    {
        public DatabaseInput()
        {
            InitializeComponent();
            InitColors();
            startSize[0] = this.Width;
            startSize[1] = this.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool _isCancelled = true;
        public delegate void ValueReturnedEentHandler(string databaseName, bool _isCancelled);
        public event ValueReturnedEentHandler ValueReturnedEvent;
        private int[] startSize = new int[2];


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            textBox_DatabaseName.ForeColor = Colors.lightGrey;
            textBox_DatabaseName.BackColor = Colors.blue;
        }

            private void SetStartSize()
        {
            this.Width = startSize[0];
            this.Height = startSize[1];
        }

        private void textBox_DatabaseName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_DatabaseName.Text.Length < 2) return;
                _isCancelled = false;
                this.Close();
            }
            else if ((e.KeyCode == Keys.Escape) || (e.KeyCode == Keys.W && e.Shift && e.Control))
            {
                this.Close();
            }
        }

        private void DatabaseInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            ValueReturnedEvent.Invoke(textBox_DatabaseName.Text, _isCancelled);
        }

        private void DatabaseInput_Resize(object sender, System.EventArgs e)
        {
            SetStartSize();
        }

        private void textBox_DatabaseName_Enter(object sender, System.EventArgs e)
        {
            textBox_DatabaseName.ForeColor = Colors.lightBlue;
        }

        private void textBox_DatabaseName_Leave(object sender, System.EventArgs e)
        {
            textBox_DatabaseName.ForeColor = Colors.lightGrey;
        }
    }
}
