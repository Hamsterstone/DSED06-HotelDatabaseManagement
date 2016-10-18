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
            //check textboxes for non-nullable fields are not empty
            if (txtGuestName.Text != "" && txtGuestAddress.Text != "" && txtGuestPhone.Text != "")
            {
                //add the guest information to a new guest in the database 
                Database.AddGuest(txtGuestName.Text, txtGuestAddress.Text, txtGuestPhone.Text, txtGuestNotes.Text);
                //update the form data sources
                RefreshDataSources();

            }
            else MessageBox.Show("Missing information");
        }

        private void btnGuestUpdate_Click(object sender, EventArgs e)
        {
            //check a guest is selected
            if (InfoPasserStatic.GuestID != -1)
            {
                //update data transfer class information
                InfoPasserStatic.GuestPasser.GuestName = txtGuestName.Text;
                InfoPasserStatic.GuestPasser.GuestAddress = txtGuestAddress.Text;
                InfoPasserStatic.GuestPasser.GuestTelephone = txtGuestPhone.Text;
                InfoPasserStatic.GuestPasser.GuestNotes = txtGuestNotes.Text;
                //update the guest information
                Database.UpdateGuest();
                //update the form data sources
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
                    Dictionary<int,int> rooms = InfoPasserStatic.SelectedRooms; 
                    Database.AddBooking(guestID, dateFrom, dateTo, notes, rooms,numOfGuests);
                    
                    //reset data transfer class fields
                    InfoPasserStatic.SelectedRooms.Clear();
                    InfoPasserStatic.SelectedRoomsOverflow.Clear();
                    
                }
                RefreshDataSources();
            }
            else
            {
                MessageBox.Show("No Rooms Selected");
            }
        }


        
        private void btnRoomsSelect_Click(object sender, EventArgs e)
        {
            //pops up a new form to select rooms for guests
            Form guestsForRoom = new GuestsForRoom();
            guestsForRoom.Show();
        }
        //creates a new bill from input data
        private void btnBillsCreate_Click(object sender, EventArgs e)
        {
            int booking=Convert.ToInt32(cbxBillRoomNumber.Text);
            string type=cbxBillsChargeType.Text;
            int amount=Convert.ToInt32(txtBillAmount.Text);

            Database.AddBill(booking, type, amount);
            RefreshDataSources();
        }
        //used to total up bills before paying
        private void btnBillsAddToTotal_Click(object sender, EventArgs e)
        {
            InfoPasserStatic.BillNumbers.Add(InfoPasserStatic.BillingID);
            InfoPasserStatic.BillTotal += Convert.ToInt32(InfoPasserStatic.BillPasser.BarCharge) +
                                          Convert.ToInt32(InfoPasserStatic.BillPasser.PhoneCharge) +
                                          Convert.ToInt32(InfoPasserStatic.BillPasser.RoomCharge) +
                                          Convert.ToInt32(InfoPasserStatic.BillPasser.WiFiCharge);
            lblBillsPayTotal.Text = "$"+InfoPasserStatic.BillTotal.ToString();
            
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
                switch (fakeDataGridView.Name)
                {
                    case "dgvGuests":


                        //if you are clicking on a row and not outside it
                        if (e.RowIndex >= 0)
                        {
                            //fill the text boxes from the datatable
                            txtGuestName.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                            txtGuestAddress.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                            txtGuestPhone.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                            txtGuestNotes.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                            //put the guest info into the data transfer class
                            InfoPasserStatic.GuestID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[4].Value);
                            InfoPasserStatic.GuestPasser = Database.ReturnGuestInformation(InfoPasserStatic.GuestID);

                        }
                        break;
                    case "dgvBilling":
                        if (e.RowIndex >= 0)
                        {
                            InfoPasserStatic.BillingID =
                                Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            InfoPasserStatic.BillPasser = Database.ReturnBillingInformation(InfoPasserStatic.BillingID);

                        }
                        break;
                    case "dgvBooking":
                        if (e.RowIndex >= 0)
                        {
//todo get booking passer and others set up
                            InfoPasserStatic.BookingID =
                                Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            InfoPasserStatic.BookingPasser =
                                Database.ReturnBookingInformation(InfoPasserStatic.BookingID);


                        }
                        break;
                    case "dgvRooms":
                        if (e.RowIndex >= 0)
                        {
                            InfoPasserStatic.RoomID = Convert.ToInt32(fakeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                            InfoPasserStatic.RoomPasser = Database.ReturnRoomInformation(InfoPasserStatic.RoomID);

                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Sets datagridview sources to fake datagridviews supplied in the database class
        private void SetupDataGridViewSources()
        {
            Database.FakeDgvRooms = dgvRooms;
            Database.FakeDgvBilling = dgvBilling;
            Database.FakeDgvBooking = dgvBooking;
            Database.FakeDgvGuests = dgvGuests;
        }
        //called to update data sources on the form
        public void RefreshDataSources()
        {
            FillDataGridViews();
            FillDropDownBoxes();
            FillLbxRoomRate();
        }

        public void FillDataGridViews()
        {
            
            if (!cbxFilterByDate.Checked)
            {//selects datasources not filtered by date
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
                //selects datasources filtered by dates
                Database.FillFakeDgvRooms(dtpStart.Value, dtpEnd.Value);
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
            //this method only needs to update datasources because the checkbox is looked at by the FillDataGridViews method
            RefreshDataSources();
           }
        public void RadioButtonCheckedChangedCatcher(object sender, EventArgs e)
        {
            RadioButton fakeRadioButton = sender as RadioButton;
            
            if (fakeRadioButton.Checked)
            {
               
                switch (fakeRadioButton.Name)
                {
                    //updates the data transfer class radiobutton fields
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
            
        }
        public void FillDropDownBoxes()
        {
            //reset drop down boxes
            cbxBillRoomNumber.Items.Clear();
            cbxBillingRoomNumberPaying.Items.Clear();
            //fill cbxBillRoomNumber based on currently occupied rooms
            
            foreach (var room in Database.FindOccupiedRooms())
            {
                cbxBillRoomNumber.Items.Add(room);
                
            }
            //fill cbxBillingRoomNumberPaying based on currently occupied rooms
            foreach (var room in Database.FindUnpaidBillRooms())
            {
                cbxBillingRoomNumberPaying.Items.Add(room);
            }
           
        }
        public void DateSelectorChanged(object sender, EventArgs e)
        {        //BUG DGV doesn't show bookings that start on selected start date. Issue with time part of datetime setting to current time, not midnight.

            DateTimePicker fakeDateTimePicker = sender as DateTimePicker;
            if (fakeDateTimePicker == dtpStart)
            {
                //update the data transfer class
                InfoPasserStatic.StartDate = dtpStart.Value.Date;
                //don't allow the end date to be before the start date
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

        //Removes underscores in column heading names for better readability
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
                //Cell[0] RoomNumber, [3] tarrif
                string room =dgvRooms.Rows[i].Cells[0].Value.ToString();
                int tarrif = Convert.ToInt32(dgvRooms.Rows[i].Cells[3].Value);
                //Number of days selected
                int days = InfoPasserStatic.EndDate.Subtract(InfoPasserStatic.StartDate).Days;
                //calculate the room tarrif for the number of days
                int rate = tarrif*days;
                //Build the display string
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
