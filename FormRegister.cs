using HotelDBMS.DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDBMS
{
    public partial class FormRegister : Form
    {
        private HotelDBEntities db = new HotelDBEntities();

        public FormRegister()
        {
            InitializeComponent();

            var roles = db.Roles.ToList();
            CbxRoles.ValueMember = "id";
            CbxRoles.DisplayMember = "rolename";
            CbxRoles.DataSource = roles;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtUN.Text) || String.IsNullOrEmpty(TxtPass.Text))
            {
                MessageBox.Show("Cannot register! One of the inputs is invalid!", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Accounts registeredacct = new Accounts();
            registeredacct.acctname = TxtUN.Text;
            registeredacct.acctpass = TxtPass.Text;
            registeredacct.acctstatus = "ACTIVE";
            registeredacct.roleID = Convert.ToInt32(CbxRoles.SelectedValue);
            registeredacct.creatorID = registeredacct.id;

            db.Accounts.Add(registeredacct);
            db.SaveChanges();

            if (registeredacct.roleID == 1)
            {
                db.SP_Guest_Create_Register("", "", DateTime.Now, "Prefer not to say", registeredacct.id);
            }
            MessageBox.Show("Account successfully registered!", "Successful registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
        }
    }
}
