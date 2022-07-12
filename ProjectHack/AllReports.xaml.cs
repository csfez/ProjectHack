using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using GMap.NET.WindowsForms.Markers;


namespace ProjectHack
{
    /// <summary>
    /// Interaction logic for AllReports.xaml
    /// </summary>
    public partial class AllReports : Window
    {

        public static ObservableCollection<Reports> myCollection { get; set; }

        public AllReports()
        {

            InitializeComponent();
            myCollection = new ObservableCollection<Reports>(DataSource.ListReports);
            ListViewAllReports.ItemsSource = myCollection;
            ComboBoxItem cb1 = new ComboBoxItem();
            ComboBoxItem cb2 = new ComboBoxItem();
            ComboBoxItem cb3 = new ComboBoxItem();
            cb1.Content = "All";
            cb2.Content = "Waiting to take car";
            cb3.Content = "Handled";
            cbFilter.Items.Add(cb1);
            cbFilter.Items.Add(cb2);
            cbFilter.Items.Add(cb3);


        }


        private void Delete_Report_Button_Click(object sender, RoutedEventArgs e)
        {
            Reports myReport;
            myReport = ListViewAllReports.SelectedItem as Reports;
            myCollection.Remove(myReport);
            DataSource.ListReports.Remove(myReport);


        }

        private void CheckBox1_CheckedChanged(Object sender, EventArgs e)
        {

            Reports myReport = new Reports();
            myReport = ListViewAllReports.SelectedItem as Reports;

            myReport.Take_care_of(myReport.Id);
            GMapMarker orangeMarker = new GMarkerGoogle(myReport.Localization, GMarkerGoogleType.orange);
            myReport.marker = orangeMarker;
        }

        private void cbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Reports myReport = new Reports();
            String st = (cbFilter.SelectedItem as ComboBoxItem).Content.ToString();
            ListViewAllReports.ItemsSource = myReport.ShowFilteredList(st);
        }

    }
}