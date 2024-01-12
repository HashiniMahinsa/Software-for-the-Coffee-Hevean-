
namespace coffeeHeven
{
    partial class SecretWord
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_staff_enter = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txt_staff_password = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::coffeeHeven.Properties.Resources._6ufwq3;
            this.pictureBox1.Location = new System.Drawing.Point(21, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 332);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "YOU ARE OUR POWER\r\nREMEMBER \r\nTOGETHER\r\nEVERYONE\r\nACHIVES\r\nMORE");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Whats the secret word ?";
            this.toolTip1.SetToolTip(this.label1, "YOU ARE OUR POWER");
            // 
            // btn_staff_enter
            // 
            this.btn_staff_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_staff_enter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_staff_enter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_staff_enter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_staff_enter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_staff_enter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_staff_enter.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_enter.ForeColor = System.Drawing.Color.White;
            this.btn_staff_enter.Location = new System.Drawing.Point(775, 264);
            this.btn_staff_enter.Name = "btn_staff_enter";
            this.btn_staff_enter.PressedColor = System.Drawing.Color.Maroon;
            this.btn_staff_enter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_staff_enter.Size = new System.Drawing.Size(109, 60);
            this.btn_staff_enter.TabIndex = 6;
            this.btn_staff_enter.Text = "ENTER ";
            this.toolTip1.SetToolTip(this.btn_staff_enter, "YOU ARE OUR POWER\r\nREMEMBER\r\nTOGETHER\r\nEVERYONE\r\nACHIEVES\r\nMORE");
            this.btn_staff_enter.Click += new System.EventHandler(this.btn_staff_enter_Click);
            // 
            // txt_staff_password
            // 
            this.txt_staff_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_staff_password.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_staff_password.Location = new System.Drawing.Point(635, 207);
            this.txt_staff_password.Name = "txt_staff_password";
            this.txt_staff_password.PasswordChar = 'o';
            this.txt_staff_password.Size = new System.Drawing.Size(200, 29);
            this.txt_staff_password.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txt_staff_password, "FIRST LETTER MUST BE CAPITAL");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::coffeeHeven.Properties.Resources._6ug0em5;
            this.pictureBox2.Location = new System.Drawing.Point(579, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 338);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(579, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 28);
            this.progressBar1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SecretWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::coffeeHeven.Properties.Resources.R4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txt_staff_password);
            this.Controls.Add(this.btn_staff_enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "SecretWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretWord";
            this.toolTip1.SetToolTip(this, "YOU ARE OUR POWER\r\nREMEMBER\r\nTOGETHR \r\nEVERYONE\r\nACHIEVES\r\nMORE");
            this.Load += new System.EventHandler(this.SecretWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_staff_enter;
        private System.Windows.Forms.TextBox txt_staff_password;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}