
namespace coffeeHeven
{
    partial class AdminEnter
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
            this.btn_plan = new System.Windows.Forms.Button();
            this.btn_manage = new System.Windows.Forms.Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_plan
            // 
            this.btn_plan.BackgroundImage = global::coffeeHeven.Properties.Resources.OIP__19_;
            this.btn_plan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plan.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Underline);
            this.btn_plan.ForeColor = System.Drawing.Color.Black;
            this.btn_plan.Location = new System.Drawing.Point(39, 12);
            this.btn_plan.Name = "btn_plan";
            this.btn_plan.Size = new System.Drawing.Size(324, 222);
            this.btn_plan.TabIndex = 0;
            this.btn_plan.Text = "Plan\r\nCoffee Heven";
            this.guna2HtmlToolTip1.SetToolTip(this.btn_plan, "TAP TO PLAN COFFEE HEVEN");
            this.btn_plan.UseVisualStyleBackColor = true;
            this.btn_plan.Click += new System.EventHandler(this.btn_plan_Click);
            // 
            // btn_manage
            // 
            this.btn_manage.BackgroundImage = global::coffeeHeven.Properties.Resources._20160915213625_GettyImages_506827008_11;
            this.btn_manage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manage.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage.ForeColor = System.Drawing.Color.Black;
            this.btn_manage.Location = new System.Drawing.Point(39, 240);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(324, 222);
            this.btn_manage.TabIndex = 1;
            this.btn_manage.Text = "Manage\r\nCoffee Heven";
            this.guna2HtmlToolTip1.SetToolTip(this.btn_manage, "TAP TO MANAGE COFFEE HEVEN");
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(28, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 471);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AdminEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::coffeeHeven.Properties.Resources.become_successful_restaurant_employee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.btn_plan);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "AdminEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEnter";
            this.Load += new System.EventHandler(this.AdminEnter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_plan;
        private System.Windows.Forms.Button btn_manage;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}