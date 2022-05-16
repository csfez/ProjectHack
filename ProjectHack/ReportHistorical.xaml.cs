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
    /// Interaction logic for ReportHistorical.xaml
    /// </summary>
    public partial class ReportHistorical : Window
    {
        List<string> ListCat = new List<string>();
        List<string> ListTitle = new List<string>();
        List<StatusUrgence> ListPriority = new List<StatusUrgence>();
        List<bool> ListStatus = new List<bool>();
        Reports rep = new Reports();
        public User user1 = new User();
        public static ObservableCollection<Reports> myCollection { get; set; }

        public ReportHistorical()
        {
            InitializeComponent();

        }

        public void init()
        {
            int idtest = user1.Id;
           // ListViewReports.ItemsSource = rep.getAllReportHistory(user1.Id);
            List<Reports> RE = new List<Reports>();
            RE = rep.getAllReportHistory(user1.Id);
            ListViewReports.ItemsSource = rep.getAllReportHistory(user1.Id);
            // myCollection = new ObservableCollection<Reports>(rep.getAllReportHistory(user1.Id));
            //ListViewReports.ItemsSource = myCollection;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Form1 form = new Form1();
            form.CurrentUser1 = user1;
            form.init();
            form.Show();
            this.Close();
        }
    }
}
