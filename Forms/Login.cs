using System;
using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitColors();
            startSize[0] = this.Width;
            startSize[1] = this.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
            _nameHelpText = textBoxName.Text;
            _passwordHelpText = maskedTextPassword.Text;
            Connection.SetEnvironmentData(Environment.CurrentDirectory, "PC_SHOP");
            Connection.Open("", "");
            _signupForm = new Signup(this);
            _CreationToolFrom = new CreationTool();
            CustomFont.Init();
        }

        private Signup _signupForm;
        private CreationTool _CreationToolFrom;
        private string _name = "", _password = "", _nameHelpText, _passwordHelpText;
        private int[] startSize = new int[2];


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            textBoxName.ForeColor = Colors.lightGrey;
            textBoxName.BackColor = Colors.blue;
            maskedTextPassword.ForeColor = Colors.lightGrey;
            maskedTextPassword.BackColor = Colors.blue;
            labelNotRegistered.ForeColor = Colors.lightGrey;
            labelNotRegistered.BackColor = Colors.darkBlue;
            btnLogin.ForeColor = Colors.lightGrey;
            btnLogin.BackColor = Colors.blue;
            btnLogin.FlatAppearance.BorderColor = Colors.lightGrey;
            btnLogin.FlatAppearance.BorderSize = 1;
        }

        private void SetStartSize()
        {
            this.Width = startSize[0];
            this.Height = startSize[1];
        }

        private void EndForm()
        {
            if (_name != "" && _password != "" && _name != _nameHelpText)
            {
                try
                {
                    Connection.SetConnectionSettings("", Connection.environmentDatabaseName);
                    Connection.Reconnect();
                    int accCount = Connection.SelectDataFromTable($"select A_nick, A_pass from Account where A_nick = '{Encryption.ChangeAndGetHash(_name)}' and A_pass = '{Encryption.ChangeAndGetHash(_password)}'").Rows.Count;
                    if (accCount == 1)
                    {
                        this.Hide();    // and show main form
                        Connection.Close();
                        _CreationToolFrom.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("An account with such data does not exist.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Data does not exist. Sign up required.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (_name == "") textBoxName.Focus();
            else if (_password == "") maskedTextPassword.Focus();
        }
        //----------------------------------------------------------------------
        //								 GENERATED
        //----------------------------------------------------------------------
        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (_name == "")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Colors.lightBlue;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBoxName.Text == _nameHelpText) return;
                maskedTextPassword.Focus();
                if (_password == "") maskedTextPassword.Text = "";
                else EndForm();
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            _name = textBoxName.Text;
            if (_name == "")
            {
                textBoxName.Text = "Name";
                textBoxName.ForeColor = Colors.lightGrey;
            }
        }

        private void maskedTextPassword_Enter(object sender, EventArgs e)
        {
            if (_password == "")
            {
                maskedTextPassword.Text = "";
                maskedTextPassword.UseSystemPasswordChar = true;
                maskedTextPassword.ForeColor = Colors.lightBlue;
            }
        }

        private void maskedTextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                _password = maskedTextPassword.Text;
                EndForm();
            }
        }

        private void maskedTextPassword_Leave(object sender, EventArgs e)
        {
            _password = maskedTextPassword.Text;
            if (_password == "")
            {
                maskedTextPassword.Text = _passwordHelpText;
                maskedTextPassword.UseSystemPasswordChar = false;
                maskedTextPassword.ForeColor = Colors.lightGrey;
            }
        }

        private void labelNotRegistered_MouseEnter(object sender, EventArgs e)
        {
            labelNotRegistered.ForeColor = Colors.lightBlue;
            this.labelNotRegistered.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);

        }

        private void labelNotRegistered_MouseLeave(object sender, EventArgs e)
        {
            labelNotRegistered.ForeColor = Colors.lightGrey;
            labelNotRegistered.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 204);
        }

        private void labelNotRegistered_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            _signupForm.Show();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && e.Control)
            {
                this.Hide();
                _signupForm.Show();
            }
            else if (e.KeyCode == Keys.W && e.Shift && e.Control)
            {
                this.Close();
            }
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            SetStartSize();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EndForm();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Colors.lightBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Colors.lightGrey;
        }

    };
    abstract class CustomFont
    {
        private static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
        public static System.Drawing.Font JetBrainsMono(float size)
        {
            return new System.Drawing.Font(pfc.Families[0], (size > 30 || size < 7) ? size : (float)8.25);
        }
        public static void Init()
        {
            try
            {
                pfc.AddFontFile(Environment.CurrentDirectory + @"\JetBrainsMono-SemiBold.ttf");
            }
            catch
            {
                MessageBox.Show($"Font not found.\nIt must be contained in the root folder of the project.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Set_JetBrainsMono()
        {
            try
            {
                pfc.AddFontFile(Environment.CurrentDirectory + @"\JetBrainsMono-SemiBold.ttf");
            }
            catch
            {
                MessageBox.Show($"Font not found.\nIt must be contained in the root folder of the project.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Control c in Login.ActiveForm.Controls)
            {
                c.Font = new System.Drawing.Font(pfc.Families[0], c.Font.Size);
            }
        }
        public static void SetToControl_JetBrainsMono(Control control)
        {
            control.Font = new System.Drawing.Font(pfc.Families[0], control.Font.Size);
        }
    };
}
