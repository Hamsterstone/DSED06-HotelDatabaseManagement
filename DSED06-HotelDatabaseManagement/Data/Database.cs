using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSED06_HotelDatabaseManagement;
using DSED06_HotelDatabaseManagement.Business;

namespace DSED06_HotelDatabaseManagement.Data
{
    public static class Database
    {
        public static DataGridView FakeDgvAdmin { get; set; }
        public static DataGridView FakeDgvBilling { get; set; }
        public static DataGridView FakeDgvBooking { get; set; }
        public static DataGridView FakeDgvRooms { get; set; }
        public static DataGridView FakeDgvGuests { get; set; }
        ////load datagridviews
        ////add guest
        ////edit guest information
        ////add room
        ////edit room details
        ////add/update bills
        ////create/update booking
        //search guest/booking/bill/room
        public static void AddGuest(string name, string address, string phone, string notes)
        {
            using (var context = new Entities())
            {
                var newGuest = new Guest();
                //todo register guest info page
                newGuest.GuestName = name;
                newGuest.GuestAddress = address;
                newGuest.GuestTelephone = phone;
                newGuest.GuestNotes = notes;
                context.Guests.Add(newGuest);
                context.SaveChanges();
            }
        }

        //For Admin completeness, never used.
        public static void AddRoom(int singles, int doubles, int tarrif, int extraPerson, string features)
        {
            using (var context = new Entities())
            {
                var newRoom = new Room();

                newRoom.RoomNumSingleBeds = singles;
                newRoom.RoomNumDoubleBeds = doubles;
                newRoom.RoomBaseTariff = tarrif;
                newRoom.RoomExtraPersonRate = extraPerson;
                newRoom.RoomExtraFeatures = features;
                context.Rooms.Add(newRoom);
                context.SaveChanges();
            }
        }

        public static void AddBooking(int guest, DateTime from, DateTime to, string notes, Dictionary<int,int> rooms,int numOfGuests)
        {

            using (var context = new Entities())
            {
                var newBooking = new Booking();
                newBooking.GuestIDFK = guest;
                newBooking.BookingFrom = from;
                newBooking.BookingTo = to;
                newBooking.BookingNotes = notes;
                newBooking.BookingStatus = "Pending";
                newBooking.BookingNumberOfGuests = numOfGuests;
                context.Bookings.Add(newBooking);
                // context.SaveChanges();
                foreach (var roomGuestPair in rooms)
                {
                    var newBookingRoomJoin = new BookingRoomJoin();
                    newBookingRoomJoin.BookingIDFK = newBooking.BookingID;
                    newBookingRoomJoin.RoomIDFK = roomGuestPair.Key;
                    newBookingRoomJoin.NumberOfGuests = roomGuestPair.Value;
                    context.BookingRoomJoins.Add(newBookingRoomJoin);

                }
                context.SaveChanges();

            }

        }

        public static void AddBill(int roomNumber, string type, int amount)
        {
            using (var context = new Entities())
            {
                var newBill = new Billing();
                var bookid =
                    from b in
                        context.BookingRoomJoins.Where(
                            b => b.RoomIDFK == roomNumber && b.Booking.BookingStatus == "Checked In")
                    select b.ID;
                newBill.BookingRoomJoinIDFK = bookid.FirstOrDefault();

                switch (type)
                {
                    case "Bar":
                        newBill.BarCharge = amount;
                        break;
                    case "Phone":
                        newBill.PhoneCharge = amount;
                        break;
                    case "Room":
                        newBill.RoomCharge = amount;
                        break;
                    case "WiFi":
                        newBill.WiFiCharge = amount;
                        break;
                }
                context.Billings.Add(newBill);
                context.SaveChanges();
            }
            //Invoice_No = b.BillingID,
            //            b.Booking.BookingID,
            //            Bar_Charge = b.BarCharge,
            //            Phone_Charge = b.PhoneCharge,
            //            Room_Charge = b.RoomCharge,
            //            WiFi_Charge = b.WiFiCharge,
            //            Paid = b.BillingPaid
        }

        public static void UpdateGuest()
        {
            using (var context = new Entities())
            {
                int id = Convert.ToInt32(InfoPasserStatic.GuestID);
                var query = from g in context.Guests where g.GuestID == id select g;
                var guest = query.FirstOrDefault();
                guest.GuestName = InfoPasserStatic.GuestPasser.GuestName;
                guest.GuestAddress = InfoPasserStatic.GuestPasser.GuestAddress;
                guest.GuestTelephone = InfoPasserStatic.GuestPasser.GuestTelephone;
                guest.GuestNotes = InfoPasserStatic.GuestPasser.GuestNotes;
                context.SaveChanges();
            }
        }

        public static void UpdateBooking()
        {
            using (var context = new Entities())
            {
                int id = Convert.ToInt32(InfoPasserStatic.BookingID);
                var query = from b in context.Bookings where b.BookingID == id select b;
                var booking = query.FirstOrDefault();
                booking.BookingFrom = InfoPasserStatic.BookingPasser.BookingFrom;
                booking.BookingTo = InfoPasserStatic.BookingPasser.BookingTo;
                booking.BookingCheckedIn = InfoPasserStatic.BookingPasser.BookingCheckedIn;
                booking.BookingCheckedOut = InfoPasserStatic.BookingPasser.BookingCheckedOut;
                booking.BookingNotes = InfoPasserStatic.BookingPasser.BookingNotes;
                booking.BookingStatus = InfoPasserStatic.BookingPasser.BookingStatus;
                booking.BookingNumberOfGuests = InfoPasserStatic.BookingPasser.BookingNumberOfGuests;
                context.SaveChanges();
            }
        }

        public static void UpdateBill()
        {
            using (var context = new Entities())
            {
                int id = Convert.ToInt32(InfoPasserStatic.BillingID);
                var query = from b in context.Billings where b.BillingID == id select b;
                var bill = query.FirstOrDefault();
                bill.BarCharge = InfoPasserStatic.BillPasser.BarCharge;
                bill.RoomCharge = InfoPasserStatic.BillPasser.RoomCharge;
                bill.PhoneCharge = InfoPasserStatic.BillPasser.PhoneCharge;
                bill.WiFiCharge = InfoPasserStatic.BillPasser.WiFiCharge;
                bill.BillingPaid = InfoPasserStatic.BillPasser.BillingPaid;
                context.SaveChanges();
            }
        }

        public static void PayBill(int billNumber)
        {
            using (var context = new Entities())
            {
                
                var query = from b in context.Billings where b.BillingID == billNumber
                            select b;
                var bill = query.FirstOrDefault();
               
                bill.BillingPaid = true;
                context.SaveChanges();
            }
        }

        public static void UpdateRoom(int singleBeds, int doubleBeds, int baseTariff, int extraPersonRate,
            string extraFeatures)
        {
            using (var context = new Entities())
            {
                int id = Convert.ToInt32(InfoPasserStatic.RoomID);
                var query = from b in context.Rooms where b.RoomID == id select b;
                var room = query.FirstOrDefault();
                room.RoomNumSingleBeds = InfoPasserStatic.RoomPasser.RoomNumSingleBeds;
                room.RoomNumDoubleBeds = InfoPasserStatic.RoomPasser.RoomNumDoubleBeds;
                room.RoomBaseTariff = InfoPasserStatic.RoomPasser.RoomBaseTariff;
                room.RoomExtraPersonRate = InfoPasserStatic.RoomPasser.RoomExtraPersonRate;
                room.RoomExtraFeatures = InfoPasserStatic.RoomPasser.RoomExtraFeatures;
                context.SaveChanges();
            }
        }


        public static void FillFakeDgvRooms()
        {
            switch (InfoPasserStatic.rbtRoomCurrentState)
            {
                case "All":
                    using (var context = new Entities())
                    {
                        var alldata = from r in context.Rooms
                            select new
                            {
                                Room_Number = r.RoomID,
                                Single_Beds = r.RoomNumSingleBeds,
                                Double_Beds = r.RoomNumDoubleBeds,
                                Room_Tarrif = r.RoomBaseTariff,
                                Extra_Person_Rate = r.RoomExtraPersonRate,
                                Extra_Features = r.RoomExtraFeatures
                            };

                        FakeDgvRooms.DataSource = alldata.ToList();
                    }
                    break;
                case "Free":
                    using (var context = new Entities())
                    {
                        var roomsOccupied = FindOccupiedRooms();
                        var alldata = from r in context.Rooms
                            where (!roomsOccupied.Contains(r.RoomID))
                            select new
                            {
                                Room_Number = r.RoomID,
                                Single_Beds = r.RoomNumSingleBeds,
                                Double_Beds = r.RoomNumDoubleBeds,
                                Room_Tarrif = r.RoomBaseTariff,
                                Extra_Person_Rate = r.RoomExtraPersonRate,
                                Extra_Features = r.RoomExtraFeatures
                            };

                        FakeDgvRooms.DataSource = alldata.ToList();
                    }
                    break;
                case "Occupied":
                    using (var context = new Entities())
                    {
                        var roomsOccupied = FindOccupiedRooms();
                        var alldata = from r in context.Rooms
                            where (roomsOccupied.Contains(r.RoomID))
                            select new
                            {
                                Room_Number = r.RoomID,
                                Single_Beds = r.RoomNumSingleBeds,
                                Double_Beds = r.RoomNumDoubleBeds,
                                Room_Tarrif = r.RoomBaseTariff,
                                Extra_Person_Rate = r.RoomExtraPersonRate,
                                Extra_Features = r.RoomExtraFeatures
                            };

                        FakeDgvRooms.DataSource = alldata.ToList();
                    }
                    break;
            }

        }

        public static void FillFakeDgvRooms(DateTime start, DateTime end)
        {
            switch (InfoPasserStatic.rbtRoomCurrentState)
            {
                case "All":
                    using (var context = new Entities())
                    {
                        var alldata = from r in context.Rooms
                            select new
                            {
                                Room_Number = r.RoomID,
                                Single_Beds = r.RoomNumSingleBeds,
                                Double_Beds = r.RoomNumDoubleBeds,
                                Room_Tarrif = r.RoomBaseTariff,
                                Extra_Person_Rate = r.RoomExtraPersonRate,
                                Extra_Features = r.RoomExtraFeatures
                            };

                        FakeDgvRooms.DataSource = alldata.ToList();
                    }
                    break;
                case "Free":
                    using (var context = new Entities())
                    {
                        var roomsOccupied = FindOccupiedRooms(start, end);
                        var alldata = from r in context.Rooms
                            where (!roomsOccupied.Contains(r.RoomID))
                            select new
                            {
                                Room_Number = r.RoomID,
                                Single_Beds = r.RoomNumSingleBeds,
                                Double_Beds = r.RoomNumDoubleBeds,
                                Room_Tarrif = r.RoomBaseTariff,
                                Extra_Person_Rate = r.RoomExtraPersonRate,
                                Extra_Features = r.RoomExtraFeatures
                            };

                        FakeDgvRooms.DataSource = alldata.ToList();
                    }
                    break;
                case "Occupied":
                    using (var context = new Entities())
                    {
                        var roomsOccupied = FindOccupiedRooms(start, end);
                        var alldata = from r in context.Rooms
                            where (roomsOccupied.Contains(r.RoomID))
                            select new
                            {
                                Room_Number = r.RoomID,
                                Single_Beds = r.RoomNumSingleBeds,
                                Double_Beds = r.RoomNumDoubleBeds,
                                Room_Tarrif = r.RoomBaseTariff,
                                Extra_Person_Rate = r.RoomExtraPersonRate,
                                Extra_Features = r.RoomExtraFeatures
                            };

                        FakeDgvRooms.DataSource = alldata.ToList();
                    }
                    break;
            }

        }

        public static void FillFakeDgvBilling()
        {
            switch (InfoPasserStatic.rbtBillingCurrentState)
            {
                case "All":
                    using (var context = new Entities())
                    {
                        var alldata = from b in context.Billings
                            select new
                            {
                                Invoice_No = b.BillingID,
                                b.BookingRoomJoin.Room.RoomID,
                                Bar_Charge = b.BarCharge,
                                Phone_Charge = b.PhoneCharge,
                                Room_Charge = b.RoomCharge,
                                WiFi_Charge = b.WiFiCharge,
                                Paid = b.BillingPaid
                            };
                        FakeDgvBilling.DataSource = alldata.ToList();
                    }
                    break;
                case "Open":
                    using (var context = new Entities())
                    {
                        var alldata = from b in context.Billings.Where(b => !b.BillingPaid)
                            select new
                            {
                                Invoice_No = b.BillingID,
                                b.BookingRoomJoin.Room.RoomID,
                                Bar_Charge = b.BarCharge,
                                Phone_Charge = b.PhoneCharge,
                                Room_Charge = b.RoomCharge,
                                WiFi_Charge = b.WiFiCharge,
                                Paid = b.BillingPaid
                            };
                        FakeDgvBilling.DataSource = alldata.ToList();
                    }
                    break;
                case "Pay":
                    using (var context = new Entities())
                    {
                        var alldata = from b in context.Billings.Where(b => !b.BillingPaid)
                                      select new
                            {
                                Invoice_No = b.BillingID,
                                b.BookingRoomJoin.Room.RoomID,
                                Bar_Charge = b.BarCharge,
                                Phone_Charge = b.PhoneCharge,
                                Room_Charge = b.RoomCharge,
                                WiFi_Charge = b.WiFiCharge,
                                Paid = b.BillingPaid
                            };
                        FakeDgvBilling.DataSource = alldata.ToList();
                    }
                    break;
            }


        }

        public static void FillFakeDgvBilling(DateTime start, DateTime end)
        {
            switch (InfoPasserStatic.rbtBillingCurrentState)
            {
                case "All":
                    using (var context = new Entities())
                    {
                        var alldata =
                            from b in
                                context.Billings.Where(
                                    b =>
                                        b.BookingRoomJoin.Booking.BookingFrom >= start &&
                                        b.BookingRoomJoin.Booking.BookingTo <= end)
                            select new
                            {
                                Invoice_No = b.BillingID,
                                b.BookingRoomJoin.Room.RoomID,
                                Bar_Charge = b.BarCharge,
                                Phone_Charge = b.PhoneCharge,
                                Room_Charge = b.RoomCharge,
                                WiFi_Charge = b.WiFiCharge,
                                Paid = b.BillingPaid
                            };
                        FakeDgvBilling.DataSource = alldata.ToList();
                    }
                    break;
                case "Open":
                    using (var context = new Entities())
                    {
                        var alldata = from b in context.Billings.Where(b => !b.BillingPaid)
                            select new
                            {
                                Invoice_No = b.BillingID,
                                b.BookingRoomJoin.Room.RoomID,
                                Bar_Charge = b.BarCharge,
                                Phone_Charge = b.PhoneCharge,
                                Room_Charge = b.RoomCharge,
                                WiFi_Charge = b.WiFiCharge,
                                Paid = b.BillingPaid
                            };
                        FakeDgvBilling.DataSource = alldata.ToList();
                    }
                    break;
                case "Pay":
                    using (var context = new Entities())
                    {
                        var alldata = from b in context.Billings.Where(b => !b.BillingPaid)
                                      select new
                            {
                                Invoice_No = b.BillingID,
                                b.BookingRoomJoin.Room.RoomID,
                                Bar_Charge = b.BarCharge,
                                Phone_Charge = b.PhoneCharge,
                                Room_Charge = b.RoomCharge,
                                WiFi_Charge = b.WiFiCharge,
                                Paid = b.BillingPaid
                            };
                        FakeDgvBilling.DataSource = alldata.ToList();
                    }
                    break;
            }


        }


        public static void FillFakeDgvBooking()
        {
            switch (InfoPasserStatic.rbtBookingCurrentState)
            {
                case "Future":
                    using (var context = new Entities())
                    {
                        DateTime today = DateTime.Today;
                        var alldata = from j in context.BookingRoomJoins.Where(j => j.Booking.BookingFrom > today)

                            select new
                            {
                                //may need to use join table info
                                j.Booking.BookingID,
                                Guest_Name = j.Booking.Guest.GuestName,
                                From = j.Booking.BookingFrom,
                                To = j.Booking.BookingTo,
                                Checked_In = j.Booking.BookingCheckedIn,
                                Checked_Out = j.Booking.BookingCheckedOut,
                                Notes = j.Booking.BookingNotes,
                                Status = j.Booking.BookingStatus,
                                Rooms = j.Room.RoomID
                            };
                        FakeDgvBooking.DataSource = alldata.ToList();
                    }
                    break;
                case "All":
                    using (var context = new Entities())
                    {

                        var alldata = from j in context.BookingRoomJoins

                            select new
                            {
                                //may need to use join table info
                                j.Booking.BookingID,
                                Guest_Name = j.Booking.Guest.GuestName,
                                From = j.Booking.BookingFrom,
                                To = j.Booking.BookingTo,
                                Checked_In = j.Booking.BookingCheckedIn,
                                Checked_Out = j.Booking.BookingCheckedOut,
                                Notes = j.Booking.BookingNotes,
                                Status = j.Booking.BookingStatus,
                                Rooms = j.Room.RoomID
                            };
                        FakeDgvBooking.DataSource = alldata.ToList();
                    }
                    break;
                case "Current":
                    using (var context = new Entities())
                    {

                        var alldata =
                            from j in
                                context.BookingRoomJoins.Where(
                                    j =>
                                        j.Booking.BookingFrom <= DateTime.Today && j.Booking.BookingTo >= DateTime.Today)

                            select new
                            {
                                //may need to use join table info
                                j.Booking.BookingID,
                                Guest_Name = j.Booking.Guest.GuestName,
                                From = j.Booking.BookingFrom,
                                To = j.Booking.BookingTo,
                                Checked_In = j.Booking.BookingCheckedIn,
                                Checked_Out = j.Booking.BookingCheckedOut,
                                Notes = j.Booking.BookingNotes,
                                Status = j.Booking.BookingStatus,
                                Rooms = j.Room.RoomID
                            };
                        FakeDgvBooking.DataSource = alldata.ToList();
                    }
                    break;
            }

        }
        public static void FillFakeDgvBooking(DateTime start, DateTime end)
        {
            switch (InfoPasserStatic.rbtBookingCurrentState)
            {
                case "Future":
                    using (var context = new Entities())
                    {
                        DateTime today = DateTime.Today;
                        var alldata = from j in context.BookingRoomJoins.Where(j => j.Booking.BookingFrom > today&&j.Booking.BookingFrom>=start&&j.Booking.BookingTo<=end)

                                      select new
                                      {
                                          //may need to use join table info
                                          j.Booking.BookingID,
                                          Guest_Name = j.Booking.Guest.GuestName,
                                          From = j.Booking.BookingFrom,
                                          To = j.Booking.BookingTo,
                                          Checked_In = j.Booking.BookingCheckedIn,
                                          Checked_Out = j.Booking.BookingCheckedOut,
                                          Notes = j.Booking.BookingNotes,
                                          Status = j.Booking.BookingStatus,
                                          Rooms = j.Room.RoomID
                                      };
                        FakeDgvBooking.DataSource = alldata.ToList();
                    }
                    break;
                case "All":
                    using (var context = new Entities())
                    {

                        var alldata = from j in context.BookingRoomJoins.Where(j =>  j.Booking.BookingFrom >= start && j.Booking.BookingTo <= end)

                                      select new
                                      {
                                          //may need to use join table info
                                          j.Booking.BookingID,
                                          Guest_Name = j.Booking.Guest.GuestName,
                                          From = j.Booking.BookingFrom,
                                          To = j.Booking.BookingTo,
                                          Checked_In = j.Booking.BookingCheckedIn,
                                          Checked_Out = j.Booking.BookingCheckedOut,
                                          Notes = j.Booking.BookingNotes,
                                          Status = j.Booking.BookingStatus,
                                          Rooms = j.Room.RoomID
                                      };
                        FakeDgvBooking.DataSource = alldata.ToList();
                    }
                    break;
                case "Current":
                    using (var context = new Entities())
                    {

                        var alldata =
                            from j in
                                context.BookingRoomJoins.Where(
                                    j =>
                                        j.Booking.BookingFrom <= DateTime.Today && j.Booking.BookingTo >= DateTime.Today)

                            select new
                            {
                                //may need to use join table info
                                j.Booking.BookingID,
                                Guest_Name = j.Booking.Guest.GuestName,
                                From = j.Booking.BookingFrom,
                                To = j.Booking.BookingTo,
                                Checked_In = j.Booking.BookingCheckedIn,
                                Checked_Out = j.Booking.BookingCheckedOut,
                                Notes = j.Booking.BookingNotes,
                                Status = j.Booking.BookingStatus,
                                Rooms = j.Room.RoomID
                            };
                        FakeDgvBooking.DataSource = alldata.ToList();
                    }
                    break;
            }

        }

        public static void FillFakeDgvGuests()
        {
            switch (InfoPasserStatic.rbtGuestCurrentState)
            {
                case "All":
                    using (var context = new Entities())
                    {
                        var alldata = from g in context.Guests
                            select new
                            {
                                Name = g.GuestName,
                                Address = g.GuestAddress,
                                Phone = g.GuestTelephone,
                                Notes = g.GuestNotes,
                                Guest_Number = g.GuestID
                            };
                        FakeDgvGuests.DataSource = alldata.ToList();
                    }
                    break;
                case "Current":
                    using (var context = new Entities())
                    {
                        var alldata = from g in context.Bookings.Where(g=>g.BookingFrom<= DateTime.Today&&g.BookingTo>=DateTime.Today)
                                      select new
                                      {
                                          Name = g.Guest.GuestName,
                                          Address = g.Guest.GuestAddress,
                                          Phone = g.Guest.GuestTelephone,
                                          Notes = g.Guest.GuestNotes,
                                          Guest_Number = g.Guest.GuestID
                                      };
                        FakeDgvGuests.DataSource = alldata.ToList();
                    }
                    break;
                case "Pending":
                    using (var context = new Entities())
                    {
                        var alldata = from g in context.Bookings.Where(g => g.BookingFrom <= DateTime.Today)
                                      select new
                                      {
                                          Name = g.Guest.GuestName,
                                          Address = g.Guest.GuestAddress,
                                          Phone = g.Guest.GuestTelephone,
                                          Notes = g.Guest.GuestNotes,
                                          Guest_Number = g.Guest.GuestID
                                      };
                        FakeDgvGuests.DataSource = alldata.ToList();
                    }
                    break;
            }
        }

        
        public static List<int> FindBookedRooms()
        {
            List<int> fullRoomsList = new List<int>();

            using (var context = new Entities())
            {
                var fullRooms =
                    context.BookingRoomJoins.Where(
                        j => j.Booking.BookingStatus != "Checked In" || j.Booking.BookingStatus != "Overdue")
                        .Select(j => new {j.Room.RoomID})
                        .ToList();
                fullRoomsList.AddRange(fullRooms.Select(r => r.RoomID));
            }


            return fullRoomsList;
        }

        public static List<int> FindOccupiedRooms()
        {
            List<int> fullRoomsList = new List<int>();

            using (var context = new Entities())
            {
                var fullRooms =
                    context.BookingRoomJoins.Where(
                        j => j.Booking.BookingStatus == "Checked In")
                        .Select(j => new {j.Room.RoomID})
                        .ToList();
                fullRoomsList.AddRange(fullRooms.Select(r => r.RoomID));
            }


            return fullRoomsList;
        }

        internal static List<int> FindUnpaidBillRooms()
        {
            List<int> unpaidBillRoomsList = new List<int>();
            using (var context = new Entities())
            {
                var unpaidBillRooms =
                    context.Billings.Where(
                        j => !j.BillingPaid)
                        .Select(j => new { j.BookingRoomJoin.Room.RoomID })
                        .ToList();
                unpaidBillRoomsList.AddRange(unpaidBillRooms.Select(r => r.RoomID));
            }
            return unpaidBillRoomsList;
        }
        //find rooms available in date range+
        //find rooms booked in date range





        //find rooms occupied between date range
        public static List<int> FindOccupiedRooms(DateTime start, DateTime end)
        {
            List<int> fullRoomsList = new List<int>();

            using (var context = new Entities())
            {
                var fullRooms =
                    context.BookingRoomJoins.Where(
                        j => j.Booking.BookingStatus != "Checked In" || j.Booking.BookingStatus != "Overdue")
                        .Where(j => j.Booking.BookingCheckedIn.Value >= start)
                        .Where(j => j.Booking.BookingCheckedOut.Value <= end)
                        .Select(j => new {j.Room.RoomID})
                        .ToList();
                fullRoomsList.AddRange(fullRooms.Select(r => r.RoomID));
            }


            return fullRoomsList;
        }
       
        public static Room ReturnRoomInformation(int roomId)
        {
            Room roomInfo=new Room();
            using (var context = new Entities())
            {
                int id = roomId;
                var query = from r in context.Rooms where r.RoomID == id select r;
                roomInfo = query.FirstOrDefault();
            }
            return roomInfo;
        }
        public static List<BookingRoomJoin> ReturnBookRoomJoinInformation(int bookingId)
        {
            List<BookingRoomJoin> bookRoomInfo = new List<BookingRoomJoin>();
            using (var context = new Entities())
            {
                int id = bookingId;
                var query = from b in context.BookingRoomJoins where b.BookingIDFK == id select b;
                bookRoomInfo = query.ToList();
            }
            return bookRoomInfo;
        }
        public static Booking ReturnBookingInformation(int bookingId)
        {
            Booking bookingInfo = new Booking();
            using (var context = new Entities())
            {
                int id = bookingId;
                var query = from b in context.Bookings where b.BookingID == id select b;
                bookingInfo = query.FirstOrDefault();
            }
            return bookingInfo;
        }
        public static Billing ReturnBillingInformation(int billingId)
        {
            Billing billingInfo = new Billing();
            using (var context = new Entities())
            {
                int id = billingId;
                var query = from r in context.Billings where r.BillingID == id select r;
                billingInfo = query.FirstOrDefault();
            }
            return billingInfo;
        }
        public static Guest ReturnGuestInformation(int guestId)
        {
            Guest guestInfo = new Guest();
            using (var context = new Entities())
            {
                int id = guestId;
                var query = from g in context.Guests where g.GuestID == id select g;
                guestInfo = query.FirstOrDefault();
            }
            return guestInfo;
        }
    }
}
