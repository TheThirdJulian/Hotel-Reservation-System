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
    public partial class FormEmployeeReservations : Form
    {
        private UserRepo repo;

        private int selectedid = 0;

        public FormEmployeeReservations()
        {
            InitializeComponent();

            repo = new UserRepo();
            BtnClear_Click(null, null);
            LoadReservationsDb();
        }

        private void LoadReservationsDb() 
        {
            HotelDBEntities db = new HotelDBEntities();
            DgvReservations.DataSource = db.Reservations.ToList();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LabelCheckin.Text = "N/A";
            LabelCheckout.Text = "N/A";
            LabelHasIn.Text = "N/A";
            LabelHasIn.ForeColor = Color.Black;
            LabelInDate.Text = "N/A";
            LabelInDate.ForeColor = Color.Black;
            LabelHasOut.Text = "N/A";
            LabelHasOut.ForeColor = Color.Black;
            LabelOutDate.Text = "N/A";
            LabelOutDate.ForeColor = Color.Black;

            LabelDaysAfterCheckin.Text = "Days since Check-In:  Unknown";
            LabelGuestsCount.Text = "Unknown";
            LabelRoomName.Text = "Unknown";
            LabelGuestName.Text = "Unknown";

            BtnCheckIn.Enabled = false;
            BtnCheckOut.Enabled = false;
        }

        private void DgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = Convert.ToInt32(DgvReservations.Rows[e.RowIndex].Cells[0].Value);
            Reservations selectReservation = repo.GetReservationById(selectedid);

            LabelCheckin.Text = selectReservation.resScheduleCheckin.ToString();
            LabelCheckout.Text = selectReservation.resScheduleCheckout.ToString();
            LabelGuestsCount.Text = selectReservation.resAdults + " Adults, " + selectReservation.resChildren + " Children";

            if (!selectReservation.resCheckinDate.HasValue)
            {
                LabelHasIn.Text = "NO";
                LabelHasIn.ForeColor = Color.Red;
                BtnCheckIn.Enabled = true;
            }
            else
            {
                LabelHasIn.Text = "YES";
                LabelHasIn.ForeColor = Color.ForestGreen;
                LabelInDate.Text = selectReservation.resCheckinDate.Value.ToString();
                LabelInDate.ForeColor = Color.ForestGreen;
                LabelDaysAfterCheckin.Text = "Days since Check-In:  " + (DateTime.Today - selectReservation.resCheckinDate.Value).TotalDays.ToString("0.##");

                BtnCheckIn.Enabled = false;
            }

            if (!selectReservation.resCheckoutDate.HasValue)
            {
                LabelHasOut.Text = "NO";
                LabelHasOut.ForeColor = Color.Red;
                BtnCheckOut.Enabled = true;
            }
            else
            {
                LabelHasOut.Text = "YES";
                LabelHasOut.ForeColor = Color.ForestGreen;
                LabelOutDate.Text = selectReservation.resCheckoutDate.Value.ToString();
                LabelOutDate.ForeColor = Color.ForestGreen;
                LabelDaysAfterCheckin.Text = "Days since Check-In:  " + (selectReservation.resCheckoutDate.Value - selectReservation.resCheckinDate.Value).TotalDays.ToString("0.##");

                BtnCheckOut.Enabled = false;
            }

            int? roomid = repo.GetRoomByReservationRoomId(selectedid);
            int? guestid = repo.GetGuestByReservationGuestId(selectedid);
            LabelRoomName.Text = repo.GetRoomById(roomid).roomname;
            LabelGuestName.Text = repo.GetGuestById(guestid).guestln + ", " + repo.GetGuestById(guestid).guestfn;

        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            HotelDBEntities db = new HotelDBEntities();
            db.SP_Reservation_Update_CheckIn(selectedid, DateTime.Today);

            LabelHasIn.Text = "YES";
            LabelHasIn.ForeColor = Color.ForestGreen;
            LabelInDate.Text = DateTime.Today.ToString("MMM dd, yyyy");
            LabelInDate.ForeColor = Color.ForestGreen;

            MessageBox.Show("Successfully updated reservation! Guest has checked in.", "Confirmed Check-in", MessageBoxButtons.OK, MessageBoxIcon.Information);

            selectedid = 0;
            BtnClear_Click(sender, e);
            LoadReservationsDb();
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            HotelDBEntities db = new HotelDBEntities();
            db.SP_Reservation_Update_CheckOut(selectedid, DateTime.Today);

            LabelHasOut.Text = "YES";
            LabelHasOut.ForeColor = Color.ForestGreen;
            LabelOutDate.Text = DateTime.Today.ToString("MMM dd, yyyy");
            LabelOutDate.ForeColor = Color.ForestGreen;

            MessageBox.Show("Successfully updated reservation! Guest has checked out.", "Confirmed Check-out", MessageBoxButtons.OK, MessageBoxIcon.Information);

            selectedid = 0;
            BtnClear_Click(sender, e);
            LoadReservationsDb();
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

        private void FormEmployeeReservations_Load(object sender, EventArgs e)
        {

        }
    }
}
