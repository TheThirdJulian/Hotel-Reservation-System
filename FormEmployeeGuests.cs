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
using System.Xml.Linq;

namespace HotelDBMS
{
    public partial class FormEmployeeGuests : Form
    {
        private UserRepo repo;

        private int selectedid = 0;

        public FormEmployeeGuests()
        {
            InitializeComponent();
            repo = new UserRepo();

            LoadGuestsDb();
        }

        private void LoadGuestsDb() 
        {
            HotelDBEntities db = new HotelDBEntities();
            DgvGuests.DataSource = db.Guests.ToList();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Txtfn.Clear();
            Txtln.Clear();
            CbxGender.SelectedItem = null;
            MonCalBdate.SelectionStart = DateTime.Today;
            MonCalBdate.SelectionEnd = DateTime.Today;
            TxtBdate.Clear();
        }

        private void MonCalBdate_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtBdate.Text = MonCalBdate.SelectionRange.Start.ToString("MM/dd/yyyy");
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txtfn.Text) || String.IsNullOrEmpty(Txtln.Text) || String.IsNullOrEmpty(TxtBdate.Text) || String.IsNullOrEmpty(TxtBdate.Text))
            {
                MessageBox.Show("Cannot add guest! One of the inputs is invalid!", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guests guest = new Guests();
            guest.guestfn = Txtfn.Text;
            guest.guestln = Txtln.Text;
            guest.guestgender = CbxGender.Text;
            guest.guestbdate = MonCalBdate.SelectionRange.Start;
            guest.guestHasReservation = false;

            HotelDBEntities db = new HotelDBEntities();
            db.Guests.Add(guest);
            db.SaveChanges();
            MessageBox.Show("Guest successfully added!", "Successful Guest Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            selectedid = 0;
            BtnClear_Click(sender, e);
            LoadGuestsDb();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txtfn.Text) || String.IsNullOrEmpty(Txtln.Text) || String.IsNullOrEmpty(TxtBdate.Text) || String.IsNullOrEmpty(TxtBdate.Text))
            {
                MessageBox.Show("Cannot update guest! One of the inputs is invalid!", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guests guest = repo.GetGuestById(selectedid);
            guest.guestfn = Txtfn.Text;
            guest.guestln = Txtln.Text;
            guest.guestgender = CbxGender.Text;
            guest.guestbdate = MonCalBdate.SelectionRange.Start;

            HotelDBEntities db = new HotelDBEntities();
            db.SaveChanges();
            MessageBox.Show("Guest successfully updated!", "Successful Guest Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            selectedid = 0;
            BtnClear_Click(sender, e);
            LoadGuestsDb();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedid == 0)
            {
                MessageBox.Show("Cannot delete! Select a guest first!", "No Selected Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guests guest = repo.GetGuestById(selectedid);
            HotelDBEntities db = new HotelDBEntities();
            db.Guests.Remove(guest);
            db.SaveChanges();
            MessageBox.Show("Room successfully deleted!", "Successful Room Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            selectedid = 0;
            BtnClear_Click(sender, e);
            LoadGuestsDb();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Dispose();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormEmployeeHome home = new FormEmployeeHome();
            home.Show();
            this.Dispose();
        }

        private void DgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                selectedid = Convert.ToInt32(DgvGuests.Rows[e.RowIndex].Cells[0].Value);
                Guests guest = repo.GetGuestById(selectedid);

                Txtfn.Text = guest.guestfn;
                Txtln.Text = guest.guestln;
                CbxGender.Text = guest.guestgender;
                MonCalBdate.SelectionStart = guest.guestbdate;
                MonCalBdate.SelectionEnd = guest.guestbdate;
                if (guest.guestHasReservation)
                {
                    LabelStatus.Text = "OCCUPYING";
                }
                else 
                {
                    LabelStatus.Text = "AWAY FROM HOTEL";                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
