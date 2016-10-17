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
            maxGuests = baseGuests + numberOfExtras;
            overflowGuests = baseGuests - numberOfGuests;
            if (overflowGuests < 0) { overflowGuests = 0;}
        }

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
            GuestsAssigned = Convert.ToInt32(ddlNumberOfGuests.SelectedItem);
            InfoPasserStatic.GuestsInRoom = GuestsAssigned;
            InfoPasserStatic.NumberOfGuestsAssigned += GuestsAssigned;
            InfoPasserStatic.SelectedRooms.Add(InfoPasserStatic.RoomID,GuestsAssigned);
            InfoPasserStatic.SelectedRoomsOverflow.Add(InfoPasserStatic.RoomID, overflowGuests);
            MessageBox.Show(InfoPasserStatic.GuestsInRoom+ " " + InfoPasserStatic.NumberOfGuestsAssigned);
            this.Close();

        }

        private void FillDdlGuest()
        {
            int GuestNumberRemaining = InfoPasserStatic.NumberOfGuests - InfoPasserStatic.NumberOfGuestsAssigned;
            int maxToDisplay = Math.Min(GuestNumberRemaining, maxGuests);
            for (int counter = 1; counter < maxToDisplay+1; counter++)
            {
                ddlNumberOfGuests.Items.Add(counter);
            }
        }

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
