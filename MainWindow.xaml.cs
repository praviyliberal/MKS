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

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        Entities entities = new Entities();
        public bool flag_login = false;
        public bool flag_password = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void join_Click(object sender, RoutedEventArgs e)
        {
            string new_login = login.Text.Trim();

            string new_password = password.Password.Trim();

            try
            {
                if (new_login != null && new_login != "" || new_password != null && new_password != "")
                {
                    //var hash = md5.hashPassword(new_password);
                    foreach (var item in entities.Users)
                    {
                        if (new_login == item.Login.Trim() && new_password == item.Password.Trim())
                        {
                            flag_login = true;
                            flag_password = true;
                            Class_Login.role = false;
                            Class_Login.users_login = new_login;
                            Class_Login.Id_users = (from kekis in entities.Users where Class_Login.users_login == kekis.Login select kekis.Id_User).FirstOrDefault();
                            Class_Login.Fname = (from kek in entities.Users where Class_Login.Id_users == kek.Id_User select kek.FIrst_name.Trim()).FirstOrDefault();
                            Class_Login.Sname = (from kek in entities.Users where Class_Login.Id_users == kek.Id_User select kek.Second_name.Trim()).FirstOrDefault();
                            Class_Login.FAname = (from kek in entities.Users where Class_Login.Id_users == kek.Id_User select kek.Father_name.Trim()).FirstOrDefault();
                            if (Class_Login.Id != 0)
                            {
                                var window__ = new DetailProduct();
                                window__.Show();
                                this.Close();
                            }
                            else
                            {
                                var window_ = new Products_Win();
                                window_.Show();
                                this.Close();
                            }
                        }
                        else if (new_login == item.Login.Trim())
                        {
                            flag_login = true;
                            break;
                        }
                    }
                    if (flag_password == false && flag_login == true)
                    {
                        password.Clear();

                        MessageBox.Show("Неверно введен пароль!");
                    }
                    else if (flag_login == false && flag_password == true)
                    {
                        MessageBox.Show("Неверно введен логин!");
                        login.Clear();
                    }
                    else if (flag_password == false && flag_login == false)
                    {
                        password.Clear();
                        login.Clear();
                        MessageBox.Show("Неверно введены данные авторизации!");
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные для авторизации!");
                }
                
            }
            catch
            {
                MessageBox.Show("Ошибка!!!");
            }
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {       
            var window_ = new Registration();
            window_.Show();
            this.Close();
        }

        private void JoinAdmin_Click(object sender, RoutedEventArgs e)
        {
            string new_login = login.Text.Trim();

            string new_password = password.Password.Trim();

            try
            {
                if (new_login != null && new_login != "" || new_password != null && new_password != "")
                {
                    foreach (var item in entities.Workers)
                    {
                        if (new_login == item.Login.Trim() && new_password == item.Password.Trim())
                        {
                            flag_login = true;
                            flag_password = true;
                            Class_Login.users_login = new_login;
                            Class_Login.Id_users = (from kekis in entities.Workers where Class_Login.users_login == kekis.Login select kekis.Id_Worker).FirstOrDefault();
                            Class_Login.Fname = (from kek in entities.Workers where Class_Login.Id_users == kek.Id_Worker select kek.First_name).FirstOrDefault();
                            Class_Login.Sname = (from kek in entities.Workers where Class_Login.Id_users == kek.Id_Worker select kek.Second_name).FirstOrDefault();
                            Class_Login.FAname = (from kek in entities.Workers where Class_Login.Id_users == kek.Id_Worker select kek.Father_name).FirstOrDefault();
                            
                            Class_Login.role = true;
                            var window_ = new Products_Win();
                            window_.Show();
                            this.Close();
                        }
                        else if (new_login != item.Login.Trim() && new_password == item.Password.Trim())
                        {
                            flag_password = true;
                        }
                        else if (new_password != item.Password.Trim() && new_login == item.Login.Trim())
                        {
                            flag_login = true;
                        }
                    }
                    if (flag_password == false && flag_login == true)
                    {
                        password.Clear();

                        MessageBox.Show("Неверно введен пароль!");
                    }
                    else if (flag_login == false && flag_password == true)
                    {
                        MessageBox.Show("Неверно введен логин!");
                        login.Clear();
                    }
                    else if (flag_password == false && flag_login == false)
                    {
                        password.Clear();
                        login.Clear();
                        MessageBox.Show("Неверно введены данные авторизации!");
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные для авторизации!");
                }

            }
            catch
            {
                MessageBox.Show("Ошибка!!!");
            }
        }

        private void go_back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Products_Win();
            window_.Show();
            this.Close();
        }
    }
}