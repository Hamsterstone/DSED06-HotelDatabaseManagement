using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSED06_HotelDatabaseManagement.Data;

namespace DSED06_HotelDatabaseManagement.Business
{
    class RoomBooking
    {//becomes guest frontend?
     //create booking reservation
     //search through available rooms by dates given
     //shows beds/extras/prices per room
     //calculates beds used per room based on guest number input
     //guest special requests. new booking table field?
        internal static void CheckGuestIn()
        {//change booking state
            InfoPasserStatic.BookingPasser.BookingCheckedIn=DateTime.Now;
            InfoPasserStatic.BookingPasser.BookingStatus = "Checked In";
            Database.UpdateBooking();
            //create new bill for room charge
            
            
            
        }

        internal static void CheckGuestOut()
        {//update room charge bill for full time stayed
            InfoPasserStatic.BookingPasser.BookingCheckedOut=DateTime.Now;
            InfoPasserStatic.BookingPasser.BookingStatus = "Checked Out";
            Database.UpdateBooking();
            
        }
    }
}
