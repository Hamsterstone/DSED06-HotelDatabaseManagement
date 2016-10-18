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
    { 
        
        internal static void PayBill(int billNumber)
        {
            Database.PayBill(billNumber);
        }

        public static void BillForRoom(int roomNumber, int numberOfGuests,int lengthOfStay)
        {
            int totalPrice = 0;
            //get the room information
            Room thisRoom = Database.ReturnRoomInformation(roomNumber);
            //work out the number of beds the room comes with normally
            int numberOfSingles = Convert.ToInt32(InfoPasserStatic.RoomPasser.RoomNumSingleBeds);
            int numberOfDoubles = Convert.ToInt32(InfoPasserStatic.RoomPasser.RoomNumDoubleBeds);
            int baseGuests = Math.Min(numberOfGuests, (numberOfDoubles * 2) + numberOfSingles);
            //work out how many guests there are more than the number of beds
            int overflowGuests = baseGuests - numberOfGuests;
            if (overflowGuests < 0) { overflowGuests = 0;}
            //calculate the rate for the room
            int basePrice = thisRoom.RoomBaseTariff;
            int extraPrice = thisRoom.RoomExtraPersonRate*overflowGuests;
            totalPrice += (basePrice + extraPrice)*lengthOfStay;
            //create a bill for the room
            Database.AddBill(roomNumber, "Room", totalPrice);
        }
    }
}
