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
    public partial class FormEmployeeHome : Form
    {
        private HotelDBEntities db;
        private bool logout = false;

        public FormEmployeeHome()
        {
            InitializeComponent();

            LoadStatisticsDb();
        }

        private void LoadStatisticsDb() 
        { 
            db = new HotelDBEntities();

            int availablerooms = 0;
            int occupiedrooms = 0;
            int checkins = 0;
            int checkouts = 0;

            List<Reservations> latestReservations = new List<Reservations>();

            foreach (Rooms room in db.Rooms.ToList()) 
            {
                if (room.roomoccupants == 0)
                {
                    availablerooms++;
                }
                else 
                {
                    occupiedrooms++;
                }
            }

            foreach (Reservations res in db.Reservations.ToList()) 
            {
                if ((DateTime.Now - res.resScheduleCheckin).TotalDays <= 30) 
                {
                    latestReservations.Add(res);
                }
                if (res.resCheckinDate != null && (DateTime.Now - res.resCheckinDate.Value).TotalDays <= 30) 
                {
                    checkins++;
                } 
                if (res.resCheckoutDate != null && (DateTime.Now - res.resCheckoutDate.Value).TotalDays <= 30)
                {
                    checkouts++;
                }
            }

            LabelGuestCount.Text = db.Guests.ToList().Count.ToString();

            LabelRoomCount.Text = db.Rooms.ToList().Count().ToString();
            LabelRoomAvail.Text = availablerooms.ToString();
            LabelRoomOccupy.Text = occupiedrooms.ToString();

            LabelReservationCount.Text = latestReservations.Count.ToString();
            LabelCheckinCount.Text = checkins.ToString();
            LabelCheckoutCount.Text = checkouts.ToString();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            logout = true;
        }

        private void FormEmployeeHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logout)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Dispose();
            }
            else 
            {
                Application.Exit();
            }
        }

        private void BtnRoom_Click(object sender, EventArgs e)
        {
            FormEmployeeRooms rooms = new FormEmployeeRooms();
            rooms.Show();
            this.Dispose();
        }

        private void BtnGuests_Click(object sender, EventArgs e)
        {
            FormEmployeeGuests guests = new FormEmployeeGuests();
            guests.Show();
            this.Dispose();
        }

        private void BtnReservation_Click(object sender, EventArgs e)
        {
            FormEmployeeReservations reserves = new FormEmployeeReservations();
            reserves.Show();
            this.Dispose();
        }
    }
}
