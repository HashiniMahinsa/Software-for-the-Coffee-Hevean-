
namespace coffeeHeven
{
    partial class AdminWelcome
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
            this.btn_welcome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_view_reservations = new System.Windows.Forms.Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_welcome
            // 
            this.btn_welcome.BackgroundImage = global::coffeeHeven.Properties.Resources.arabica_coffee_beans_500x500;
            this.btn_welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_welcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_welcome.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_welcome.ForeColor = System.Drawing.Color.White;
            this.btn_welcome.Location = new System.Drawing.Point(37, 249);
            this.btn_welcome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_welcome.Name = "btn_welcome";
            this.btn_welcome.Size = new System.Drawing.Size(232, 132);
            this.btn_welcome.TabIndex = 4;
            this.btn_welcome.Text = "\r\n\r\nTAP TO LEAD COFFEE HEVEN";
            this.guna2HtmlToolTip1.SetToolTip(this.btn_welcome, "TAP TO LOG IN");
            this.btn_welcome.UseVisualStyleBackColor = true;
            this.btn_welcome.Click += new System.EventHandler(this.btn_welcome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::coffeeHeven.Properties.Resources._6ug3jw;
            this.pictureBox2.Location = new System.Drawing.Point(306, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(602, 376);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btn_view_reservations
            // 
            this.btn_view_reservations.BackgroundImage = global::coffeeHeven.Properties.Resources.arabica_coffee_beans_500x500;
            this.btn_view_reservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_view_reservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_reservations.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_reservations.ForeColor = System.Drawing.Color.White;
            this.btn_view_reservations.Location = new System.Drawing.Point(37, 58);
            this.btn_view_reservations.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_view_reservations.Name = "btn_view_reservations";
            this.btn_view_reservations.Size = new System.Drawing.Size(232, 132);
            this.btn_view_reservations.TabIndex = 5;
            this.btn_view_reservations.Text = "\r\nRESERVATIONS";
            this.guna2HtmlToolTip1.SetToolTip(this.btn_view_reservations, "TAP TO LOG IN");
            this.btn_view_reservations.UseVisualStyleBackColor = true;
            this.btn_view_reservations.Click += new System.EventHandler(this.btn_view_reservations_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::coffeeHeven.Properties.Resources.R4;
            this.pictureBox4.Location = new System.Drawing.Point(12, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(275, 184);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::coffeeHeven.Properties.Resources.R4;
            this.pictureBox1.Location = new System.Drawing.Point(12, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 184);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdminWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::coffeeHeven.Properties.Resources.R2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.btn_welcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_view_reservations);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminwelcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_welcome;
        private System.Windows.Forms.Button btn_view_reservations;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}