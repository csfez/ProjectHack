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

//C:\dotNet5781_00_9106_7647\dotNet5781_00_9106_7647
namespace ProjectHack
{
    public partial class Form1 : Form
    {
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
        public User CurrentUser1 = new User();

        public Form1()
        {
            InitializeComponent();
            watcher.Start();
           

            //map.OnMarkerClick += new MarkerClick(map_OnMarkerClick);

        }

        public void init()
        {
            if (CurrentUser1.Admin)
                button3.Visible = true;
            else
                button3.Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                map.MapProvider = GMapProviders.GoogleMap;
                map.ShowCenter = false;
                var location = watcher.Position.Location;
                //PointLatLng point = new PointLatLng(location.Latitude, location.Longitude); -> problem with this row
                PointLatLng point = new PointLatLng(35.0000, 103.000); // -> example of localization
                AddReport addrep = new AddReport();
                addrep.Point = point;
                map.Position = point;
                map.MinZoom = 0;
                map.MaxZoom = 18;
                map.Zoom = 2;
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red);

                GMapOverlay markers = new GMapOverlay("markers");

            
            GMapMarker marker5;

            for (int i = 0; i < DataSource.ListReports.Count; i++)
            {
                marker5 = new GMarkerGoogle(DataSource.ListReports[i].Localization, GMarkerGoogleType.red);
                markers.Markers.Add(marker5);
            }
            //if (map.Overlays.Count > 0)
            //{
            //    map.Overlays.RemoveAt(0);
            //}
            map.Overlays.Add(markers);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Password is empty");
            }
        }
        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            PointLatLng point = item.Position;
            ReportWindow win = new ReportWindow(point);
 
            win.Show();
            
        }
        
    
        //bouton +
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddReport win = new AddReport();
            win.user1 = CurrentUser1;
            win.Init();
            win.Show();
            //this.Close();
        }

        //bouton ...
        private void button2_Click_1(object sender, EventArgs e)
        {
            ReportHistorical win = new ReportHistorical();
            win.user1 = CurrentUser1;
            win.init();
            win.Show();
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllReports win = new AllReports();
            win.Show();
        }

       

        //private void Form1_Activated(object sender, EventArgs e)
        //{
        //    map.MapProvider = GMapProviders.GoogleMap;
        //}
    }
}
