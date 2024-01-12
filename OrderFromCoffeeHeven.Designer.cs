
namespace coffeeHeven
{
    partial class OrderFromCoffeeHeven
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_tap_to_place_order = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 462);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(940, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::coffeeHeven.Properties.Resources._1000_F_218211127_XoRi1fGsABlvbl9Y26Q0DvMuUJQv8zdV5;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(346, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 377);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_tap_to_place_order
            // 
            this.btn_tap_to_place_order.AutoRoundedCorners = true;
            this.btn_tap_to_place_order.BorderRadius = 21;
            this.btn_tap_to_place_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tap_to_place_order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tap_to_place_order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tap_to_place_order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tap_to_place_order.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tap_to_place_order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tap_to_place_order.FillColor = System.Drawing.Color.Black;
            this.btn_tap_to_place_order.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn_tap_to_place_order.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_tap_to_place_order.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_tap_to_place_order.ForeColor = System.Drawing.Color.White;
            this.btn_tap_to_place_order.Location = new System.Drawing.Point(362, 411);
            this.btn_tap_to_place_order.Name = "btn_tap_to_place_order";
            this.btn_tap_to_place_order.Size = new System.Drawing.Size(210, 45);
            this.btn_tap_to_place_order.TabIndex = 4;
            this.btn_tap_to_place_order.Text = "Tap to Place order";
            this.btn_tap_to_place_order.Click += new System.EventHandler(this.btn_tap_to_place_order_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.pictureBox2.Location = new System.Drawing.Point(334, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 401);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // OrderFromCoffeeHeven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::coffeeHeven.Properties.Resources.international_coffee_day_163301550216x9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.btn_tap_to_place_order);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "OrderFromCoffeeHeven";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderFromCoffeeHeven";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_tap_to_place_order;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}