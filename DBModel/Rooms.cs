//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelDBMS.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rooms
    {
        public Rooms()
        {
            this.Guests = new HashSet<Guests>();
            this.Reservations = new HashSet<Reservations>();
        }
    
        public int id { get; set; }
        public string roomname { get; set; }
        public string roomtype { get; set; }
        public decimal roomprice { get; set; }
        public string roomdesc { get; set; }
        public int roomoccupants { get; set; }
        public Nullable<int> bookerAcctID { get; set; }
    
        public virtual Accounts Accounts { get; set; }
        public virtual ICollection<Guests> Guests { get; set; }
        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}