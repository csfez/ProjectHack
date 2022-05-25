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
            ListViewAllReports.ItemsSource = myCollection ;
        }


        private void Delete_Report_Button_Click(object sender, RoutedEventArgs e)
        {
            Reports myReport;
            myReport = ListViewAllReports.SelectedItem as Reports;
            myCollection.Remove(myReport);
            DataSource.ListReports.Remove(myReport);
        }
    }
}
