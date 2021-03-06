//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSED06_HotelDatabaseManagement.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            this.BookingRoomJoins = new HashSet<BookingRoomJoin>();
        }
    
        public int BookingID { get; set; }
        public int GuestIDFK { get; set; }
        public System.DateTime BookingFrom { get; set; }
        public System.DateTime BookingTo { get; set; }
        public Nullable<System.DateTime> BookingCheckedIn { get; set; }
        public Nullable<System.DateTime> BookingCheckedOut { get; set; }
        public string BookingNotes { get; set; }
        public string BookingStatus { get; set; }
        public int BookingNumberOfGuests { get; set; }
    
        public virtual Guest Guest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingRoomJoin> BookingRoomJoins { get; set; }
    }
}
