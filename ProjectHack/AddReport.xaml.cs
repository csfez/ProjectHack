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



namespace ProjectHack
{
    /// <summary>
    /// Interaction logic for AddReport.xaml
    /// </summary>
    public partial class AddReport : Window
    {
        Category cat = new Category();
        Reports rep = new Reports();
        public PointLatLng Point = new PointLatLng();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(TbComments.Text))
                    throw new Exception("Bad input");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill in the comments please");
            }

            rep.AddReport(CbCategory.SelectedItem.ToString(), CbTitle.SelectedItem.ToString(),TbComments.Text, (StatusUrgence)CbPriority.SelectedItem, Point);
        }
    }



}

