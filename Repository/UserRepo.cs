using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelDBMS.DBModel;

namespace HotelDBMS
{
    public class UserRepo
    {
        private HotelDBEntities db;

        public UserRepo() 
        { 
            db = new HotelDBEntities();
        }

        public Accounts GetAccountByUsername(string un) 
        {
            db = new HotelDBEntities();
            return db.Accounts.Where(user => user.acctname == un).FirstOrDefault();
        }

        public int? GetRoomByReservationRoomId(int? resid)
        {
            db = new HotelDBEntities();
            return db.Reservations.Where(res => res.id == resid).FirstOrDefault().roomID;
        }
        public Reservations GetReservationByGuestId(int guestid) 
        {
            db = new HotelDBEntities();
            return db.Reservations.Where(reserve => reserve.guestID == guestid).FirstOrDefault();
        }
        public Reservations GetReservationById(int reserveid) 
        {
            db = new HotelDBEntities();
            return db.Reservations.Where(reserve => reserve.id == reserveid).FirstOrDefault();
        }
        public List<Reservations> ReservationsList() 
        {
            db = new HotelDBEntities();
            return db.Reservations.ToList();
        }

        public int? GetGuestByReservationGuestId(int? resid) 
        {
            db = new HotelDBEntities();
            return db.Reservations.Where(res => res.id == resid).FirstOrDefault().guestID;
        }
        public Guests GetGuestByAccountId(int acctid) 
        {
            db = new HotelDBEntities();
            return db.Guests.Where(g => g.acctID == acctid).FirstOrDefault();
        }
        public Guests GetGuestById(int? guestid) 
        {
            db = new HotelDBEntities();
            return db.Guests.Where(g => g.id == guestid).FirstOrDefault();
        }
        public List<Guests> GuestsList() 
        {
            db = new HotelDBEntities();
            return db.Guests.ToList();
        }

        public Rooms GetRoomByName(string name) 
        {
            db = new HotelDBEntities();
            return db.Rooms.Where(r => r.roomname == name).FirstOrDefault();
        }
        public Rooms GetRoomById(int? roomid) 
        {
            db = new HotelDBEntities();
            return db.Rooms.Where(r => r.id == roomid).FirstOrDefault();
        }
        public List<Rooms> RoomsList() 
        {
            db = new HotelDBEntities();
            return db.Rooms.ToList();
        }
        public List<Rooms> RoomsAvailableList() 
        {
            db = new HotelDBEntities();
            List<Rooms> AvailableRooms = new List<Rooms>();
            foreach (Rooms room in RoomsList()) 
            {
                if (room.roomoccupants == 0) 
                {
                    AvailableRooms.Add(room);
                }
            }

            return AvailableRooms;
        }

        // ===============
        // VIEWS SECTION
        // ===============

        public List<ViewGuest_Default> GuestsListStandard() 
        {
            db = new HotelDBEntities();
            return db.ViewGuest_Default.ToList();
        }

        public List<ViewRooms_Default> RoomsListStandard() 
        {
            db = new HotelDBEntities();
            return db.ViewRooms_Default.ToList();
        }

        public List<ViewReservations_Default> ReservationsListStandard() 
        {
            db = new HotelDBEntities();
            return db.ViewReservations_Default.ToList();
        }
    }
}
