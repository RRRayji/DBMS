using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class FindByKey : Form
    {
        public FindByKey()
        {
            InitializeComponent();
            InitColors();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private string _pattern = null;
        private bool _isCancelled = true;
        public delegate void ValueReturnedEventHandler(string pattern, bool isCancelled);
        public event ValueReturnedEventHandler ValueReturnedEvent;


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            textBox_KeyValue.ForeColor = Colors.lightGrey;
            textBox_KeyValue.BackColor = Colors.blue;
            checkBox_Pre.ForeColor = Colors.lightGrey;
            checkBox_Pre.BackColor = Colors.darkBlue;
            checkBox_Post.ForeColor = Colors.lightGrey;
            checkBox_Post.BackColor = Colors.darkBlue;
        }
        private void textBox_KeyValue_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.S && e.Control) || (e.KeyCode == Keys.Enter))
            {
                _pattern = Filter.CheckValid(textBox_KeyValue.Text);
                _pattern = (checkBox_Pre.Checked) ? "%" : null;
                _pattern += textBox_KeyValue.Text;
                _pattern += (checkBox_Post.Checked) ? "%" : null;
                switch (_pattern)
                {
                    case null:
                        return;
                    case "%":
                        return;
                    case "%%":
                        return;
                    default:
                        _isCancelled = false;
                        this.Close();
                        return;
                }
            }
        }

        private void FindByKey_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Escape) || (e.KeyCode == Keys.W && e.Shift && e.Control))
            {
                this.Close();
            }
        }

        private void textBox_KeyValue_Enter(object sender, System.EventArgs e)
        {
            textBox_KeyValue.ForeColor = Colors.lightBlue;
        }

        private void textBox_KeyValue_Leave(object sender, System.EventArgs e)
        {
            textBox_KeyValue.ForeColor = Colors.lightGrey;
        }

        private void FindByKey_FormClosed(object sender, FormClosedEventArgs e)
        {
            ValueReturnedEvent.Invoke(_pattern, _isCancelled);
        }
    }
}
