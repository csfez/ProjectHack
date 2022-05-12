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

           /* ListReports = new List<Reports>
            {
                new Reports
                {
                 
                    

                },
            };
           */
        }
    }
}
      
