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
    
    public partial class Roles
    {
        public Roles()
        {
            this.Accounts = new HashSet<Accounts>();
            this.Employees = new HashSet<Employees>();
        }
    
        public int id { get; set; }
        public string rolename { get; set; }
    
        public virtual ICollection<Accounts> Accounts { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
