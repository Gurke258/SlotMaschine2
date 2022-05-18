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

namespace SlotMaschine2
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, RoutedEventArgs e)
        {
            if(tbUsername.Text != "" && tbUsername.Text != null && tbPassword.Text != "" && tbPassword.Text != null)
            {
                if (tbUsername.Text != tbPassword.Text)
                {
                    Close();
                }
                
            }
        }
    }
}
