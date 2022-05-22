using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMaschine2
{
    public class User : Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Register(string Username, string password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        public string logindaten()
        {
            UserName = tbUsername.Text;
            Password = tbPassword.Text;
            return UserName;
        }
        //private void Login(string username, string password)
        //{
        //    this.UserName = UserName;
        //    this.Password = Password;
        //}
    }
}
