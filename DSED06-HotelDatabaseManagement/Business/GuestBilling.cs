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

        public static void BillForRoom(int roomNumber)
        {
            int totalPrice=0;
            
                int basePrice = Database.ReturnRoomInformation(roomNumber).RoomBaseTariff;
                int extraPrice = Database.ReturnRoomInformation(roomNumber).RoomExtraPersonRate*InfoPasserStatic.SelectedRoomsOverflow[roomNumber];
                totalPrice += basePrice + extraPrice;

           Database.AddBill(roomNumber,"Room",totalPrice);

            
        }
    }
}
