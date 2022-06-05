using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHack
{
    public static class DataSource
    {
        public static List<User> ListUsers;
        public static List<Reports> ListReports=new List<Reports>();
        public static List<CategoryNameEnum> ListCatName;
        public static int id = 0;
        static DataSource()
        {
            InitAllLists();

        }
        static void InitAllLists()
        {

            ListUsers = new List<User>
            {
                new User
                {
                    Id = 342687647,
                    UserName = "Chirly Sfez",
                    Password = "password",
                    Admin = false,

                },
                new User
                {
                    Id=12345678,
                    UserName = "TownHall",
                    Password = "1234",
                    Admin = true,

                },
                  new User
                {
                    Id = 888888,
                    UserName = "1",
                    Password = "1",
                    Admin = false,

                }
            };

            ListReports = new List<Reports>
            {
                new Reports
                {
                 Category= "Road_Problem",
                 Title ="Accident",
                 Remarks =" ",
                 Id =++DataSource.id,
                 statReport = statusOfReport.Waiting,
                 statUrgence = StatusUrgence.Urgent,
                 Localization = new GMap.NET.PointLatLng(31.785990,35.190816),
                 UserId=342687647,
                 PhotoPath="",
                 marker = new GMarkerGoogle(new GMap.NET.PointLatLng(31.785990,35.190816), GMarkerGoogleType.red)
        },

                new Reports
                {
                 Category= "Urban_Problem",
                 Title ="Disruptive_object",
                 Remarks =" ",
                 Id =++DataSource.id,
                 statReport = statusOfReport.Waiting,
                 statUrgence = StatusUrgence.Urgent,
                 Localization = new GMap.NET.PointLatLng(31.785178,35.192477),
                 UserId=342687647,
                 PhotoPath="",
                 marker = new GMarkerGoogle(new GMap.NET.PointLatLng(31.785178,35.192477), GMarkerGoogleType.red)
                },

                new Reports
                {
                 Category= "Road_Problem",
                 Title ="Accident",
                 Remarks =" ",
                 Id =++DataSource.id,
                 statReport = statusOfReport.Waiting,
                 statUrgence = StatusUrgence.Urgent,
                 Localization = new GMap.NET.PointLatLng(31.784511,35.186657),
                 UserId=888888,
                 PhotoPath="",
                 marker = new GMarkerGoogle(new GMap.NET.PointLatLng(31.754403,35.212938), GMarkerGoogleType.red)
                },

                new Reports
                {
                 Category= "Other",
                 Title ="Defective_indication",
                 Remarks =" ",
                 Id =++DataSource.id,
                 statReport = statusOfReport.Waiting,
                 statUrgence = StatusUrgence.NotUrgent,
                 Localization = new GMap.NET.PointLatLng(31.7854023700883,35.189667157021),
                 UserId=888888,
                 PhotoPath="",
                 marker = new GMarkerGoogle(new GMap.NET.PointLatLng(31.771137,35.212595), GMarkerGoogleType.red)
                },

            };
           
        }
    }
}
      
