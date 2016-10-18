using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSED06_HotelDatabaseManagement.Business;
using DSED06_HotelDatabaseManagement.Data;
using DSED06_HotelDatabaseManagement.Presentation;

namespace DSED06_HotelDatabaseManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupDataGridViewSources();
            RefreshDataSources();
            FillDropDownBoxes();
            
        }


        private void btnGuestAdd_Click(object sender, EventArgs e)
        {
            if (txtGuestName.Text != "" && txtGuestAddress.Text != "" && txtGuestPhone.Text != "")
            {
                Database.AddGuest(txtGuestName.Text, txtGuestAddress.Text, txtGuestPhone.Text, txtGuestNotes.Text);
                RefreshDataSources();

            }
            else MessageBox.Show("Missing information");
        }

        private void btnGuestUpdate_Click(object sender, EventArgs e)
        {
            if (InfoPasserStatic.GuestID != -1)
            {
                InfoPasserStatic.GuestPasser.GuestName = txtGuestName.Text;
                InfoPasserStatic.GuestPasser.GuestAddress = txtGuestAddress.Text;
                InfoPasserStatic.GuestPasser.GuestTelephone = txtGuestPhone.Text;
                InfoPasserStatic.GuestPasser.GuestNotes = txtGuestNotes.Text;
                Database.UpdateGuest();
                //Database.UpdateGuest(txtGuestName.Text, txtGuestAddress.Text, txtGuestPhone.Text, txtGuestNotes.Text);
                RefreshDataSources();
            }
            else MessageBox.Show("No guest selected");
        }

        private void btnGuestSelectGuest_Click(object sender, EventArgs e)
        {
            RefreshDataSources();
        }

        private void btnBookingCreate_Click(object sender, EventArgs e)
        {
            int guestID;
            if (InfoPasserStatic.SelectedRooms.Count != 0)
            {
                if (InfoPasserStatic.GuestID == -1)
                {
                    MessageBox.Show("Select a guest");
                }
                else
                {
                    guestID = InfoPasserStatic.GuestID;
                    DateTime dateFrom = dtpStart.Value.Date;
                    DateTime dateTo = dtpEnd.Value.Date;
                    string notes = txtBookingNotes.Text;
                    int numOfGuests = Convert.ToInt32(txtBookingGuestNumber.Text);
                    Dictionary<int,int> rooms = InfoPasserStatic.SelectedRooms; //=new List<int>() {2,3,4};
                    Database.AddBooking(guestID, dateFrom, dateTo, notes, rooms,numOfGuests);
                    
                    
                    InfoPasserStatic.SelectedRooms.Clear();
                    InfoPasserStatic.SelectedRoomsOverflow.Clear();
                    // Database.CreateBookingRoomJoin(rooms);
                }
                RefreshDataSources();
            }
            else
            {
                MessageBox.Show("No Rooms Selected");
            }
        }


        //todo when guest checks in create bill for room charge. Update bill on checkout for full amount.
        private void btnRoomsSelect_Click(object sender, EventArgs e)
        {
            
            Form guestsForRoom = new GuestsForRoom();
            guestsForRoom.Show();
          // InfoPasserStatic.SelectedRooms.Add(InfoPasserStatic.RoomID,InfoPasserStatic.GuestsInRoom);
        }

        private void btnBillsCreate_Click(object sender, EventArgs e)
        {
            int booking=Convert.ToInt32(cbxBillRoomNumber.Text);
            string type=cbxBillsChargeType.Text;
            int amount=Convert.ToInt32(txtBillAmount.Text);

            Database.AddBill(booking, type, amount);
            RefreshDataSources();
        }
        private void btnBillsAddToTotal_Click(object sender, EventArgs e)
        {
            InfoPasserStatic.BillNumbers.Add(InfoPasserStatic.BillingID);
            InfoPasserStatic.BillTotal += Convert.ToInt32(InfoPasserStatic.BillPasser.BarCharge) +
                                          Convert.ToInt32(InfoPasserStatic.BillPasser.PhoneCharge) +
                                          Convert.ToInt32(InfoPasserStatic.BillPasser.RoomCharge) +
                                          Convert.ToInt32(InfoPasserStatic.BillPasser.WiFiCharge);
            lblBillsPayTotal.Text = "$"+InfoPasserStatic.BillTotal.ToString();
            //RefreshDataSources();
        }
        private void btnBillsPay_Click(object sender, EventArgs e)
        {
            foreach (var billNumber in InfoPasserStatic.BillNumbers)
            {
                GuestBilling.PayBill(billNumber);
            }
            RefreshDataSources();
            InfoPasserStatic.BillTotal = 0;
            InfoPasserStatic.BillNumbers.Clear();
            lblBillsPayTotal.Text = "$0.00";
        }
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView fakeDataGridView = sender as DataGridView;
            try
            {
                //work out which datagridview is sending the cell click
                //could be tidied into switch/cases
                switch (fakeDataGridView.Name)
                {
                    case "dgvGuests":


                        //if you are clicking on a row and not outside it
                        if (e.RowIndex >= 0)
                        {
                            //fill the text boxes with from the datatable
                            txtGuestName.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                            txtGuestAddress.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                            txtGuestPhone.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                            txtGuestNotes.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                            InfoPasserStatic.GuestID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[4].Value);
                            InfoPasserStatic.GuestPasser = Database.ReturnGuestInformation(InfoPasserStatic.GuestID);
                            //InfoPasserStatic.GuestPasser.GuestID= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[4].Value);
                            //InfoPasserStatic.GuestPasser.GuestName= fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                            //InfoPasserStatic.GuestPasser.GuestAddress= fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                            //InfoPasserStatic.GuestPasser.GuestTelephone= fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                            //InfoPasserStatic.GuestPasser.GuestNotes= fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

                        }
                        break;
                    case "dgvBilling":
                        if (e.RowIndex >= 0)
                        {
                            InfoPasserStatic.BillingID =
                                Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            InfoPasserStatic.BillPasser = Database.ReturnBillingInformation(InfoPasserStatic.BillingID);
                            //InfoPasserStatic.BillPasser.BillingID= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            //InfoPasserStatic.BillPasser.BookingRoomJoinIDFK= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[1].Value);
                            //InfoPasserStatic.BillPasser.BarCharge= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[2].Value);
                            //InfoPasserStatic.BillPasser.WiFiCharge= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[3].Value);
                            //InfoPasserStatic.BillPasser.PhoneCharge= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[4].Value);
                            //InfoPasserStatic.BillPasser.RoomCharge= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[5].Value);
                            //InfoPasserStatic.BillPasser.BillingPaid= Convert.ToBoolean(fakeDataGridView.Rows[e.RowIndex].Cells[6].Value);

                        }
                        break;
                    case "dgvBooking":
                        if (e.RowIndex >= 0)
                        {//todo get booking passer and others set up
                            InfoPasserStatic.BookingID =
                                Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            InfoPasserStatic.BookingPasser =
                                Database.ReturnBookingInformation(InfoPasserStatic.BookingID);
                            //InfoPasserStatic.BookingPasser.BookingID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            //InfoPasserStatic.BookingPasser.BookingID = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                            //InfoPasserStatic.BookingPasser.BookingID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[2].Value);
                            //InfoPasserStatic.BookingPasser.BookingID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[3].Value);
                            //InfoPasserStatic.BookingPasser.BookingID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[4].Value);
                            //InfoPasserStatic.BookingPasser.BookingID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[5].Value);
                            //InfoPasserStatic.BookingPasser.BookingID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[6].Value);
                            //InfoPasserStatic.BookingPasser.BookingID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            //InfoPasserStatic.BookingPasser.BookingID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);


                        }
                        break;
                    case "dgvRooms":
                        if (e.RowIndex >= 0)
                        {
                            InfoPasserStatic.RoomID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            InfoPasserStatic.RoomPasser = Database.ReturnRoomInformation(InfoPasserStatic.RoomID);
                            //InfoPasserStatic.RoomPasser.RoomID= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            //InfoPasserStatic.RoomPasser.RoomNumSingleBeds= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[1].Value);
                            //InfoPasserStatic.RoomPasser.RoomNumDoubleBeds= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[2].Value);
                            //InfoPasserStatic.RoomPasser.RoomBaseTariff= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[3].Value);
                            //InfoPasserStatic.RoomPasser.RoomExtraPersonRate= Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[4].Value);
                            //InfoPasserStatic.RoomPasser.RoomExtraFeatures= fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();




                        }
                        break;
                    case "dgvAdmin":
                        //Not used, here for completeness.
                        //if (e.RowIndex >= 0)
                        //{
                        //    InfoPasserStatic. = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                        //}
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetupDataGridViewSources()
        {
            Database.FakeDgvRooms = dgvRooms;
            Database.FakeDgvBilling = dgvBilling;
            Database.FakeDgvBooking = dgvBooking;
            Database.FakeDgvGuests = dgvGuests;
        }

        public void RefreshDataSources()
        {
            FillDataGridViews();
            FillDropDownBoxes();
            FillLbxRoomRate();
        }
        public void FillDataGridViews() { 

    if (!cbxFilterByDate.Checked)
            {
                
                Database.FillFakeDgvRooms();
                UnderscoreToSpaceInDgvHeaders(Database.FakeDgvRooms);

                
                Database.FillFakeDgvBilling();
                UnderscoreToSpaceInDgvHeaders(Database.FakeDgvBilling);
                
                Database.FillFakeDgvBooking();
                UnderscoreToSpaceInDgvHeaders(Database.FakeDgvBooking);
                
                Database.FillFakeDgvGuests();
                UnderscoreToSpaceInDgvHeaders(Database.FakeDgvGuests);
            }
            else
            {
                
                Database.FillFakeDgvRooms(dtpStart.Value,dtpEnd.Value);
                UnderscoreToSpaceInDgvHeaders(Database.FakeDgvRooms);

                
                Database.FillFakeDgvBilling(dtpStart.Value, dtpEnd.Value);
                UnderscoreToSpaceInDgvHeaders(Database.FakeDgvBilling);

                Database.FillFakeDgvBooking(dtpStart.Value, dtpEnd.Value);
                UnderscoreToSpaceInDgvHeaders(Database.FakeDgvBooking);

                Database.FillFakeDgvGuests();
                UnderscoreToSpaceInDgvHeaders(Database.FakeDgvGuests);
            }
        }

       
        public void CbxCheckedChangedCatcher(object sender, EventArgs e)
        {
            RefreshDataSources();
            //CheckBox fakeCheckBox = sender as CheckBox;
            //if (cbxFilterByDate.Checked)
            //{

            //}
            //else
            //{
                
            //}
        }
        public void RadioButtonCheckedChangedCatcher(object sender, EventArgs e)
        {
            RadioButton fakeRadioButton = sender as RadioButton;
            if (fakeRadioButton.Checked)
            {
                //switch (tabControl1.SelectedTab.Name)
                //{

                //    case "tabAdmin":
                //        break;
                //    case "tabBilling":
                //        break;
                //    case "tabBooking":
                //        break;
                //    case "tabGuests":
                //        break;
                //    case "tabRooms":
                //        break;
                //}
                switch (fakeRadioButton.Name)
                {
                    case "rbtBillsAll":
                        InfoPasserStatic.rbtBillingCurrentState = "All";
                        break;
                    case "rbtBillsOpen":
                        InfoPasserStatic.rbtBillingCurrentState = "Open";
                        break;
                    case "rbtBillsPay":
                        InfoPasserStatic.rbtBillingCurrentState = "Pay";
                        break;
                    case "rbtBookingFuture":
                        InfoPasserStatic.rbtBookingCurrentState = "Future";
                        break;
                    case "rbtBookingsAll":
                        InfoPasserStatic.rbtBookingCurrentState = "All";
                        break;
                    case "rbtBookingsCurrent":
                        InfoPasserStatic.rbtBookingCurrentState = "Current";
                        break;
                    case "rbtGuestsAll":
                        InfoPasserStatic.rbtGuestCurrentState = "All";
                        break;
                    case "rbtGuestsCurrent":
                        InfoPasserStatic.rbtGuestCurrentState = "Current";
                        break;
                    case "rbtGuestsPending":
                        InfoPasserStatic.rbtGuestCurrentState = "Pending";
                        break;
                    case "rbtRoomsAll":
                        InfoPasserStatic.rbtRoomCurrentState = "All";
                        break;
                    case "rbtRoomsFree":
                        InfoPasserStatic.rbtRoomCurrentState = "Free";
                        break;
                    case "rbtRoomsOccupied":
                        InfoPasserStatic.rbtRoomCurrentState = "Occupied";
                        break;
                }
                RefreshDataSources();
            }

            //change dgvs to display only info needed
        }
        public void FillDropDownBoxes()
        {
            cbxBillRoomNumber.Items.Clear();
            cbxBillingRoomNumberPaying.Items.Clear();
            //fill cbxBillRoomNumber based on currently occupied rooms
            //fill cbxBillingRoomNumberPaying based on currently occupied rooms
            foreach (var room in Database.FindOccupiedRooms())
            {
                cbxBillRoomNumber.Items.Add(room);
                
            }
            foreach (var room in Database.FindUnpaidBillRooms())
            {
                cbxBillingRoomNumberPaying.Items.Add(room);
            }
           // cbxBillRoomNumber.Items.AddRange(Database.FindFullRooms());
            
            
        }
        public void DateSelectorChanged(object sender, EventArgs e)
        {        //BUG DGV doesn't show bookings that start on selected start date. Issue with time part of datetime setting to current time, not midnight.

            DateTimePicker fakeDateTimePicker = sender as DateTimePicker;
            if (fakeDateTimePicker == dtpStart)
            {
                InfoPasserStatic.StartDate = dtpStart.Value.Date;

                if (dtpStart.Value >= dtpEnd.Value)
                {
                    dtpEnd.MinDate = dtpStart.Value.AddDays(1);
                }

            }
            if (fakeDateTimePicker == dtpEnd)
            {
                InfoPasserStatic.EndDate = dtpEnd.Value;
            }
            RefreshDataSources();
        }
        private void UnderscoreToSpaceInDgvHeaders(DataGridView dgv)
        {
            for (int counter = 0; counter < dgv.ColumnCount; counter++)
            {
                dgv.Columns[counter].HeaderText =
                    dgv.Columns[counter].HeaderText.Replace("_", " ");
            }
            
        }

        private void btnFindRooms_Click(object sender, EventArgs e)
        {
            InfoPasserStatic.NumberOfGuests = Convert.ToInt32(txtBookingGuestNumber.Text);
            tabControl1.SelectedTab = tabRooms;
            rbtRoomsFree.Checked=true;
            FillLbxRoomRate();
        }

        private void FillLbxRoomRate()
        {
            lbxRoomRate.Items.Clear();
            List<string> roomRateList=new List<string>();
            for (int i = 0; i < dgvRooms.RowCount; i++)
            {
                string thisItem ;
                //0 RoomNumber, 3 tarrif, 4 extra rate
                string room =dgvRooms.Rows[i].Cells[0].Value.ToString();
                int tarrif = Convert.ToInt32(dgvRooms.Rows[i].Cells[3].Value);
                int extra = Convert.ToInt32(dgvRooms.Rows[i].Cells[4].Value);
                int days = InfoPasserStatic.EndDate.Subtract(InfoPasserStatic.StartDate).Days;
                int rate = tarrif*days;
                // Room: *- n Days:$****
                thisItem = "Room: " + room + " for " + days + " days:$" + rate;
                roomRateList.Add(thisItem);
            }
            foreach (var item in roomRateList)
            {
                lbxRoomRate.Items.Add(item);
            }
            
        }

        private void btnCheckGuestIn_Click(object sender, EventArgs e)
        {
            RoomBooking.CheckGuestIn();
            RefreshDataSources();
        }

        private void btnCheckGuestOut_Click(object sender, EventArgs e)
        {
            RoomBooking.CheckGuestOut();
            RefreshDataSources();
        }
    }
}
