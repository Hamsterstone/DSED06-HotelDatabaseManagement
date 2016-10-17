namespace DSED06_HotelDatabaseManagement.Presentation
{
    partial class GuestsForRoom
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
            this.ddlNumberOfGuests = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGuestRoomPopup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlNumberOfGuests
            // 
            this.ddlNumberOfGuests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlNumberOfGuests.FormattingEnabled = true;
            this.ddlNumberOfGuests.Location = new System.Drawing.Point(158, 111);
            this.ddlNumberOfGuests.Name = "ddlNumberOfGuests";
            this.ddlNumberOfGuests.Size = new System.Drawing.Size(112, 24);
            this.ddlNumberOfGuests.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(40, 141);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblGuestRoomPopup
            // 
            this.lblGuestRoomPopup.AutoSize = true;
            this.lblGuestRoomPopup.Location = new System.Drawing.Point(40, 30);
            this.lblGuestRoomPopup.Name = "lblGuestRoomPopup";
            this.lblGuestRoomPopup.Size = new System.Drawing.Size(120, 17);
            this.lblGuestRoomPopup.TabIndex = 3;
            this.lblGuestRoomPopup.Text = "Number of guests";
            // 
            // GuestsForRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 205);
            this.Controls.Add(this.lblGuestRoomPopup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ddlNumberOfGuests);
            this.Name = "GuestsForRoom";
            this.Text = "GuestsForRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlNumberOfGuests;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGuestRoomPopup;
    }
}