using System;
using System.Windows.Forms;

namespace Organizer
{
    public partial class FormA : Form
    {       
        public FormA()
        {
            InitializeComponent();
            PasswordText.PasswordChar = '*';
        }

        private void PasswordText_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Password must contain latin letter and\\or digits", PasswordText);
        }

        private void Show_MouseClick(object sender, MouseEventArgs e)
        {
            PasswordText.PasswordChar = Show.Checked ? '\0' : '*';
        }

        private void LoginText_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Login must contain latin letter and\\or digits", LoginText);
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            Program.flagExit = true;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string login;
            string password;

            login = LoginText.Text;
            password = PasswordText.Text;

            //Пример
            string loginTrue = "1";
            string passwordTrue = "1";


            if (loginTrue == login && passwordTrue == password)
            {
                Close();
                Program.flagLogin = false;
                Program.flagExit = false;
            }

            else
                MessageBox.Show("Wrong login or password!");
        }

        private void FormA_Load(object sender, EventArgs e)
        {
            FormB form = new FormB();
            form.Hide();
        }

        private void FormA_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.flagExit = true;
        }

        private void P_Click(object sender, EventArgs e)
        {

        }
    }
}
