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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChatWPF.Data;
using ChatWPF.ADO;

namespace ChatWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text != null && PasswordTB.Password != null)
            {
                var DataLogin = DBConnection.connection.Login.Where
                    (z => z.Login1 == LoginTB.Text && z.Password == PasswordTB.Password).FirstOrDefault();
                if (DataLogin != null)
                {
                    if (LoginTB.Text == DataLogin.Login1 && PasswordTB.Password == DataLogin.Password)
                    {
                        MessageBox.Show("Красавчик!");
                    }
                }

                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }
            }

            else
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
        }
    }
}
