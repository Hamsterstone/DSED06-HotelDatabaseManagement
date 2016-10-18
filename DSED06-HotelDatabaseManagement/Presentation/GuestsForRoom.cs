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

namespace DSED06_HotelDatabaseManagement.Presentation
{
    //Form used to select rooms for a booking
    public partial class GuestsForRoom : Form
    {
        private static int GuestsAssigned=0;
        private int baseGuests;
        private int numberOfGuests ;
        private int numberOfSingles ;
        private int numberOfDoubles;
        private int numberOfExtras;
        private int maxGuests;
        private int overflowGuests;

        public GuestsForRoom()
        {
            InitializeComponent();
            SetVariableValues();
            FillDdlGuest();
            SetDdlDefault();
        }

        private void SetVariableValues()
        {
            numberOfGuests = InfoPasserStatic.NumberOfGuests;
            numberOfSingles = Convert.ToInt32(InfoPasserStatic.RoomPasser.RoomNumSingleBeds);
            numberOfDoubles = Convert.ToInt32(InfoPasserStatic.RoomPasser.RoomNumDoubleBeds);
            numberOfExtras = NumberOfExtraBedsAllowed();
            baseGuests = Math.Min(numberOfGuests,(numberOfDoubles*2) +numberOfSingles);
            //find the maximum number of guests allowed in the room
            maxGuests = baseGuests + numberOfExtras;
            //find the number of extra beds required
            overflowGuests = baseGuests - numberOfGuests;
            if (overflowGuests < 0) { overflowGuests = 0;}
        }
        //Finds the number of extra beds allowed based on the price (-1 = no extra beds)
        private int NumberOfExtraBedsAllowed()
        {
            if (InfoPasserStatic.RoomPasser.RoomExtraPersonRate == -1)
            {
                return 0;
            }
            else return 2;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //set information in data transfer class
            GuestsAssigned = Convert.ToInt32(ddlNumberOfGuests.SelectedItem);
            InfoPasserStatic.GuestsInRoom = GuestsAssigned;
            InfoPasserStatic.NumberOfGuestsAssigned += GuestsAssigned;
            InfoPasserStatic.SelectedRooms.Add(InfoPasserStatic.RoomID,GuestsAssigned);
            InfoPasserStatic.SelectedRoomsOverflow.Add(InfoPasserStatic.RoomID, overflowGuests);
            //pop up a message box to show what has been done
            MessageBox.Show(InfoPasserStatic.GuestsInRoom+" guests assigned to this room, " + InfoPasserStatic.NumberOfGuestsAssigned+" guests assigned total.");
            //close the form
            this.Close();

        }
        //Fills the drop down list with the numbers of possible guests in the room
        private void FillDdlGuest()
        {
            int GuestNumberRemaining = InfoPasserStatic.NumberOfGuests - InfoPasserStatic.NumberOfGuestsAssigned;
            //find the lower of the number of guests and the capacity of the room
            int maxToDisplay = Math.Min(GuestNumberRemaining, maxGuests);
            
            for (int counter = 1; counter < maxToDisplay+1; counter++)
            {
                ddlNumberOfGuests.Items.Add(counter);
            }
        }
        //set the drop down list display baseGuests(the number of guests or the capacity of the room without roll in beds
        private void SetDdlDefault()
        {
            
            int index = ddlNumberOfGuests.FindString(baseGuests.ToString());

            ddlNumberOfGuests.SelectedIndex = index;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
