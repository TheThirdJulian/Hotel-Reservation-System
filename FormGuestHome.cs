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
    public partial class FormGuestHome : Form
    {
        private UserRepo repo;
        private int currentacctid;

        public FormGuestHome()
        {
            InitializeComponent();

            repo = new UserRepo();
        }

        public void SetCurrentAcctId(int id) 
        {
            currentacctid = id;
        }

        public void CheckUserReservation() 
        {
            if (repo.GetGuestByAccountId(currentacctid) == null)
            {
                return;
            }
            Guests guest = repo.GetGuestByAccountId(currentacctid);
            if (guest.guestHasReservation)
            {
                Reservations reservation = repo.GetReservationByGuestId(guest.id);
                LabelCheckin.Text = reservation.resScheduleCheckin.ToString();
                LabelCheckout.Text = reservation.resScheduleCheckout.ToString();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Dispose();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            FormGuestReserve book = new FormGuestReserve();
            book.SetCurrentAcctId(currentacctid);
            book.Show();
            this.Dispose();
        }

        private void FormGuestHome_Load(object sender, EventArgs e)
        {
            CheckUserReservation();
        }
    }
}
