using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace SlotMaschine2
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Window, INotifyPropertyChanged
    {

        public static string LoginUsername { get; set; }

        private static User aktuellerUser = new User();

        public event PropertyChangedEventHandler PropertyChanged;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbUsername.Text != "" && tbUsername.Text != null && tbPassword.Text != "" && tbPassword.Text != null)
            {
                if (tbUsername.Text != tbPassword.Text )
                {
                    LoginUsername = aktuellerUser.logindaten(tbUsername.Text, tbPassword.Text);
                    
                }
                else
                {
                    System.Windows.MessageBox.Show("Falsche Daten!");
                }

            }
            else
            {
                System.Windows.MessageBox.Show("Falsche Daten!");
            }


        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var register = new RegisterWindow();
            register.ShowDialog();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
