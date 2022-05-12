using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Device.Location;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;

namespace ProjectHack
{
    public partial class Form1 : Form
    {
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);

        public Form1()
        {
            InitializeComponent();
            watcher.Start();
            map.OnMarkerClick += new MarkerClick(map_OnMarkerClick);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            var location = watcher.Position.Location;
            PointLatLng point = new PointLatLng(location.Latitude, location.Longitude);
            AddReport addrep = new AddReport();
            addrep.Point = point;
            map.Position = point;
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.Zoom = 15;
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
            GMapMarker marker2 = new GMarkerGoogle(point, GMarkerGoogleType.red);
            GMapMarker marker3 = new GMarkerGoogle(point, GMarkerGoogleType.red);
            GMapMarker marker4 = new GMarkerGoogle(point, GMarkerGoogleType.red);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }
        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
           
        }
        
    
        //bouton +
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddReport win = new AddReport();
            win.Init();
            win.Show();
        }

        //bouton ...
        private void button2_Click_1(object sender, EventArgs e)
        {
            AllReports win = new AllReports();
            win.Show();
        }
    }
}
