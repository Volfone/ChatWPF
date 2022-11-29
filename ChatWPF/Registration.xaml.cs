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
using ChatWPF.Data;
using ChatWPF.ADO;

namespace ChatWPF
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            var DataLogList = DBConnection.connection.Login.Where(x => x.Login1 == LoginTB.Text).FirstOrDefault();
            if (NameTB.Text != null && LoginTB.Text != null && PasswordTB.Text != null)
            {
                try
                {
                    User NewUser = new User();
                    NewUser.Name = NameTB.Text;
                    Login NewLogins = new Login()
                    {
                        Login1 = LoginTB.Text,
                        Password = PasswordTB.Text,
                        User_ID = NewUser.User_ID
                    };
                    NewUser.Login.Add(NewLogins);
                    DBConnection.connection.User.Add(NewUser);
                    DBConnection.connection.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно!");

                }
                catch
                {
                    Exception ex;
                }
            }
        }
    }
}
