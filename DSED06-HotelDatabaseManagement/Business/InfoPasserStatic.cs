using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DSED06_HotelDatabaseManagement.Data;

namespace DSED06_HotelDatabaseManagement.Business
{
    static class InfoPasserStatic
    {
        public static int RoomID = -1;
        public static int GuestID = -1;
        public static int BookingID = -1;
        public static int BillingID = -1;
        public static int NumberOfGuests = -1;
        public static int NumberOfGuestsAssigned = 0;
        public static int GuestsInRoom;
        public static List<int> BillNumbers = new List<int>();
        public static int BillTotal = 0;
        public static Room RoomPasser = new Room();
        public static Billing BillPasser = new Billing();
        public static Booking BookingPasser = new Booking();
        public static Guest GuestPasser = new Guest();
        public static string rbtBookingCurrentState="Current";
        public static string rbtRoomCurrentState = "Free";
        public static string rbtGuestCurrentState = "Current";
        public static string rbtBillingCurrentState = "Open";
        public static Dictionary<int,int> SelectedRooms=new Dictionary<int, int>();
        public static Dictionary<int, int> SelectedRoomsOverflow = new Dictionary<int, int>();
        public static Dictionary<int,Room> RoomDictionary=new Dictionary<int, Room>();
        public static Dictionary<int, Billing> BillDictionary = new Dictionary<int, Billing>();
        public static Dictionary<int, Guest> GuestDictionary = new Dictionary<int, Guest>();
        public static Dictionary<int, Booking> BookingDictionary = new Dictionary<int, Booking>();
        public static DateTime StartDate = DateTime.Today;
        public static DateTime EndDate = DateTime.Today.AddDays(1);


    }
}
