
namespace coffeeHeven
{
    partial class ExploreCoffeeWorld
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
            this.btn_explore_coffee = new System.Windows.Forms.Button();
            this.btn_explore_coffee_heven = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_explore_coffee
            // 
            this.btn_explore_coffee.BackgroundImage = global::coffeeHeven.Properties.Resources.OIP__4_1;
            this.btn_explore_coffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_explore_coffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_explore_coffee.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_explore_coffee.ForeColor = System.Drawing.Color.White;
            this.btn_explore_coffee.Location = new System.Drawing.Point(148, 108);
            this.btn_explore_coffee.Name = "btn_explore_coffee";
            this.btn_explore_coffee.Size = new System.Drawing.Size(252, 175);
            this.btn_explore_coffee.TabIndex = 0;
            this.btn_explore_coffee.Text = "EXPLORE \r\nCOFFEE WORLD";
            this.toolTip1.SetToolTip(this.btn_explore_coffee, "TAP TO HERE TO EXPLORE \nCOFFEE WORLD");
            this.btn_explore_coffee.UseVisualStyleBackColor = true;
            this.btn_explore_coffee.Click += new System.EventHandler(this.btn_explore_coffee_Click);
            // 
            // btn_explore_coffee_heven
            // 
            this.btn_explore_coffee_heven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_explore_coffee_heven.BackgroundImage = global::coffeeHeven.Properties.Resources.OIP__17_;
            this.btn_explore_coffee_heven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_explore_coffee_heven.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Underline);
            this.btn_explore_coffee_heven.ForeColor = System.Drawing.Color.White;
            this.btn_explore_coffee_heven.Location = new System.Drawing.Point(526, 108);
            this.btn_explore_coffee_heven.Name = "btn_explore_coffee_heven";
            this.btn_explore_coffee_heven.Size = new System.Drawing.Size(252, 175);
            this.btn_explore_coffee_heven.TabIndex = 1;
            this.btn_explore_coffee_heven.Text = "EXPLORE \r\nCOFFEE HEVEN";
            this.toolTip1.SetToolTip(this.btn_explore_coffee_heven, "TAP TO HERE TO EXPLORE ");
            this.btn_explore_coffee_heven.UseVisualStyleBackColor = false;
            this.btn_explore_coffee_heven.Click += new System.EventHandler(this.btn_explore_coffee_heven_Click);
            // 
            // ExploreCoffeeWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::coffeeHeven.Properties.Resources.international_coffee_day_163301550216x91;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.btn_explore_coffee_heven);
            this.Controls.Add(this.btn_explore_coffee);
            this.Name = "ExploreCoffeeWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExploreCoffeeWorld";
            this.Load += new System.EventHandler(this.ExploreCoffeeWorld_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_explore_coffee;
        private System.Windows.Forms.Button btn_explore_coffee_heven;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}