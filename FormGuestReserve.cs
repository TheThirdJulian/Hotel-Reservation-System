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
    public partial class FormGuestReserve : Form
    {
        private UserRepo repo;
        private int currentacctid = 0;

        public FormGuestReserve()
        {
            InitializeComponent();

            repo = new UserRepo();
            LoadCbxRooms();
        }

        public void SetCurrentAcctId(int id)
        {
            currentacctid = id;
        }

        private void LoadCbxRooms() 
        {
            List<Rooms> availablerooms = repo.RoomsAvailableList();
            CbxRooms.ValueMember = "id";
            CbxRooms.DisplayMember = "roomname";
            CbxRooms.DataSource = availablerooms;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormGuestHome home = new FormGuestHome();
            home.Show();
            this.Dispose();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(Txtfn.Text) || String.IsNullOrEmpty(Txtln.Text) || String.IsNullOrEmpty(CbxGender.Text) || String.IsNullOrEmpty(TxtBdate.Text) || String.IsNullOrEmpty(TxtCheckin.Text) || String.IsNullOrEmpty(TxtCheckout.Text) || String.IsNullOrEmpty(CbxRooms.Text)) 
                {
                    MessageBox.Show("Fill up all the inputs first!", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HotelDBEntities db = new HotelDBEntities();
                Rooms selectedroom = repo.GetRoomByName(CbxRooms.Text);
                db.SP_Room_Update_Occupy(selectedroom.id, 
                    Convert.ToInt32(DudAdultCount.Text) + Convert.ToInt32(DudChildCount.Text), 
                    currentacctid);

                //selectedroom.roomoccupants = Convert.ToInt32(DudAdultCount.Text) + Convert.ToInt32(DudChildCount.Text);
                //selectedroom.bookerAcctID = currentacctid;
                //db.SaveChanges();

                Guests newguest = repo.GetGuestByAccountId(currentacctid);
                db.SP_Guest_Update_Booking(newguest.id, Txtfn.Text, Txtln.Text, CbxGender.Text, MonCalBdate.SelectionRange.Start,
                    selectedroom.id);
                //newguest.guestfn = Txtfn.Text;
                //newguest.guestln = Txtln.Text;
                //newguest.guestgender = CbxGender.Text;
                //newguest.guestbdate = MonCalBdate.SelectionRange.Start;
                //newguest.guestHasReservation = true;
                //newguest.roomID = selectedroom.id;
                //db.SaveChanges();

                db.SP_Reservation_Create(MonCalChecking.SelectionRange.Start, MonCalChecking.SelectionRange.End,
                    Convert.ToInt32(DudAdultCount.Text), Convert.ToInt32(DudChildCount.Text), currentacctid,
                    selectedroom.id, newguest.id);
                //Reservations reservation = new Reservations();
                //reservation.resScheduleCheckin = MonCalChecking.SelectionRange.Start;
                //reservation.resScheduleCheckout = MonCalChecking.SelectionRange.End;
                //reservation.resAdults = Convert.ToInt32(DudAdultCount.Text);
                //reservation.resChildren = Convert.ToInt32(DudChildCount.Text);
                //reservation.acctID = currentacctid;
                //reservation.roomID = selectedroom.id;
                //reservation.guestID = newguest.id;
                //db.SaveChanges();

                MessageBox.Show("Reservation is successfully processed.", "Successful Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormGuestHome home = new FormGuestHome();
                home.SetCurrentAcctId(currentacctid);
                home.Show();
                this.Dispose();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Encountered exception: \n" + ex.Message, "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rooms selectedroom = repo.GetRoomByName(CbxRooms.Text);
            TxtType.Text = selectedroom.roomtype;
            TxtPrice.Text = selectedroom.roomprice.ToString("0.##");
            TxtDesc.Text = selectedroom.roomdesc;
        }

        private void MonCalBdate_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtBdate.Text = MonCalBdate.SelectionRange.Start.ToString("MMM dd, yyyy");
        }

        private void MonCalChecking_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtCheckin.Text = MonCalChecking.SelectionRange.Start.ToString("MMM dd, yyyy");
            TxtCheckout.Text = MonCalChecking.SelectionRange.End.ToString("MMM dd, yyyy");
        }
    }
}
