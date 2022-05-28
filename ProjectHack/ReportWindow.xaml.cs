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
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Device.Location;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;

namespace ProjectHack
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public ReportWindow(Reports report)
        {
            InitializeComponent();
            Report_Id.Text = report.Id.ToString();
            TitleBox.Text = report.Title.ToString();
            CategoryBox.Text = report.Category.ToString();
            RemarksBox.Text = report.Remarks.ToString();
            if (report.PhotoPath != "")
            {
                Report_Img.Source = (new ImageSourceConverter()).ConvertFromString(report.PhotoPath) as ImageSource;
            }
            

        }
    }
}
