using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSED06_HotelDatabaseManagement.Data;

namespace DSED06_HotelDatabaseManagement.Business
{
    class GuestBilling
    {  //create bills for each guest/room/booking 
       //find and collate all bills for a guest
       //output final itemizable bill details
       //boolean on guest table for bill paid
       //if room extra person rate ==-1, no extra beds available.
        internal static void PayBill(int billNumber)
        {
            Database.PayBill(billNumber);
        }

        public static void BillForRoom(int roomNumber, int numberOfGuests,int lengthOfStay)
        {
            int totalPrice = 0;
            Room thisRoom = Database.ReturnRoomInformation(roomNumber);
            int numberOfSingles = Convert.ToInt32(InfoPasserStatic.RoomPasser.RoomNumSingleBeds);
            int numberOfDoubles = Convert.ToInt32(InfoPasserStatic.RoomPasser.RoomNumDoubleBeds);
            int baseGuests = Math.Min(numberOfGuests, (numberOfDoubles * 2) + numberOfSingles);
            int overflowGuests = baseGuests - numberOfGuests;
            if (overflowGuests < 0) { overflowGuests = 0;}
            int basePrice = thisRoom.RoomBaseTariff;
            int extraPrice = thisRoom.RoomExtraPersonRate*overflowGuests;
            totalPrice += (basePrice + extraPrice)*lengthOfStay;

            Database.AddBill(roomNumber, "Room", totalPrice);
        }
    }
}

/*
 
     baseGuests = Math.Min(numberOfGuests,(numberOfDoubles*2) +numberOfSingles);
            maxGuests = baseGuests + numberOfExtras;
            
     */
