using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Device.Location;
using GMap.NET.WindowsForms.Markers;
using System.Diagnostics;
//using System.DirectoryServices;
using System.Windows.Forms;




namespace ProjectHack
{
    /// <summary>
    /// Interaction logic for AddReport.xaml
    /// </summary>
    public partial class AddReport : Window
    {
        Category cat = new Category();
        Reports rep = new Reports();
        public User user1 = new User();

        public PointLatLng Point = new PointLatLng();

        bool hasBeenClicked_latitude = false;
        bool hasBeenClicked_longitude = false;

        String photoPath = "";

        public AddReport()
        {
            InitializeComponent();
        }

        public void Init()
        {
            List<CategoryNameEnum> ListCatName = cat.GetAllCategoryName();
            CbCategory.ItemsSource = ListCatName;
            List<StatusUrgence> listUrgence = rep.getAllStatusUrgence();
            CbPriority.ItemsSource = listUrgence;

        }
        private void CbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> ListSubCatName = cat.getAllSubCat((CategoryNameEnum)CbCategory.SelectedItem);
            CbTitle.ItemsSource = ListSubCatName;


            //CbFirstStation.ItemsSource = bl6.GetStationWithArea((BO.Areas)CbArea.SelectedItem);
        }


        private void Add_Photo_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //\nelly\Pictures\album
            openFileDialog.InitialDirectory = @"C:\Users";
            var result = openFileDialog.ShowDialog();
            string path = "";
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            photoPath = path;
            Img.Source = (new ImageSourceConverter()).ConvertFromString(path) as ImageSource;
        }

        private void Create_Report_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(TbComments.Text))
                    throw new Exception("Bad input");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Fill in the comments please");
            }
            try
            {
                if (String.IsNullOrEmpty(CbPriority.Text))
                    throw new Exception("Bad input");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error");
            }
            //(31,7906287, 34,6355109)
            try
            {
                
                Point.Lat = double.Parse(Latitude_TextBox.Text);
                Point.Lng = double.Parse(Longitude_TextBox.Text);
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show("Error in latitude or longiture field");
            }
            rep.AddReport(CbCategory.SelectedItem.ToString(), CbTitle.SelectedItem.ToString(), TbComments.Text, (StatusUrgence)CbPriority.SelectedItem, Point, user1.Id, photoPath);
            Form1 form = new Form1();
            form.Show();
            //List<Reports> L = new List<Reports>();
            //L= rep.getAllReportHistory(user1.Id);
            //  ReportHistorical win = new ReportHistorical();
            // win.Refresh();
            this.Close();
        }

        private void Latitude_TextBox_Focus(object sender, RoutedEventArgs e)
        {
            if (!hasBeenClicked_latitude)
            {
                if (!hasBeenClicked_latitude)
                {
                    System.Windows.Controls.TextBox box = sender as System.Windows.Controls.TextBox;
                    box.Text = String.Empty;
                    hasBeenClicked_latitude = true;
                }
            }
        }

        private void Longitude_TextBox_Focus(object sender, RoutedEventArgs e)
        {
            if (!hasBeenClicked_longitude)
            {
                if (!hasBeenClicked_longitude)
                {
                    System.Windows.Controls.TextBox box = sender as System.Windows.Controls.TextBox;
                    box.Text = String.Empty;
                    hasBeenClicked_longitude = true;
                }
            }
        }

    }



}

