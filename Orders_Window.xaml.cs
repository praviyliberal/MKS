using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class Orders_Window : Window
    {
        Entities entities = new Entities();
        public Orders_Window()
        {
            InitializeComponent();

            //пользователь
            if (Class_Login.role == false)
            {
                InfoLabel1.Visibility = Visibility.Hidden; 
                InfoLabel2.Visibility = Visibility.Hidden;
                InfoLabel3.Visibility = Visibility.Hidden;
                StartDate.Visibility = Visibility.Hidden;
                EndDate.Visibility = Visibility.Hidden;
                OrdersInfoButton.Visibility = Visibility.Hidden;
                SearchUsers.Visibility = Visibility.Hidden;
                SLabel.Visibility = Visibility.Hidden;
                SearchButtonFIO.Visibility = Visibility.Hidden;
                foreach (var item in entities.Orders)
                {
                    if (item.Id_User == Class_Login.Id_users)
                        products_list.Items.Add(item);
                }
            }
            //админ
            else if (Class_Login.role == true)
            {
                foreach (var item in entities.Orders)
                {
                    products_list.Items.Add(item);
                }
            }
        }

        private void go_back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Products_Win();
            window_.Show();
            this.Close();
        }

        private void product_list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var selected = products_list.SelectedItem as Orders;
                Class_Login.Id_Order = selected.Id_Order;
                var window_ = new DetailOrder();
                window_.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка!!!");
            }
        }

        private void YesOrder_Checked(object sender, RoutedEventArgs e)
        {
            
            NoOrder.IsChecked = false;
            AllOrder.IsChecked = false;
            products_list.Items.Clear();
            if (Class_Login.role == true)
            {
                if (YesOrder.IsChecked == true)
                {
                    foreach (var item in entities.Orders)
                    {
                        if (item.Status.Trim() == "Получен")
                        {
                            products_list.Items.Add(item);
                        }
                    }
                }
            }
            else if (Class_Login.role == false)
            {
                foreach (var item in entities.Orders)
                {
                    if (YesOrder.IsChecked == true && Class_Login.Id_users == item.Id_User)
                    {
                        if (item.Status.Trim() == "Получен")
                        {
                            products_list.Items.Add(item);
                        }
                    }
                }
            }

        }

        private void NoOrder_Checked(object sender, RoutedEventArgs e)
        {
            products_list.Items.Clear();
            YesOrder.IsChecked = false;
            AllOrder.IsChecked = false;
            if (Class_Login.role == true)
            {
                if (NoOrder.IsChecked == true)
                {
                    foreach (var item in entities.Orders)
                    {
                        if (item.Status.Trim() == "В пути")
                        {
                            products_list.Items.Add(item);
                        }
                    }
                }
            }
            else if (Class_Login.role == false)
            {
                foreach (var item in entities.Orders)
                {
                    if (YesOrder.IsChecked == true && Class_Login.Id_users == item.Id_User)
                    {
                        if (item.Status.Trim() == "Получен")
                        {
                            products_list.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void AllOrder_Checked(object sender, RoutedEventArgs e)
        {
            YesOrder.IsChecked = false;
            NoOrder.IsChecked = false;
            products_list.Items.Clear();
            if (Class_Login.role == true)
            {
                foreach (var item in entities.Orders)
                {
                    products_list.Items.Add(item);
                }
            }
            else if (Class_Login.role == false)
            {
                foreach (var item in entities.Orders)
                {
                    if(Class_Login.Id_users == item.Id_User)
                    products_list.Items.Add(item);
                }
            }
        }

        private void OrdersInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (StartDate.SelectedDate != null && StartDate.SelectedDate != null)
            {
                InfoOrders.Start = Convert.ToDateTime(StartDate.SelectedDate);
                InfoOrders.End = Convert.ToDateTime(EndDate.SelectedDate);
                var window_ = new OrdersInfo();
                window_.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите период отчетности продажи!");
            }
        }
        private void SearchButtonFIO_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            int id = 0;
            string fname = "";
            string sname = "";
            string[] words = SearchUsers.Text.Split(' ');

            int acc = words.GetLength(0);

            if (acc == 1)
            {
                if (words[0] == "")
                {
                    MessageBox.Show("Введите фамилию");
                }
                else
                {
                    sname = words[0];
                }
                foreach (var item in entities.Users)
                {
                    if (item.Second_name.ToLower().Trim().Contains(sname.ToLower().Trim()))
                    {
                        flag = true;
                        id = item.Id_User;
                    }
                }
            }
            else if (acc == 2)
            {
                if (words[1] == "")
                {
                    MessageBox.Show("Введите имя");
                }
                else
                {
                    fname = words[1];
                }
                foreach (var item in entities.Users)
                {
                    if (item.Second_name.ToLower().Trim().Contains(sname.ToLower().Trim()) && item.FIrst_name.ToLower().Trim().Contains(fname.ToLower().Trim()))
                    {
                        flag = true;
                        id = item.Id_User;
                    }
                }
            }

            products_list.Items.Clear();

            if (flag == true)
            {
                foreach (var searchOrder in entities.Orders)
                {
                    if (searchOrder.Id_User == id)
                    {
                        products_list.Items.Add(searchOrder);
                    }
                }
            }
            if (SearchUsers.Text == "")
            {
                foreach (var searchOrder in entities.Orders)
                {
                    products_list.Items.Add(searchOrder);
                }
            }
        }
    }
}