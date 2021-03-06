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

        public PointLatLng location;

        bool hasBeenClicked_latitude = false;
        bool hasBeenClicked_longitude = false;

        String photoPath = "";

        public AddReport(PointLatLng myLocation)
        {
            InitializeComponent();
            location = myLocation;
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
          
            rep.AddReport(CbCategory.SelectedItem.ToString(), CbTitle.SelectedItem.ToString(), TbComments.Text, (StatusUrgence)CbPriority.SelectedItem, location, user1.Id, photoPath);
            Form1 form = new Form1();
            form.CurrentUser1 = user1;
            form.init();
            form.Show();
            //List<Reports> L = new List<Reports>();
            //L= rep.getAllReportHistory(user1.Id);
            //  ReportHistorical win = new ReportHistorical();
            // win.Refresh();
            this.Close();
        }

     
      

    }



}

