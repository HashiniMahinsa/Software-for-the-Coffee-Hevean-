
namespace coffeeHeven
{
    partial class Booking
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
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_booking = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_contact_number = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.link_need_help = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(36, 63);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(447, 160);
            this.DateTimePicker.TabIndex = 0;
            this.DateTimePicker.Value = new System.DateTime(2022, 10, 11, 1, 47, 36, 388);
            // 
            // btn_booking
            // 
            this.btn_booking.AutoRoundedCorners = true;
            this.btn_booking.BorderRadius = 21;
            this.btn_booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_booking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_booking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_booking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_booking.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_booking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_booking.FillColor = System.Drawing.Color.Black;
            this.btn_booking.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn_booking.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_booking.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_booking.ForeColor = System.Drawing.Color.White;
            this.btn_booking.Location = new System.Drawing.Point(128, 383);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(210, 45);
            this.btn_booking.TabIndex = 13;
            this.btn_booking.Text = "Confirm booking";
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::coffeeHeven.Properties.Resources._6ug3jw;
            this.pictureBox2.Location = new System.Drawing.Point(515, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // txt_contact_number
            // 
            this.txt_contact_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contact_number.DefaultText = "";
            this.txt_contact_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_contact_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_contact_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_contact_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_contact_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_contact_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_contact_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_contact_number.Location = new System.Drawing.Point(36, 290);
            this.txt_contact_number.Name = "txt_contact_number";
            this.txt_contact_number.PasswordChar = '\0';
            this.txt_contact_number.PlaceholderText = "";
            this.txt_contact_number.SelectedText = "";
            this.txt_contact_number.Size = new System.Drawing.Size(380, 36);
            this.txt_contact_number.TabIndex = 15;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(36, 28);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(87, 22);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Select Date";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(36, 257);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(191, 22);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "Enter your contact number";
            // 
            // link_need_help
            // 
            this.link_need_help.ActiveLinkColor = System.Drawing.Color.White;
            this.link_need_help.AutoSize = true;
            this.link_need_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.link_need_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_need_help.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_need_help.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.link_need_help.Location = new System.Drawing.Point(511, 458);
            this.link_need_help.Name = "link_need_help";
            this.link_need_help.Size = new System.Drawing.Size(217, 20);
            this.link_need_help.TabIndex = 19;
            this.link_need_help.TabStop = true;
            this.link_need_help.Text = "Do you need help? Please ask!";
            this.link_need_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_need_help_LinkClicked);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(154)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.link_need_help);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_contact_number);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_booking);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2GradientButton btn_booking;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txt_contact_number;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.LinkLabel link_need_help;
    }
}