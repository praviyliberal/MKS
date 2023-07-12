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
namespace WpfApp3
{
    public partial class Products_Win : Window
    {
        public Products_Win()
        {
            InitializeComponent();
            UserName.Content = Class_Login.Sname + " " + Class_Login.Fname + " " + Class_Login.FAname;
            if(Class_Login.role == true)
            {
                basket_of_products.Visibility = Visibility.Hidden;
                LabelBasket.Visibility = Visibility.Hidden;
            }
        }

        private void CPU_MouseEnter(object sender, MouseEventArgs e)
        {
            CPU_Border.BorderBrush = Brushes.Wheat;
        }

        private void MB_MouseEnter(object sender, MouseEventArgs e)
        {
            MB_Border.BorderBrush = Brushes.Wheat;
        }

        private void VC_MouseEnter(object sender, MouseEventArgs e)
        {
            VC_Border.BorderBrush = Brushes.Wheat;
        }

        private void PU_MouseEnter(object sender, MouseEventArgs e)
        {
            PU_Border.BorderBrush = Brushes.Wheat;
        }

        private void RAM_MouseEnter(object sender, MouseEventArgs e)
        {
            RAM_Border.BorderBrush = Brushes.Wheat;
        }

        private void Monitor_MouseEnter(object sender, MouseEventArgs e)
        {
            Monitor_Border.BorderBrush = Brushes.Wheat;
        }

        private void HDD_MouseEnter(object sender, MouseEventArgs e)
        {
            HDD_Border.BorderBrush = Brushes.Wheat;
        }

        private void Case_MouseEnter(object sender, MouseEventArgs e)
        {
            Case_Border.BorderBrush = Brushes.Wheat;
        }

        private void CPU_MouseLeave(object sender, MouseEventArgs e)
        {
            CPU_Border.BorderBrush = Brushes.Black;
        }

        private void MB_MouseLeave(object sender, MouseEventArgs e)
        {
            MB_Border.BorderBrush = Brushes.Black;
        }

        private void VC_MouseLeave(object sender, MouseEventArgs e)
        {
            VC_Border.BorderBrush = Brushes.Black;
        }

        private void PU_MouseLeave(object sender, MouseEventArgs e)
        {
            PU_Border.BorderBrush = Brushes.Black;
        }

        private void RAM_MouseLeave(object sender, MouseEventArgs e)
        {
            RAM_Border.BorderBrush = Brushes.Black;
        }

        private void Monitor_MouseLeave(object sender, MouseEventArgs e)
        {
            Monitor_Border.BorderBrush = Brushes.Black;
        }

        private void HDD_MouseLeave(object sender, MouseEventArgs e)
        {
            HDD_Border.BorderBrush = Brushes.Black;
        }

        private void Case_MouseLeave(object sender, MouseEventArgs e)
        {
            Case_Border.BorderBrush = Brushes.Black;
        }

        private void CPU_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.role == false)
            {
                Class_Login.IdProduct = 1;
                var window_ = new User();
                window_.Show();
                this.Close();
            }
            else if (Class_Login.role == true)
            {
                Class_Login.IdProduct = 1;
                var window_ = new Admin();
                window_.Show();
                this.Close();
            }
        }

        private void MB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.role == false)
            {
                Class_Login.IdProduct = 2;
                var window_ = new User();
                window_.Show();
                this.Close();
            }
            else if (Class_Login.role == true)
            {
                Class_Login.IdProduct = 2;
                var window_ = new Admin();
                window_.Show();
                this.Close();
            }

        }

        private void VC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.role == false)
            {
                Class_Login.IdProduct = 3;
                var window_ = new User();
                window_.Show();
                this.Close();
            }
            else if (Class_Login.role == true)
            {
                Class_Login.IdProduct = 3;
                var window_ = new Admin();
                window_.Show();
                this.Close();
            }

        }

        private void PU_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.role == false)
            {
                Class_Login.IdProduct = 4;
                var window_ = new User();
                window_.Show();
                this.Close();
            }
            else if (Class_Login.role == true)
            {
                Class_Login.IdProduct = 4;
                var window_ = new Admin();
                window_.Show();
                this.Close();
            }

        }

        private void RAM_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.role == false)
            {
                Class_Login.IdProduct = 5;
                var window_ = new User();
                window_.Show();
                this.Close();
            }
            else if (Class_Login.role == true)
            {
                Class_Login.IdProduct = 5;
                var window_ = new Admin();
                window_.Show();
                this.Close();
            }
        }

        private void Monitor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.role == false)
            {
                Class_Login.IdProduct = 6;
                var window_ = new User();
                window_.Show();
                this.Close();
            }
            else if (Class_Login.role == true)
            {
                Class_Login.IdProduct = 6;
                var window_ = new Admin();
                window_.Show();
                this.Close();
            }
        }

        private void HDD_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.role == false)
            {
                Class_Login.IdProduct = 7;
                var window_ = new User();
                window_.Show();
                this.Close();
            }
            else if (Class_Login.role == true)
            {
                Class_Login.IdProduct = 7;
                var window_ = new Admin();
                window_.Show();
                this.Close();
            }
        }

        private void Case_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.role == false)
            {
                Class_Login.IdProduct = 8;
                var window_ = new User();
                window_.Show();
                this.Close();
            }
            else if (Class_Login.role == true)
            {
                Class_Login.IdProduct = 8;
                var window_ = new Admin();
                window_.Show();
                this.Close();
            }
        }

        private void go_back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Class_Login.Id_users = 0;
            Class_Login.FAname = "";
            Class_Login.Fname = "";
            Class_Login.Sname = "";
            Class_Login.role = false;
            Class_Login.Id = 0;
            Class_Login.IdProduct = 0;
            var window_ = new MainWindow();
            window_.Show();
            this.Close();
        }

        private void basket_of_products_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Basket_Window();
            window_.Show();
            this.Close();
        }

        private void orders_products_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            var window_ = new Orders_Window();
            window_.Show();
            this.Close();
        }

        private void UserImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Class_Login.Id_users == 0)
            {
                MessageBoxResult dialogResult =  MessageBox.Show("Вы хотите зарегистрировать нового пользователя?", "Регистрация", MessageBoxButton.YesNo);

                if (dialogResult == MessageBoxResult.Yes)
                {
                    var window_ = new Registration();
                    window_.Show();
                    this.Close();
                }
                else if (dialogResult == MessageBoxResult.No)
                {
                    var window_ = new MainWindow();
                    window_.Show();
                    this.Close();
                }
            }
            else
            {
                var window_ = new Registration();
                window_.Show();
                this.Close();
            }
        }
    }
}
