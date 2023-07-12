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
    public partial class DetailOrder : Window
    {
        Entities entities = new Entities();

        public DetailOrder()
        {
            InitializeComponent();
            if (Class_Login.role == false)
            {
                OrderComplit.Visibility = Visibility.Hidden;
            }
            foreach (var kekis in entities.Orders)
            {
                if (kekis.Id_Order == Class_Login.Id_Order)
                {
                    CodeOrderLabel.Content = kekis.CodeOrder;
                }
            }
            foreach (var item in entities.TovarToOrder)
            {
                if (item.Id_Case != null && item.Id_User == Class_Login.Id_users && item.Id_Order == Class_Login.Id_Order)
                {            
                    foreach (var Case in entities.Cases)
                    {
                        if (Case.Id_Case == item.Id_Case)
                        {
                            products_list.Items.Add(Case);
                        }
                    }
                }
                else if (item.Id_Processor != null && item.Id_User == Class_Login.Id_users && item.Id_Order == Class_Login.Id_Order)
                {
                    foreach (var CPU in entities.CPU)
                    {
                        if (CPU.Id_Processor == item.Id_Processor)
                        {
                            products_list.Items.Add(CPU);
                        }
                    }
                }
                else if (item.Id_HDD != null && item.Id_User == Class_Login.Id_users && item.Id_Order == Class_Login.Id_Order)
                {
                    foreach (var HDD in entities.HDD)
                    {
                        if (HDD.Id_HDD == item.Id_HDD)
                        {
                            products_list.Items.Add(HDD);
                        }
                    }
                }
                else if (item.Id_Monitor != null && item.Id_User == Class_Login.Id_users && item.Id_Order == Class_Login.Id_Order)
                {
                    foreach (var Monitor in entities.Monitor)
                    {
                        if (Monitor.Id_Monitor == item.Id_Monitor)
                        {
                            products_list.Items.Add(Monitor);
                        }
                    }
                }
                else if (item.Id_Motherboard != null && item.Id_User == Class_Login.Id_users && item.Id_Order == Class_Login.Id_Order)
                {
                    foreach (var MB in entities.Motherboard)
                    {
                        if (MB.Id_Motherboard == item.Id_Motherboard)
                        {
                            products_list.Items.Add(MB);
                        }
                    }
                }
                else if (item.Id_PowerUnit != null && item.Id_User == Class_Login.Id_users && item.Id_Order == Class_Login.Id_Order)
                {
                    foreach (var PU in entities.PowerUnit)
                    {
                        if (PU.Id_PowerUnit == item.Id_PowerUnit)
                        {
                            products_list.Items.Add(PU);
                        }
                    }
                }
                else if (item.Id_RAM != null && item.Id_User == Class_Login.Id_users && item.Id_Order == Class_Login.Id_Order)
                {
                    foreach (var RAM in entities.RAM)
                    {
                        if (RAM.Id_RAM == item.Id_RAM)
                        {
                            products_list.Items.Add(RAM);
                        }
                    }
                }
                else if (item.Id_VideoCard != null && item.Id_User == Class_Login.Id_users && item.Id_Order == Class_Login.Id_Order)
                {
                    foreach (var VC in entities.VideoCard)
                    {
                        if (VC.Id_VideoCard == item.Id_VideoCard)
                        {
                            products_list.Items.Add(VC);
                        }
                    }
                }
            }
        }

        private void go_back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Orders_Window();
            window_.Show();
            this.Close();
        }

        private void OrderComplit_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in entities.Orders)
            {
                if (Class_Login.Id_Order == item.Id_Order)
                {
                    item.Status = "Получен";
                    MessageBox.Show("Стату заказа успешно изменен!");
                }
            }
            entities.SaveChanges();
        }
    }
}
