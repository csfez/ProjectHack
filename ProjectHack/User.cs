using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectHack
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool Admin { get; set; }

        public void CreateNewUser(int id, string username, string password)
        {
            User user = new User();
            user.Id = id;
            user.UserName = username;
            user.Password = password;
            user.Admin = false;
            DataSource.ListUsers.Add(user);
            // List<User> u = new List<User>();
            //u = DataSource.ListUsers;

        }

        public bool CheckPassword(string user, string pass)
        {
            User CurrentUser = DataSource.ListUsers.Find(p => p.UserName == user);
            if (CurrentUser == null)
                return false;
            if (pass == CurrentUser.Password)
                return true;
            else
                return false;
        }

        public User getUser(string userName)
        {
            User CurrentUser = DataSource.ListUsers.Find(p => p.UserName == userName);
            return CurrentUser;

        }
    }


}