using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfApp3
{
    public partial class Registration : Window
    {
        Entities entities = new Entities();
        public Registration()
        {
            InitializeComponent();
            save.Visibility = Visibility.Hidden;
            if (Class_Login.Id_users != 0)
            {
                save.Visibility = Visibility.Visible;
                reg.Visibility = Visibility.Hidden;
                if (Class_Login.role == false)
                {
                    foreach (var item in entities.Users)
                    {
                        if (Class_Login.Id_users == item.Id_User)
                        {
                            s_name.Text = item.Second_name;
                            f_name.Text = item.FIrst_name;
                            fa_name.Text = item.Father_name;
                            new_email.Text = item.Email;
                            new_num.Text = item.Phone_num;
                            date_birth.SelectedDate = item.Date_of_Birth;
                            new_login.Text = item.Login;
                            new_password.Text = item.Password;
                        }
                    }
                }
                else
                {
                    date_birth.Visibility = Visibility.Hidden;
                    new_num.Visibility = Visibility.Hidden;
                    DateLabel.Visibility = Visibility.Hidden;
                    LabelNum.Visibility = Visibility.Hidden;
                    LabelEmail.Content = "Должность";
                    foreach (var item in entities.Workers)
                    {
                        if (Class_Login.Id_users == item.Id_Worker)
                        {
                            s_name.Text = item.Second_name;
                            f_name.Text = item.First_name;
                            fa_name.Text = item.Father_name;
                            new_email.Text = item.Job;
                            new_login.Text = item.Login;
                            new_password.Text = item.Password;
                        }
                    }
                }
            }
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {

                if (s_name.Text != "" || f_name.Text != "" || fa_name.Text != "" || new_email.Text != "" || new_num.Text != "" || new_password.Text != "" || new_login.Text != "" || date_birth.SelectedDate != null)
                {
                var saved = new Users();
                foreach (var item in entities.Users)
                    { 
                        if (item.Login != new_login.Text)
                        {
                            saved.Second_name = s_name.Text.Trim();
                            saved.FIrst_name = f_name.Text.Trim();
                            saved.Father_name = fa_name.Text.Trim();
                            saved.Date_of_Birth = Convert.ToDateTime(date_birth.SelectedDate);
                            saved.Email = new_email.Text.Trim();
                            saved.Phone_num = new_num.Text.Trim();
                            saved.Login = new_login.Text.Trim();
                        //var hash = md5.hashPassword(new_password.Text);
                            saved.Password = new_password.Text;
                            
                        }
                    }
                entities.Users.Add(saved);
            }
                else
                {
                    MessageBox.Show("Заполните все необходимые поля!!!");
                }
            entities.SaveChanges();
            var window_ = new MainWindow();
            window_.Show();
            this.Close();


        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

                if (s_name.Text != "" || f_name.Text != "" || fa_name.Text != "" || new_email.Text != "" || new_num.Text != "" || new_password.Text != "" || new_login.Text != "" || date_birth.SelectedDate != null)
                {
                    if (Class_Login.role == false)
                    {
                        foreach (var item in entities.Users)
                        {
                            if (item.Id_User == Class_Login.Id_users)
                            {
                                item.Second_name = s_name.Text.Trim();
                                item.FIrst_name = f_name.Text.Trim();
                                item.Father_name = fa_name.Text.Trim();
                                item.Date_of_Birth = Convert.ToDateTime(date_birth.SelectedDate);
                                item.Email = new_email.Text.Trim();
                            //var hash = md5.hashPassword(new_password.Text);
                                item.Login = new_login.Text.Trim();
                                item.Password = new_password.Text.Trim();
                                Class_Login.Fname = f_name.Text.Trim();
                                Class_Login.Sname = s_name.Text.Trim();
                                Class_Login.FAname = fa_name.Text.Trim();
                            }
                        }
                    }
                    else if (Class_Login.role == true)
                    {
                        foreach (var item in entities.Workers)
                        {
                            if (item.Id_Worker == Class_Login.Id_users)
                            {
                                item.Second_name = s_name.Text.Trim();
                                item.First_name = f_name.Text.Trim();
                                item.Father_name = fa_name.Text.Trim();
                            //var hash = md5.hashPassword(new_password.Text);
                                item.Login = new_login.Text.Trim();
                                item.Password = new_password.Text.Trim();
                                Class_Login.Fname = f_name.Text.Trim();
                                Class_Login.Sname = s_name.Text.Trim();
                                Class_Login.FAname = fa_name.Text.Trim();
                            }
                        }
                    }
                }
                else
            {
                MessageBox.Show("Заполните все необходимые поля!!!");
            }
                entities.SaveChanges();
            MessageBox.Show("Изменения успешно сохранены!");
                var window_ = new Products_Win();
                window_.Show();
                this.Close();
        }

        private void go_back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.Id_users == 0)
            {
                var window__ = new MainWindow();
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
    }
}
