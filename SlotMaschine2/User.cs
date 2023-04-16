using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SlotMaschine2
{
    public class User : INotifyPropertyChanged
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Register(string Username, string password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public string logindaten(string Username, string password)
        {
            this.Username = Username;
            this.Password = Password;
            return Username;
        }
        //private void Login(string username, string password)
        //{
        //    this.Username = username;
        //    this.Password = Password;
        //    return Username;
        //}
    }
}
