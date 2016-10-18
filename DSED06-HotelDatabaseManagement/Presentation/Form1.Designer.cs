namespace DSED06_HotelDatabaseManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.btnCheckGuestOut = new System.Windows.Forms.Button();
            this.btnCheckGuestIn = new System.Windows.Forms.Button();
            this.btnFindRooms = new System.Windows.Forms.Button();
            this.lblBookingNotes = new System.Windows.Forms.Label();
            this.txtBookingNotes = new System.Windows.Forms.TextBox();
            this.btnBookingCreate = new System.Windows.Forms.Button();
            this.lblBookingGuestNumber = new System.Windows.Forms.Label();
            this.txtBookingGuestNumber = new System.Windows.Forms.TextBox();
            this.pnlBookingRbt = new System.Windows.Forms.Panel();
            this.rbtBookingFuture = new System.Windows.Forms.RadioButton();
            this.rbtBookingsCurrent = new System.Windows.Forms.RadioButton();
            this.rbtBookingsAll = new System.Windows.Forms.RadioButton();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.lbxRoomRate = new System.Windows.Forms.ListBox();
            this.btnRoomsSelect = new System.Windows.Forms.Button();
            this.pnlRoomsRbt = new System.Windows.Forms.Panel();
            this.rbtRoomsOccupied = new System.Windows.Forms.RadioButton();
            this.rbtRoomsFree = new System.Windows.Forms.RadioButton();
            this.rbtRoomsAll = new System.Windows.Forms.RadioButton();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.tabGuests = new System.Windows.Forms.TabPage();
            this.btnGuestSelectGuest = new System.Windows.Forms.Button();
            this.pnlGuestsRbt = new System.Windows.Forms.Panel();
            this.rbtGuestsPending = new System.Windows.Forms.RadioButton();
            this.rbtGuestsCurrent = new System.Windows.Forms.RadioButton();
            this.rbtGuestsAll = new System.Windows.Forms.RadioButton();
            this.pnlGuestsData = new System.Windows.Forms.Panel();
            this.btnGuestUpdate = new System.Windows.Forms.Button();
            this.lblGuestNotes = new System.Windows.Forms.Label();
            this.btnGuestAdd = new System.Windows.Forms.Button();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuestAddress = new System.Windows.Forms.TextBox();
            this.lblGuestPhone = new System.Windows.Forms.Label();
            this.txtGuestPhone = new System.Windows.Forms.TextBox();
            this.lblGuestAddress = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestNotes = new System.Windows.Forms.TextBox();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.tabBilling = new System.Windows.Forms.TabPage();
            this.pnlBillsPaying = new System.Windows.Forms.Panel();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblPayABill = new System.Windows.Forms.Label();
            this.btnBillsAddToTotal = new System.Windows.Forms.Button();
            this.lblBillsPayTotal = new System.Windows.Forms.Label();
            this.lblBillsPayTotalLabel = new System.Windows.Forms.Label();
            this.cbxBillingRoomNumberPaying = new System.Windows.Forms.ComboBox();
            this.btnBillsPay = new System.Windows.Forms.Button();
            this.pnlBillsCreate = new System.Windows.Forms.Panel();
            this.cbxBillRoomNumber = new System.Windows.Forms.ComboBox();
            this.cbxBillsChargeType = new System.Windows.Forms.ComboBox();
            this.btnBillsCreate = new System.Windows.Forms.Button();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.pnlBillsRbt = new System.Windows.Forms.Panel();
            this.rbtBillsPay = new System.Windows.Forms.RadioButton();
            this.rbtBillsOpen = new System.Windows.Forms.RadioButton();
            this.rbtBillsAll = new System.Windows.Forms.RadioButton();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cbxFilterByDate = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.pnlBookingRbt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.tabRooms.SuspendLayout();
            this.pnlRoomsRbt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.tabGuests.SuspendLayout();
            this.pnlGuestsRbt.SuspendLayout();
            this.pnlGuestsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.tabBilling.SuspendLayout();
            this.pnlBillsPaying.SuspendLayout();
            this.pnlBillsCreate.SuspendLayout();
            this.pnlBillsRbt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBooking);
            this.tabControl1.Controls.Add(this.tabRooms);
            this.tabControl1.Controls.Add(this.tabGuests);
            this.tabControl1.Controls.Add(this.tabBilling);
            this.tabControl1.Location = new System.Drawing.Point(12, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 495);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.btnCheckGuestOut);
            this.tabBooking.Controls.Add(this.btnCheckGuestIn);
            this.tabBooking.Controls.Add(this.btnFindRooms);
            this.tabBooking.Controls.Add(this.lblBookingNotes);
            this.tabBooking.Controls.Add(this.txtBookingNotes);
            this.tabBooking.Controls.Add(this.btnBookingCreate);
            this.tabBooking.Controls.Add(this.lblBookingGuestNumber);
            this.tabBooking.Controls.Add(this.txtBookingGuestNumber);
            this.tabBooking.Controls.Add(this.pnlBookingRbt);
            this.tabBooking.Controls.Add(this.dgvBooking);
            this.tabBooking.Location = new System.Drawing.Point(4, 25);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(1150, 466);
            this.tabBooking.TabIndex = 0;
            this.tabBooking.Text = "Booking";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // btnCheckGuestOut
            // 
            this.btnCheckGuestOut.Location = new System.Drawing.Point(1027, 180);
            this.btnCheckGuestOut.Name = "btnCheckGuestOut";
            this.btnCheckGuestOut.Size = new System.Drawing.Size(117, 55);
            this.btnCheckGuestOut.TabIndex = 22;
            this.btnCheckGuestOut.Text = "Check Guest Out";
            this.btnCheckGuestOut.UseVisualStyleBackColor = true;
            this.btnCheckGuestOut.Click += new System.EventHandler(this.btnCheckGuestOut_Click);
            // 
            // btnCheckGuestIn
            // 
            this.btnCheckGuestIn.Location = new System.Drawing.Point(906, 180);
            this.btnCheckGuestIn.Name = "btnCheckGuestIn";
            this.btnCheckGuestIn.Size = new System.Drawing.Size(115, 55);
            this.btnCheckGuestIn.TabIndex = 21;
            this.btnCheckGuestIn.Text = "Check Guest In";
            this.btnCheckGuestIn.UseVisualStyleBackColor = true;
            this.btnCheckGuestIn.Click += new System.EventHandler(this.btnCheckGuestIn_Click);
            // 
            // btnFindRooms
            // 
            this.btnFindRooms.Location = new System.Drawing.Point(1013, 135);
            this.btnFindRooms.Name = "btnFindRooms";
            this.btnFindRooms.Size = new System.Drawing.Size(131, 24);
            this.btnFindRooms.TabIndex = 20;
            this.btnFindRooms.Text = "Find Rooms";
            this.btnFindRooms.UseVisualStyleBackColor = true;
            this.btnFindRooms.Click += new System.EventHandler(this.btnFindRooms_Click);
            // 
            // lblBookingNotes
            // 
            this.lblBookingNotes.AutoSize = true;
            this.lblBookingNotes.Location = new System.Drawing.Point(906, 275);
            this.lblBookingNotes.Name = "lblBookingNotes";
            this.lblBookingNotes.Size = new System.Drawing.Size(100, 17);
            this.lblBookingNotes.TabIndex = 19;
            this.lblBookingNotes.Text = "Booking Notes";
            // 
            // txtBookingNotes
            // 
            this.txtBookingNotes.Location = new System.Drawing.Point(906, 298);
            this.txtBookingNotes.Multiline = true;
            this.txtBookingNotes.Name = "txtBookingNotes";
            this.txtBookingNotes.Size = new System.Drawing.Size(238, 90);
            this.txtBookingNotes.TabIndex = 18;
            // 
            // btnBookingCreate
            // 
            this.btnBookingCreate.Location = new System.Drawing.Point(906, 394);
            this.btnBookingCreate.Name = "btnBookingCreate";
            this.btnBookingCreate.Size = new System.Drawing.Size(238, 66);
            this.btnBookingCreate.TabIndex = 17;
            this.btnBookingCreate.Text = "Create Booking";
            this.btnBookingCreate.UseVisualStyleBackColor = true;
            this.btnBookingCreate.Click += new System.EventHandler(this.btnBookingCreate_Click);
            // 
            // lblBookingGuestNumber
            // 
            this.lblBookingGuestNumber.AutoSize = true;
            this.lblBookingGuestNumber.Location = new System.Drawing.Point(906, 114);
            this.lblBookingGuestNumber.Name = "lblBookingGuestNumber";
            this.lblBookingGuestNumber.Size = new System.Drawing.Size(123, 17);
            this.lblBookingGuestNumber.TabIndex = 16;
            this.lblBookingGuestNumber.Text = "Number of Guests";
            // 
            // txtBookingGuestNumber
            // 
            this.txtBookingGuestNumber.Location = new System.Drawing.Point(906, 137);
            this.txtBookingGuestNumber.Name = "txtBookingGuestNumber";
            this.txtBookingGuestNumber.Size = new System.Drawing.Size(100, 22);
            this.txtBookingGuestNumber.TabIndex = 15;
            // 
            // pnlBookingRbt
            // 
            this.pnlBookingRbt.Controls.Add(this.rbtBookingFuture);
            this.pnlBookingRbt.Controls.Add(this.rbtBookingsCurrent);
            this.pnlBookingRbt.Controls.Add(this.rbtBookingsAll);
            this.pnlBookingRbt.Location = new System.Drawing.Point(909, 6);
            this.pnlBookingRbt.Name = "pnlBookingRbt";
            this.pnlBookingRbt.Size = new System.Drawing.Size(238, 89);
            this.pnlBookingRbt.TabIndex = 14;
            // 
            // rbtBookingFuture
            // 
            this.rbtBookingFuture.AutoSize = true;
            this.rbtBookingFuture.Location = new System.Drawing.Point(6, 59);
            this.rbtBookingFuture.Name = "rbtBookingFuture";
            this.rbtBookingFuture.Size = new System.Drawing.Size(132, 21);
            this.rbtBookingFuture.TabIndex = 2;
            this.rbtBookingFuture.TabStop = true;
            this.rbtBookingFuture.Text = "Future Bookings";
            this.rbtBookingFuture.UseVisualStyleBackColor = true;
            this.rbtBookingFuture.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // rbtBookingsCurrent
            // 
            this.rbtBookingsCurrent.AutoSize = true;
            this.rbtBookingsCurrent.Checked = true;
            this.rbtBookingsCurrent.Location = new System.Drawing.Point(6, 32);
            this.rbtBookingsCurrent.Name = "rbtBookingsCurrent";
            this.rbtBookingsCurrent.Size = new System.Drawing.Size(138, 21);
            this.rbtBookingsCurrent.TabIndex = 1;
            this.rbtBookingsCurrent.TabStop = true;
            this.rbtBookingsCurrent.Text = "Current Bookings";
            this.rbtBookingsCurrent.UseVisualStyleBackColor = true;
            this.rbtBookingsCurrent.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // rbtBookingsAll
            // 
            this.rbtBookingsAll.AutoSize = true;
            this.rbtBookingsAll.Location = new System.Drawing.Point(6, 4);
            this.rbtBookingsAll.Name = "rbtBookingsAll";
            this.rbtBookingsAll.Size = new System.Drawing.Size(106, 21);
            this.rbtBookingsAll.TabIndex = 0;
            this.rbtBookingsAll.TabStop = true;
            this.rbtBookingsAll.Text = "All Bookings";
            this.rbtBookingsAll.UseVisualStyleBackColor = true;
            this.rbtBookingsAll.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(3, 3);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.Size = new System.Drawing.Size(900, 460);
            this.dgvBooking.TabIndex = 0;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // tabRooms
            // 
            this.tabRooms.Controls.Add(this.lbxRoomRate);
            this.tabRooms.Controls.Add(this.btnRoomsSelect);
            this.tabRooms.Controls.Add(this.pnlRoomsRbt);
            this.tabRooms.Controls.Add(this.dgvRooms);
            this.tabRooms.Location = new System.Drawing.Point(4, 25);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRooms.Size = new System.Drawing.Size(1150, 466);
            this.tabRooms.TabIndex = 1;
            this.tabRooms.Text = "Rooms";
            this.tabRooms.UseVisualStyleBackColor = true;
            // 
            // lbxRoomRate
            // 
            this.lbxRoomRate.FormattingEnabled = true;
            this.lbxRoomRate.ItemHeight = 16;
            this.lbxRoomRate.Location = new System.Drawing.Point(906, 147);
            this.lbxRoomRate.Name = "lbxRoomRate";
            this.lbxRoomRate.Size = new System.Drawing.Size(238, 228);
            this.lbxRoomRate.TabIndex = 15;
            // 
            // btnRoomsSelect
            // 
            this.btnRoomsSelect.Location = new System.Drawing.Point(906, 394);
            this.btnRoomsSelect.Name = "btnRoomsSelect";
            this.btnRoomsSelect.Size = new System.Drawing.Size(238, 66);
            this.btnRoomsSelect.TabIndex = 14;
            this.btnRoomsSelect.Text = "Select Room";
            this.btnRoomsSelect.UseVisualStyleBackColor = true;
            this.btnRoomsSelect.Click += new System.EventHandler(this.btnRoomsSelect_Click);
            // 
            // pnlRoomsRbt
            // 
            this.pnlRoomsRbt.Controls.Add(this.rbtRoomsOccupied);
            this.pnlRoomsRbt.Controls.Add(this.rbtRoomsFree);
            this.pnlRoomsRbt.Controls.Add(this.rbtRoomsAll);
            this.pnlRoomsRbt.Location = new System.Drawing.Point(906, 6);
            this.pnlRoomsRbt.Name = "pnlRoomsRbt";
            this.pnlRoomsRbt.Size = new System.Drawing.Size(238, 95);
            this.pnlRoomsRbt.TabIndex = 13;
            // 
            // rbtRoomsOccupied
            // 
            this.rbtRoomsOccupied.AutoSize = true;
            this.rbtRoomsOccupied.Location = new System.Drawing.Point(4, 60);
            this.rbtRoomsOccupied.Name = "rbtRoomsOccupied";
            this.rbtRoomsOccupied.Size = new System.Drawing.Size(137, 21);
            this.rbtRoomsOccupied.TabIndex = 2;
            this.rbtRoomsOccupied.TabStop = true;
            this.rbtRoomsOccupied.Text = "Occupied Rooms";
            this.rbtRoomsOccupied.UseVisualStyleBackColor = true;
            this.rbtRoomsOccupied.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // rbtRoomsFree
            // 
            this.rbtRoomsFree.AutoSize = true;
            this.rbtRoomsFree.Checked = true;
            this.rbtRoomsFree.Location = new System.Drawing.Point(6, 32);
            this.rbtRoomsFree.Name = "rbtRoomsFree";
            this.rbtRoomsFree.Size = new System.Drawing.Size(106, 21);
            this.rbtRoomsFree.TabIndex = 1;
            this.rbtRoomsFree.TabStop = true;
            this.rbtRoomsFree.Text = "Free Rooms";
            this.rbtRoomsFree.UseVisualStyleBackColor = true;
            this.rbtRoomsFree.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // rbtRoomsAll
            // 
            this.rbtRoomsAll.AutoSize = true;
            this.rbtRoomsAll.Location = new System.Drawing.Point(6, 4);
            this.rbtRoomsAll.Name = "rbtRoomsAll";
            this.rbtRoomsAll.Size = new System.Drawing.Size(92, 21);
            this.rbtRoomsAll.TabIndex = 0;
            this.rbtRoomsAll.TabStop = true;
            this.rbtRoomsAll.Text = "All Rooms";
            this.rbtRoomsAll.UseVisualStyleBackColor = true;
            this.rbtRoomsAll.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(3, 3);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.Size = new System.Drawing.Size(900, 460);
            this.dgvRooms.TabIndex = 1;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // tabGuests
            // 
            this.tabGuests.Controls.Add(this.btnGuestSelectGuest);
            this.tabGuests.Controls.Add(this.pnlGuestsRbt);
            this.tabGuests.Controls.Add(this.pnlGuestsData);
            this.tabGuests.Controls.Add(this.dgvGuests);
            this.tabGuests.Location = new System.Drawing.Point(4, 25);
            this.tabGuests.Name = "tabGuests";
            this.tabGuests.Size = new System.Drawing.Size(1150, 466);
            this.tabGuests.TabIndex = 2;
            this.tabGuests.Text = "Guests";
            this.tabGuests.UseVisualStyleBackColor = true;
            // 
            // btnGuestSelectGuest
            // 
            this.btnGuestSelectGuest.Location = new System.Drawing.Point(906, 394);
            this.btnGuestSelectGuest.Name = "btnGuestSelectGuest";
            this.btnGuestSelectGuest.Size = new System.Drawing.Size(238, 66);
            this.btnGuestSelectGuest.TabIndex = 15;
            this.btnGuestSelectGuest.Text = "Select Guest";
            this.btnGuestSelectGuest.UseVisualStyleBackColor = true;
            this.btnGuestSelectGuest.Click += new System.EventHandler(this.btnGuestSelectGuest_Click);
            // 
            // pnlGuestsRbt
            // 
            this.pnlGuestsRbt.Controls.Add(this.rbtGuestsPending);
            this.pnlGuestsRbt.Controls.Add(this.rbtGuestsCurrent);
            this.pnlGuestsRbt.Controls.Add(this.rbtGuestsAll);
            this.pnlGuestsRbt.Location = new System.Drawing.Point(906, 4);
            this.pnlGuestsRbt.Name = "pnlGuestsRbt";
            this.pnlGuestsRbt.Size = new System.Drawing.Size(238, 85);
            this.pnlGuestsRbt.TabIndex = 12;
            // 
            // rbtGuestsPending
            // 
            this.rbtGuestsPending.AutoSize = true;
            this.rbtGuestsPending.Location = new System.Drawing.Point(4, 60);
            this.rbtGuestsPending.Name = "rbtGuestsPending";
            this.rbtGuestsPending.Size = new System.Drawing.Size(81, 21);
            this.rbtGuestsPending.TabIndex = 2;
            this.rbtGuestsPending.TabStop = true;
            this.rbtGuestsPending.Text = "Pending";
            this.rbtGuestsPending.UseVisualStyleBackColor = true;
            this.rbtGuestsPending.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // rbtGuestsCurrent
            // 
            this.rbtGuestsCurrent.AutoSize = true;
            this.rbtGuestsCurrent.Checked = true;
            this.rbtGuestsCurrent.Location = new System.Drawing.Point(6, 32);
            this.rbtGuestsCurrent.Name = "rbtGuestsCurrent";
            this.rbtGuestsCurrent.Size = new System.Drawing.Size(76, 21);
            this.rbtGuestsCurrent.TabIndex = 1;
            this.rbtGuestsCurrent.TabStop = true;
            this.rbtGuestsCurrent.Text = "Current";
            this.rbtGuestsCurrent.UseVisualStyleBackColor = true;
            this.rbtGuestsCurrent.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // rbtGuestsAll
            // 
            this.rbtGuestsAll.AutoSize = true;
            this.rbtGuestsAll.Location = new System.Drawing.Point(6, 4);
            this.rbtGuestsAll.Name = "rbtGuestsAll";
            this.rbtGuestsAll.Size = new System.Drawing.Size(93, 21);
            this.rbtGuestsAll.TabIndex = 0;
            this.rbtGuestsAll.TabStop = true;
            this.rbtGuestsAll.Text = "All Guests";
            this.rbtGuestsAll.UseVisualStyleBackColor = true;
            this.rbtGuestsAll.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // pnlGuestsData
            // 
            this.pnlGuestsData.Controls.Add(this.btnGuestUpdate);
            this.pnlGuestsData.Controls.Add(this.lblGuestNotes);
            this.pnlGuestsData.Controls.Add(this.btnGuestAdd);
            this.pnlGuestsData.Controls.Add(this.txtGuestName);
            this.pnlGuestsData.Controls.Add(this.txtGuestAddress);
            this.pnlGuestsData.Controls.Add(this.lblGuestPhone);
            this.pnlGuestsData.Controls.Add(this.txtGuestPhone);
            this.pnlGuestsData.Controls.Add(this.lblGuestAddress);
            this.pnlGuestsData.Controls.Add(this.lblGuestName);
            this.pnlGuestsData.Controls.Add(this.txtGuestNotes);
            this.pnlGuestsData.Location = new System.Drawing.Point(906, 95);
            this.pnlGuestsData.Name = "pnlGuestsData";
            this.pnlGuestsData.Size = new System.Drawing.Size(238, 296);
            this.pnlGuestsData.TabIndex = 11;
            // 
            // btnGuestUpdate
            // 
            this.btnGuestUpdate.Location = new System.Drawing.Point(94, 269);
            this.btnGuestUpdate.Name = "btnGuestUpdate";
            this.btnGuestUpdate.Size = new System.Drawing.Size(72, 23);
            this.btnGuestUpdate.TabIndex = 13;
            this.btnGuestUpdate.Text = "Update";
            this.btnGuestUpdate.UseVisualStyleBackColor = true;
            this.btnGuestUpdate.Click += new System.EventHandler(this.btnGuestUpdate_Click);
            // 
            // lblGuestNotes
            // 
            this.lblGuestNotes.AutoSize = true;
            this.lblGuestNotes.Location = new System.Drawing.Point(3, 147);
            this.lblGuestNotes.Name = "lblGuestNotes";
            this.lblGuestNotes.Size = new System.Drawing.Size(45, 17);
            this.lblGuestNotes.TabIndex = 10;
            this.lblGuestNotes.Text = "Notes";
            // 
            // btnGuestAdd
            // 
            this.btnGuestAdd.Location = new System.Drawing.Point(6, 269);
            this.btnGuestAdd.Name = "btnGuestAdd";
            this.btnGuestAdd.Size = new System.Drawing.Size(85, 23);
            this.btnGuestAdd.TabIndex = 12;
            this.btnGuestAdd.Text = "Add Guest";
            this.btnGuestAdd.UseVisualStyleBackColor = true;
            this.btnGuestAdd.Click += new System.EventHandler(this.btnGuestAdd_Click);
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(6, 30);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(229, 22);
            this.txtGuestName.TabIndex = 1;
            // 
            // txtGuestAddress
            // 
            this.txtGuestAddress.Location = new System.Drawing.Point(6, 75);
            this.txtGuestAddress.Name = "txtGuestAddress";
            this.txtGuestAddress.Size = new System.Drawing.Size(229, 22);
            this.txtGuestAddress.TabIndex = 2;
            // 
            // lblGuestPhone
            // 
            this.lblGuestPhone.AutoSize = true;
            this.lblGuestPhone.Location = new System.Drawing.Point(3, 100);
            this.lblGuestPhone.Name = "lblGuestPhone";
            this.lblGuestPhone.Size = new System.Drawing.Size(49, 17);
            this.lblGuestPhone.TabIndex = 8;
            this.lblGuestPhone.Text = "Phone";
            // 
            // txtGuestPhone
            // 
            this.txtGuestPhone.Location = new System.Drawing.Point(6, 120);
            this.txtGuestPhone.Name = "txtGuestPhone";
            this.txtGuestPhone.Size = new System.Drawing.Size(229, 22);
            this.txtGuestPhone.TabIndex = 3;
            // 
            // lblGuestAddress
            // 
            this.lblGuestAddress.AutoSize = true;
            this.lblGuestAddress.Location = new System.Drawing.Point(3, 55);
            this.lblGuestAddress.Name = "lblGuestAddress";
            this.lblGuestAddress.Size = new System.Drawing.Size(60, 17);
            this.lblGuestAddress.TabIndex = 7;
            this.lblGuestAddress.Text = "Address";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(3, 10);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(45, 17);
            this.lblGuestName.TabIndex = 6;
            this.lblGuestName.Text = "Name";
            // 
            // txtGuestNotes
            // 
            this.txtGuestNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGuestNotes.Location = new System.Drawing.Point(6, 167);
            this.txtGuestNotes.Multiline = true;
            this.txtGuestNotes.Name = "txtGuestNotes";
            this.txtGuestNotes.Size = new System.Drawing.Size(229, 96);
            this.txtGuestNotes.TabIndex = 5;
            // 
            // dgvGuests
            // 
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(3, 3);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowTemplate.Height = 24;
            this.dgvGuests.Size = new System.Drawing.Size(900, 460);
            this.dgvGuests.TabIndex = 0;
            this.dgvGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // tabBilling
            // 
            this.tabBilling.Controls.Add(this.pnlBillsPaying);
            this.tabBilling.Controls.Add(this.pnlBillsCreate);
            this.tabBilling.Controls.Add(this.pnlBillsRbt);
            this.tabBilling.Controls.Add(this.dgvBilling);
            this.tabBilling.Location = new System.Drawing.Point(4, 25);
            this.tabBilling.Name = "tabBilling";
            this.tabBilling.Size = new System.Drawing.Size(1150, 466);
            this.tabBilling.TabIndex = 3;
            this.tabBilling.Text = "Billing";
            this.tabBilling.UseVisualStyleBackColor = true;
            // 
            // pnlBillsPaying
            // 
            this.pnlBillsPaying.Controls.Add(this.lblRoomNumber);
            this.pnlBillsPaying.Controls.Add(this.lblPayABill);
            this.pnlBillsPaying.Controls.Add(this.btnBillsAddToTotal);
            this.pnlBillsPaying.Controls.Add(this.lblBillsPayTotal);
            this.pnlBillsPaying.Controls.Add(this.lblBillsPayTotalLabel);
            this.pnlBillsPaying.Controls.Add(this.cbxBillingRoomNumberPaying);
            this.pnlBillsPaying.Controls.Add(this.btnBillsPay);
            this.pnlBillsPaying.Location = new System.Drawing.Point(906, 258);
            this.pnlBillsPaying.Name = "pnlBillsPaying";
            this.pnlBillsPaying.Size = new System.Drawing.Size(238, 188);
            this.pnlBillsPaying.TabIndex = 21;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(3, 38);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(45, 17);
            this.lblRoomNumber.TabIndex = 25;
            this.lblRoomNumber.Text = "Room";
            // 
            // lblPayABill
            // 
            this.lblPayABill.AutoSize = true;
            this.lblPayABill.Location = new System.Drawing.Point(3, 15);
            this.lblPayABill.Name = "lblPayABill";
            this.lblPayABill.Size = new System.Drawing.Size(66, 17);
            this.lblPayABill.TabIndex = 24;
            this.lblPayABill.Text = "Pay a Bill";
            // 
            // btnBillsAddToTotal
            // 
            this.btnBillsAddToTotal.Location = new System.Drawing.Point(0, 68);
            this.btnBillsAddToTotal.Name = "btnBillsAddToTotal";
            this.btnBillsAddToTotal.Size = new System.Drawing.Size(106, 29);
            this.btnBillsAddToTotal.TabIndex = 23;
            this.btnBillsAddToTotal.Text = "Add To Total";
            this.btnBillsAddToTotal.UseVisualStyleBackColor = true;
            this.btnBillsAddToTotal.Click += new System.EventHandler(this.btnBillsAddToTotal_Click);
            // 
            // lblBillsPayTotal
            // 
            this.lblBillsPayTotal.Location = new System.Drawing.Point(61, 100);
            this.lblBillsPayTotal.Name = "lblBillsPayTotal";
            this.lblBillsPayTotal.Size = new System.Drawing.Size(100, 23);
            this.lblBillsPayTotal.TabIndex = 22;
            // 
            // lblBillsPayTotalLabel
            // 
            this.lblBillsPayTotalLabel.AutoSize = true;
            this.lblBillsPayTotalLabel.Location = new System.Drawing.Point(3, 100);
            this.lblBillsPayTotalLabel.Name = "lblBillsPayTotalLabel";
            this.lblBillsPayTotalLabel.Size = new System.Drawing.Size(40, 17);
            this.lblBillsPayTotalLabel.TabIndex = 21;
            this.lblBillsPayTotalLabel.Text = "Total";
            // 
            // cbxBillingRoomNumberPaying
            // 
            this.cbxBillingRoomNumberPaying.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBillingRoomNumberPaying.FormattingEnabled = true;
            this.cbxBillingRoomNumberPaying.Location = new System.Drawing.Point(87, 38);
            this.cbxBillingRoomNumberPaying.Name = "cbxBillingRoomNumberPaying";
            this.cbxBillingRoomNumberPaying.Size = new System.Drawing.Size(145, 24);
            this.cbxBillingRoomNumberPaying.TabIndex = 20;
            // 
            // btnBillsPay
            // 
            this.btnBillsPay.Location = new System.Drawing.Point(3, 130);
            this.btnBillsPay.Name = "btnBillsPay";
            this.btnBillsPay.Size = new System.Drawing.Size(232, 55);
            this.btnBillsPay.TabIndex = 19;
            this.btnBillsPay.Text = "Pay Bill";
            this.btnBillsPay.UseVisualStyleBackColor = true;
            this.btnBillsPay.Click += new System.EventHandler(this.btnBillsPay_Click);
            // 
            // pnlBillsCreate
            // 
            this.pnlBillsCreate.Controls.Add(this.cbxBillRoomNumber);
            this.pnlBillsCreate.Controls.Add(this.cbxBillsChargeType);
            this.pnlBillsCreate.Controls.Add(this.btnBillsCreate);
            this.pnlBillsCreate.Controls.Add(this.txtBillAmount);
            this.pnlBillsCreate.Location = new System.Drawing.Point(906, 101);
            this.pnlBillsCreate.Name = "pnlBillsCreate";
            this.pnlBillsCreate.Size = new System.Drawing.Size(238, 151);
            this.pnlBillsCreate.TabIndex = 20;
            // 
            // cbxBillRoomNumber
            // 
            this.cbxBillRoomNumber.AllowDrop = true;
            this.cbxBillRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBillRoomNumber.FormattingEnabled = true;
            this.cbxBillRoomNumber.Location = new System.Drawing.Point(3, 3);
            this.cbxBillRoomNumber.Name = "cbxBillRoomNumber";
            this.cbxBillRoomNumber.Size = new System.Drawing.Size(232, 24);
            this.cbxBillRoomNumber.TabIndex = 15;
            // 
            // cbxBillsChargeType
            // 
            this.cbxBillsChargeType.AllowDrop = true;
            this.cbxBillsChargeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBillsChargeType.FormattingEnabled = true;
            this.cbxBillsChargeType.Items.AddRange(new object[] {
            "Bar",
            "Phone",
            "Room",
            "WiFi"});
            this.cbxBillsChargeType.Location = new System.Drawing.Point(3, 34);
            this.cbxBillsChargeType.Name = "cbxBillsChargeType";
            this.cbxBillsChargeType.Size = new System.Drawing.Size(232, 24);
            this.cbxBillsChargeType.TabIndex = 16;
            // 
            // btnBillsCreate
            // 
            this.btnBillsCreate.Location = new System.Drawing.Point(3, 91);
            this.btnBillsCreate.Name = "btnBillsCreate";
            this.btnBillsCreate.Size = new System.Drawing.Size(232, 55);
            this.btnBillsCreate.TabIndex = 18;
            this.btnBillsCreate.Text = "Create Bill";
            this.btnBillsCreate.UseVisualStyleBackColor = true;
            this.btnBillsCreate.Click += new System.EventHandler(this.btnBillsCreate_Click);
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(3, 63);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(232, 22);
            this.txtBillAmount.TabIndex = 17;
            // 
            // pnlBillsRbt
            // 
            this.pnlBillsRbt.Controls.Add(this.rbtBillsPay);
            this.pnlBillsRbt.Controls.Add(this.rbtBillsOpen);
            this.pnlBillsRbt.Controls.Add(this.rbtBillsAll);
            this.pnlBillsRbt.Location = new System.Drawing.Point(906, 0);
            this.pnlBillsRbt.Name = "pnlBillsRbt";
            this.pnlBillsRbt.Size = new System.Drawing.Size(238, 95);
            this.pnlBillsRbt.TabIndex = 14;
            // 
            // rbtBillsPay
            // 
            this.rbtBillsPay.AutoSize = true;
            this.rbtBillsPay.Location = new System.Drawing.Point(4, 60);
            this.rbtBillsPay.Name = "rbtBillsPay";
            this.rbtBillsPay.Size = new System.Drawing.Size(75, 21);
            this.rbtBillsPay.TabIndex = 2;
            this.rbtBillsPay.TabStop = true;
            this.rbtBillsPay.Text = "Pay Bill";
            this.rbtBillsPay.UseVisualStyleBackColor = true;
            this.rbtBillsPay.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // rbtBillsOpen
            // 
            this.rbtBillsOpen.AutoSize = true;
            this.rbtBillsOpen.Checked = true;
            this.rbtBillsOpen.Location = new System.Drawing.Point(6, 32);
            this.rbtBillsOpen.Name = "rbtBillsOpen";
            this.rbtBillsOpen.Size = new System.Drawing.Size(93, 21);
            this.rbtBillsOpen.TabIndex = 1;
            this.rbtBillsOpen.TabStop = true;
            this.rbtBillsOpen.Text = "Open Bills";
            this.rbtBillsOpen.UseVisualStyleBackColor = true;
            this.rbtBillsOpen.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // rbtBillsAll
            // 
            this.rbtBillsAll.AutoSize = true;
            this.rbtBillsAll.Location = new System.Drawing.Point(6, 4);
            this.rbtBillsAll.Name = "rbtBillsAll";
            this.rbtBillsAll.Size = new System.Drawing.Size(73, 21);
            this.rbtBillsAll.TabIndex = 0;
            this.rbtBillsAll.TabStop = true;
            this.rbtBillsAll.Text = "All Bills";
            this.rbtBillsAll.UseVisualStyleBackColor = true;
            this.rbtBillsAll.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChangedCatcher);
            // 
            // dgvBilling
            // 
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Location = new System.Drawing.Point(3, 3);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.RowTemplate.Height = 24;
            this.dgvBilling.Size = new System.Drawing.Size(900, 460);
            this.dgvBilling.TabIndex = 0;
            this.dgvBilling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(474, 62);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(250, 22);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.ValueChanged += new System.EventHandler(this.DateSelectorChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(730, 62);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(250, 22);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.DateSelectorChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(471, 42);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 17);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(727, 42);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(67, 17);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date";
            // 
            // cbxFilterByDate
            // 
            this.cbxFilterByDate.AutoSize = true;
            this.cbxFilterByDate.Location = new System.Drawing.Point(986, 62);
            this.cbxFilterByDate.Name = "cbxFilterByDate";
            this.cbxFilterByDate.Size = new System.Drawing.Size(112, 21);
            this.cbxFilterByDate.TabIndex = 8;
            this.cbxFilterByDate.Text = "Filter by date";
            this.cbxFilterByDate.UseVisualStyleBackColor = true;
            this.cbxFilterByDate.CheckedChanged += new System.EventHandler(this.CbxCheckedChangedCatcher);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 726);
            this.Controls.Add(this.cbxFilterByDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabBooking.ResumeLayout(false);
            this.tabBooking.PerformLayout();
            this.pnlBookingRbt.ResumeLayout(false);
            this.pnlBookingRbt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.tabRooms.ResumeLayout(false);
            this.pnlRoomsRbt.ResumeLayout(false);
            this.pnlRoomsRbt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.tabGuests.ResumeLayout(false);
            this.pnlGuestsRbt.ResumeLayout(false);
            this.pnlGuestsRbt.PerformLayout();
            this.pnlGuestsData.ResumeLayout(false);
            this.pnlGuestsData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.tabBilling.ResumeLayout(false);
            this.pnlBillsPaying.ResumeLayout(false);
            this.pnlBillsPaying.PerformLayout();
            this.pnlBillsCreate.ResumeLayout(false);
            this.pnlBillsCreate.PerformLayout();
            this.pnlBillsRbt.ResumeLayout(false);
            this.pnlBillsRbt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.TabPage tabGuests;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.TabPage tabBilling;
        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private System.Windows.Forms.TextBox txtGuestPhone;
        private System.Windows.Forms.TextBox txtGuestAddress;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Panel pnlGuestsData;
        private System.Windows.Forms.Label lblGuestNotes;
        private System.Windows.Forms.Label lblGuestPhone;
        private System.Windows.Forms.Label lblGuestAddress;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestNotes;
        private System.Windows.Forms.Panel pnlGuestsRbt;
        private System.Windows.Forms.RadioButton rbtGuestsPending;
        private System.Windows.Forms.RadioButton rbtGuestsCurrent;
        private System.Windows.Forms.RadioButton rbtGuestsAll;
        private System.Windows.Forms.Button btnGuestUpdate;
        private System.Windows.Forms.Button btnGuestAdd;
        private System.Windows.Forms.Panel pnlRoomsRbt;
        private System.Windows.Forms.RadioButton rbtRoomsOccupied;
        private System.Windows.Forms.RadioButton rbtRoomsFree;
        private System.Windows.Forms.RadioButton rbtRoomsAll;
        private System.Windows.Forms.Panel pnlBookingRbt;
        private System.Windows.Forms.RadioButton rbtBookingFuture;
        private System.Windows.Forms.RadioButton rbtBookingsCurrent;
        private System.Windows.Forms.RadioButton rbtBookingsAll;
        private System.Windows.Forms.Button btnBookingCreate;
        private System.Windows.Forms.Label lblBookingGuestNumber;
        private System.Windows.Forms.TextBox txtBookingGuestNumber;
        private System.Windows.Forms.Button btnRoomsSelect;
        private System.Windows.Forms.ComboBox cbxBillsChargeType;
        private System.Windows.Forms.ComboBox cbxBillRoomNumber;
        private System.Windows.Forms.Panel pnlBillsRbt;
        private System.Windows.Forms.RadioButton rbtBillsPay;
        private System.Windows.Forms.RadioButton rbtBillsOpen;
        private System.Windows.Forms.RadioButton rbtBillsAll;
        private System.Windows.Forms.Panel pnlBillsCreate;
        private System.Windows.Forms.Button btnBillsCreate;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Button btnBillsPay;
        private System.Windows.Forms.Button btnGuestSelectGuest;
        private System.Windows.Forms.Panel pnlBillsPaying;
        private System.Windows.Forms.Label lblBillsPayTotal;
        private System.Windows.Forms.Label lblBillsPayTotalLabel;
        private System.Windows.Forms.ComboBox cbxBillingRoomNumberPaying;
        private System.Windows.Forms.Button btnBillsAddToTotal;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblBookingNotes;
        private System.Windows.Forms.TextBox txtBookingNotes;
        private System.Windows.Forms.Button btnFindRooms;
        private System.Windows.Forms.Button btnCheckGuestOut;
        private System.Windows.Forms.Button btnCheckGuestIn;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblPayABill;
        private System.Windows.Forms.CheckBox cbxFilterByDate;
        private System.Windows.Forms.ListBox lbxRoomRate;
    }
}

