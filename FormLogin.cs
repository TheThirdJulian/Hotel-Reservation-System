using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelDBMS.DBModel;

namespace HotelDBMS
{
    public partial class FormLogin : Form
    {
        private UserRepo userrepo;

        public FormLogin()
        {
            InitializeComponent();
            userrepo = new UserRepo();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUN.Text;
            string password = TxtPass.Text;

            Accounts LoginAttempt = userrepo.GetAccountByUsername(username);
            if (LoginAttempt == null) 
            {
                MessageBox.Show("Login failed! Credentials not found!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LoginAttempt.acctname == username && LoginAttempt.acctpass == password) 
            {
                MessageBox.Show("Login successful!", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SelectUserForm(LoginAttempt);
            }
        }

        private void SelectUserForm(Accounts LoggedAccount) 
        {
            switch (LoggedAccount.roleID)
            {
                case 1:
                    FormGuestHome guest = new FormGuestHome();
                    guest.SetCurrentAcctId(LoggedAccount.id);
                    guest.Show();
                    this.Hide();
                    break;
                case 2:
                    FormEmployeeHome employee = new FormEmployeeHome();
                    employee.Show();
                    this.Hide();
                    break;
                case 3:
                    FormAdminHome admin = new FormAdminHome();
                    admin.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Cannot login! User has no appropriate role!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
