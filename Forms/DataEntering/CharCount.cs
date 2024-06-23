using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class CharCount : Form
    {
        public CharCount()
        {
            InitializeComponent();
            InitColors();
            startSize[0] = this.Width;
            startSize[1] = this.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public delegate void ValueReturnedEventHandler (string e);
        public event ValueReturnedEventHandler ValueReturnedEvent;
        private int[] startSize = new int[2];


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            count.ForeColor = Colors.lightGrey;
            count.BackColor = Colors.blue;
        }

        private void SetStartSize()
        {
            this.Width = startSize[0];
            this.Height = startSize[1];
        }

        private void Form_CharCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Close();
            }
        }

        private void Form_CharCount_FormClosed(object sender, FormClosedEventArgs e)
        {
            ValueReturnedEvent.Invoke(count.Text);
        }

        private void CharCount_Resize(object sender, System.EventArgs e)
        {
            SetStartSize();
        }

        private void count_Enter(object sender, System.EventArgs e)
        {
            count.ForeColor = Colors.lightBlue;
        }

        private void count_Leave(object sender, System.EventArgs e)
        {
            count.BackColor = Colors.lightGrey;
        }
    }
}
