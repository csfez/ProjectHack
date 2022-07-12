using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Device.Location;
using GMap.NET.WindowsForms.Markers;


namespace ProjectHack
{

    public class Reports
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public string Remarks { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }

        public statusOfReport statReport { get; set; }

        public StatusUrgence statUrgence { get; set; }

        public PointLatLng Localization { get; set; }

        public GMapMarker marker { get; set; }
        public string PhotoPath { get; set; }

        public void AddReport(string category, string title, string remark, StatusUrgence staturgence, PointLatLng loca, int userid, string pathphoto)
        {
            Reports report = new Reports();
            report.Category = category;
            report.Title = title;
            report.Remarks = remark;
            report.Id = ++DataSource.id;
            report.statReport = statusOfReport.Waiting;
            report.statUrgence = staturgence;
            report.Localization = loca;
            report.marker = new GMarkerGoogle(loca, GMarkerGoogleType.red);
            report.UserId = userid;
            report.PhotoPath = pathphoto;
            DataSource.ListReports.Add(report);
            List<Reports> listRe = new List<Reports>();
            listRe = DataSource.ListReports;

        }

        public void Take_care_of(int id)
        {
            List<Reports> ListRep = new List<Reports>();
            ListRep = DataSource.ListReports;
            Reports rep = ListRep.Find(x => x.Id == id);
            rep.statReport = statusOfReport.handled;
            ListRep.Remove(ListRep.Find(x => x.Id == id));
            ListRep.Add(rep);
        }


        public List<Reports> getAllReportHistory(int idUser)
        {
            List<Reports> listRep = new List<Reports>();
            listRep = DataSource.ListReports.FindAll(p => p.UserId == idUser);
            return listRep;

        }

        public List<StatusUrgence> getAllStatusUrgence()
        {

            List<StatusUrgence> ListStatUrgence = Enum.GetValues(typeof(StatusUrgence)).Cast<StatusUrgence>().ToList();
            return ListStatUrgence;
        }

        public List<Reports> ShowFilteredList(String filter)
        {
            List<Reports> ListFiltered = new List<Reports>();
            if (filter == "Waiting to take car")
            {
                ListFiltered = DataSource.ListReports.FindAll(p => p.statReport == statusOfReport.Waiting);
                return ListFiltered;
            }
            if (filter == "Handled")
            {
                ListFiltered = DataSource.ListReports.FindAll(p => p.statReport == statusOfReport.handled);
                return ListFiltered;
            }

            ListFiltered = DataSource.ListReports;
            return ListFiltered;
        }

    }


}

