using System;
using System.Windows.Forms;

namespace PC_SHOP
{
    public partial class Signup : Form
    {
        public Signup(Login login)
        {
            InitializeComponent();
            InitColors();
            this.Owner = login;
            startSize[0] = this.Width;
            startSize[1] = this.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
            Connection.Open("", "");
            _nameHelpText = textBoxName.Text;
            _passwordHelpText = maskedTextPassword.Text;
            _passwordRepeatHelpText = maskedTextPasswordRepeat.Text;
        }
        private string _name = "", _password = "", _passwordRepeat = "", _nameHelpText, _passwordHelpText, _passwordRepeatHelpText;
        private int[] startSize = new int[2];


        private void InitColors()
        {
            this.ForeColor = Colors.lightGrey;
            this.BackColor = Colors.darkBlue;
            textBoxName.ForeColor = Colors.lightGrey;
            textBoxName.BackColor = Colors.blue;
            maskedTextPassword.ForeColor = Colors.lightGrey;
            maskedTextPassword.BackColor = Colors.blue;
            maskedTextPasswordRepeat.ForeColor = Colors.lightGrey;
            maskedTextPasswordRepeat.BackColor = Colors.blue;
            labelBack.ForeColor = Colors.lightGrey;
            labelBack.BackColor = Colors.darkBlue;
            btnRegister.ForeColor = Colors.lightGrey;
            btnRegister.BackColor = Colors.blue;
            btnRegister.FlatAppearance.BorderColor = Colors.lightGrey;
            btnRegister.FlatAppearance.BorderSize = 1;
        }

        private void SetStartSize()
        {
            this.Width = startSize[0];
            this.Height = startSize[1];
        }

        private static byte CreateDatabaseAndAccountTable(byte i)
        {
            Connection.SetConnectionSettings("", "");
            Connection.Reconnect();
            try
            {
                Connection.SetQuery(Connection.GetQueryForDatabaseCreate(Connection.environmentPath, Connection.environmentDatabaseName));
                Connection.ExecuteQuery();
            }
            catch (Exception)
            {
                MessageBox.Show($"Try to change program directory.\nIt may already been decided.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.SetQuery(Connection.GetQueryForDropDatabase(Connection.environmentDatabaseName));
                try
                {
                    Connection.ExecuteQuery();
                    return ++i;
                }
                catch (Exception)
                {
                    MessageBox.Show("Try again.");
                    return ++i;
                }
            }
            Connection.SetQuery($"use {Connection.environmentDatabaseName};" +
                $"create table Account( " +
                    $"A_id int identity(1,1) primary key not null, " +
                    $"A_nick varchar(32) not null, " +
                    $"A_pass varchar(32) not null " +
                $");");
            Connection.ExecuteQuery();
            return 2;
        }

        private void Creating()
        {
            Connection.SetConnectionSettings("", Connection.environmentDatabaseName);
            Connection.Reconnect();
            if (Connection.SelectDataFromTable($"select A_nick from Account where A_nick = '{Encryption.ChangeAndGetHash(_name)}'").Rows.Count == 0)
            {
                Connection.SetQuery($"insert into Account(A_nick, A_pass) values('{Encryption.ChangeAndGetHash(_name)}', '{Encryption.ChangeAndGetHash(_password)}')");
                if (Connection.ExecuteQuery() > 0)
                {
                    this.Hide();        //  and back to login
                    this.Owner.Show();
                    return;
                }
                else
                    MessageBox.Show("Account creation error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("An account with such name has already been registrated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EndForm()
        {
            if (_password == _passwordRepeat && _name != "" && _password != "" && _name.Length > 7 && _password.Length > 7)
            {
                try
                {
                    Creating();
                }
                catch
                {
                    MessageBox.Show("Your system does not have the required database.\nDatabase \"PC_SHOP\" creation...");
                    Connection.Close();
                    byte i = 0;
                    for (; i < 2; i = Signup.CreateDatabaseAndAccountTable(i))
                    {
                    }
                    try
                    {
                        Creating();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to create database neeeded for this program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (_name == "") textBoxName.Focus();
            else if (_password == "") maskedTextPassword.Focus();
            else if (_passwordRepeat == "") maskedTextPasswordRepeat.Focus();
            else if (_password != _passwordRepeat)
            {
                _passwordRepeat = maskedTextPasswordRepeat.Text = "";
                maskedTextPasswordRepeat.Focus();
            }
            else if (_name.Length < 8 && _password.Length < 8)
            {
                MessageBox.Show("The length of the name and/or password must be more than 8 chars.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (_name.Length < 8) textBoxName.Focus();
                else if (_password.Length < 8) maskedTextPassword.Focus();
            }
        }
        //----------------------------------------------------------------------
        //								 GENERATED
        //----------------------------------------------------------------------
        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (_name == "")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = System.Drawing.Color.FromArgb(198, 206, 247);
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
                textBoxName.ForeColor = System.Drawing.Color.FromArgb(189, 189, 222);
            }
        }

        private void maskedTextPassword_Enter(object sender, EventArgs e)
        {
            if (_password == "")
            {
                maskedTextPassword.Text = "";
                maskedTextPassword.UseSystemPasswordChar = true;
                maskedTextPassword.ForeColor = System.Drawing.Color.FromArgb(198, 206, 247);
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
                maskedTextPassword.ForeColor = System.Drawing.Color.FromArgb(189, 189, 222);
            }
        }

        private void maskedTextPasswordRepeat_Enter(object sender, EventArgs e)
        {
            if (_passwordRepeat == "")
            {
                maskedTextPasswordRepeat.Text = "";
                maskedTextPasswordRepeat.UseSystemPasswordChar = true;
                maskedTextPasswordRepeat.ForeColor = System.Drawing.Color.FromArgb(198, 206, 247);
            }
        }

        private void maskedTextPasswordRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                _passwordRepeat = maskedTextPasswordRepeat.Text;
                EndForm();
            }
        }

        private void maskedTextPasswordRepeat_Leave(object sender, EventArgs e)
        {
            _passwordRepeat = maskedTextPasswordRepeat.Text;
            if (_passwordRepeat == "")
            {
                maskedTextPasswordRepeat.Text = _passwordRepeatHelpText;
                maskedTextPasswordRepeat.UseSystemPasswordChar = false;
                maskedTextPasswordRepeat.ForeColor = System.Drawing.Color.FromArgb(189, 189, 222);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            EndForm();
        }

        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Signup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && e.Control)
            {
                this.Hide();
                this.Owner.Show();
            }
            else if (e.KeyCode == Keys.W && e.Shift && e.Control)
            {
                this.Close();
            }
        }

        private void Signup_Resize(object sender, EventArgs e)
        {
            SetStartSize();
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.ForeColor = System.Drawing.Color.FromArgb(198, 206, 247);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.ForeColor = System.Drawing.Color.FromArgb(189, 189, 222);
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            _name = _nameHelpText = _password = _passwordHelpText = "";
            this.Hide();
            this.Owner.Show();
        }

        private void labelBack_MouseEnter(object sender, EventArgs e)
        {
            labelBack.ForeColor = System.Drawing.Color.FromArgb(198, 206, 247);
            labelBack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
        }

        private void labelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.ForeColor = System.Drawing.Color.FromArgb(189, 189, 222);
            labelBack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 204);
        }
    }
}
