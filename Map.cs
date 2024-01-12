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
using GMap.NET.WindowsForms;




namespace coffeeHeven
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
           
            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            //gMapControl1.Dock = DockStyle. Fill;

           // gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            
           // gMapControl1.Position = new PointLatLng(24.9795066883323, 67.0655250549316);

           // gMapControl1.Zoom = 15;
           

            
               
           
        }
    }
}
