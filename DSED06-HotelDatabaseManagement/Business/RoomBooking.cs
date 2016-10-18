using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSED06_HotelDatabaseManagement.Data;

namespace DSED06_HotelDatabaseManagement.Business
{
    class RoomBooking
    {
        //becomes guest frontend?
        //create booking reservation
        //search through available rooms by dates given
        //shows beds/extras/prices per room
        //calculates beds used per room based on guest number input
        //guest special requests. new booking table field?

        
        internal static void CheckGuestIn()
        {
            //set check in date
            InfoPasserStatic.BookingPasser.BookingCheckedIn = DateTime.Now;
            //change booking state to Checked In
            InfoPasserStatic.BookingPasser.BookingStatus = "Checked In";
            //update the booking
            Database.UpdateBooking();
            
            //get booking ingormation from the database
            Booking thisBooking = Database.ReturnBookingInformation(InfoPasserStatic.BookingPasser.BookingID);
            //set length of stay
            int lengthOfStay = (thisBooking.BookingTo - thisBooking.BookingFrom).Days;
            //get bookingroomjoins for the booking
            List<BookingRoomJoin> thisBookingRoomJoins = Database.ReturnBookRoomJoinInformation(thisBooking.BookingID);
            foreach (var room in thisBookingRoomJoins)
            {
                //create new bill for room charge for each room booked
                GuestBilling.BillForRoom(room.RoomIDFK, room.NumberOfGuests, lengthOfStay);
            }


        }

        internal static void CheckGuestOut()
        {
            //Update booking information with checkout date and status
            InfoPasserStatic.BookingPasser.BookingCheckedOut=DateTime.Now;
            InfoPasserStatic.BookingPasser.BookingStatus = "Checked Out";
            Database.UpdateBooking();
            
        }
    }
}
