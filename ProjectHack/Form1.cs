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
using System.Threading;

//C:\dotNet5781_00_9106_7647\dotNet5781_00_9106_7647
namespace ProjectHack
{
    public partial class Form1 : Form
    {
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
        public User CurrentUser1 = new User();
        private PointLatLng myPosition;

        public Form1()
        {
            InitializeComponent();
            watcher.Start();
           

            map.OnMarkerClick += new MarkerClick(map_OnMarkerClick);

        }

        public void init()
        {
            if (CurrentUser1.Admin)
                City_Hall_Access_Button.Visible = true;
            else
                City_Hall_Access_Button.Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                map.MapProvider = GMapProviders.GoogleMap;
                map.ShowCenter = false;

                bool abort = false;
                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
                if (watcher.TryStart(false, TimeSpan.FromMilliseconds(3000)))
                {
                    DateTime start = DateTime.Now;
                    while (watcher.Status != GeoPositionStatus.Ready && !abort)
                    {
                        Thread.Sleep(200);
                        if (DateTime.Now.Subtract(start).TotalSeconds > 5)
                            abort = true;
                    }

                    GeoCoordinate coord = watcher.Position.Location;
                    if (!coord.IsUnknown)
                    {
                        PointLatLng point = new PointLatLng(coord.Latitude, coord.Longitude);
                        myPosition = point;

                        map.Position = point;
                        map.MinZoom = 0;
                        map.MaxZoom = 18;
                        map.Zoom = 15;
                        
                        //add the localization point on the map
                        GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_pushpin);
                        GMapOverlay markers = new GMapOverlay("markers");
                        markers.Markers.Add(marker);
                        map.Overlays.Add(markers);

                    }
                    else 
                    {
                        PointLatLng point = new PointLatLng(31.261367430479297, 34.79913372551455); // -> example of localization
                        map.Position = point;
                        map.MinZoom = 0;
                        map.MaxZoom = 18;
                        map.Zoom = 15;
                        //GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
                    }
                }
                else
                {
                    PointLatLng point = new PointLatLng(31.261367430479297, 34.79913372551455); // -> example of localization
                    map.Position = point;
                    map.MinZoom = 0;
                    map.MaxZoom = 18;
                    map.Zoom = 10;
                    //GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
                }

               Load_the_Markers();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Password is empty");
            }
        }
        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            for(int i= 0; i< DataSource.ListReports.Count;i++)
            {
                if (item == DataSource.ListReports[i].marker)
                {
                    ReportWindow win = new ReportWindow(DataSource.ListReports[i]);
                    win.Show();
                }
            }    
        }

        public void Load_the_Markers()
        {
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker;

            for (int i = 0; i < DataSource.ListReports.Count; i++)
            {
                //marker = new GMarkerGoogle(DataSource.ListReports[i].Localization, GMarkerGoogleType.red);
                markers.Markers.Add(DataSource.ListReports[i].marker);
            }
            map.Overlays.Add(markers);
        }
        
    
        private void Add_Report_Button_Click(object sender, EventArgs e)
        {
            AddReport win = new AddReport(myPosition);
            win.user1 = CurrentUser1;
            win.Init();
            win.Show();
            Close();
        }

        private void Reporting_History_Button_Click(object sender, EventArgs e)
        {
            ReportHistorical win = new ReportHistorical();
            win.user1 = CurrentUser1;
            win.init();
            win.Show();
            this.Close();
        }

        private void City_Hall_Access_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            AllReports win = new AllReports();
            win.Show();
        }

       



        //private void Form1_Activated(object sender, EventArgs e)
        //{
        //    map.MapProvider = GMapProviders.GoogleMap;
        //}
    }
}
