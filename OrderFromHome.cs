using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;

namespace coffeeHeven
{
    public partial class OrderFromHome : Form
    {
        public OrderFromHome()
        {
            InitializeComponent();
        }

        private void btn_tap_to_place_order_drive_thru_Click(object sender, EventArgs e)
        {
            PlaceOrder p2 = new PlaceOrder();
            p2.Show();

        }

        private void link_need_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help h5 = new Help();
            h5.Show();
        }

        private void btn_find_location_Click(object sender, EventArgs e)
        {
            // map.DragButton = MouseButtons.Left;
            // map.MapProvider = GapProviders.GoogleMap;
            //double lat =6.9063;
            //double longt =79.8708;
            // map.Position = new PointLatLng(lat, longt);
            // map.MinZoom= 5;
            // map.MaxZoom= 100;
            // Map.Zoom = 10;
            pic_box_map.Visible = true;
            Map m20 = new Map();
            m20.Show();

        }

        private void OrderFromHome_Load(object sender, EventArgs e)
        {
            pic_box_map.Visible = false;
        }
    }
}
