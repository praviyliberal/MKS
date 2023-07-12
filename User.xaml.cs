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
    public partial class User : Window
    {
        Entities entities = new Entities();
        
        public User()
        {
            InitializeComponent();
            try
            {
            UserName.Content = Class_Login.Sname + " " + Class_Login.Fname + " " + Class_Login.FAname;

            switch (Class_Login.IdProduct)
            {
                case 1:
                    foreach (var item in entities.CPU)
                    {
                            if (item.Pic == null)
                            {
                                item.Pic = @"E:\Курсовая\WpfApp3\WpfApp3\logo.png";
                            }
                            products_list.Items.Add(item);
                    }
                    break;
                case 2:
                    foreach (var item in entities.Motherboard)
                    {
                            if (item.Pic == null)
                            {
                                item.Pic = @"E:\Курсовая\WpfApp3\WpfApp3\logo.png";
                            }
                            products_list.Items.Add(item);
                    }
                    break;
                case 3:
                    foreach (var item in entities.VideoCard)
                    {
                            if (item.Pic == null)
                            {
                                item.Pic = @"E:\Курсовая\WpfApp3\WpfApp3\logo.png";
                            }
                            products_list.Items.Add(item);
                    }
                    break;
                case 4:
                    foreach (var item in entities.PowerUnit)
                    {
                            if (item.Pic == null)
                            {
                                item.Pic = @"E:\Курсовая\WpfApp3\WpfApp3\logo.png";
                            }
                            products_list.Items.Add(item);
                    }
                    break;
                case 5:
                    foreach (var item in entities.RAM)
                    {
                            if (item.Pic == null)
                            {
                                item.Pic = @"E:\Курсовая\WpfApp3\WpfApp3\logo.png";
                            }
                            products_list.Items.Add(item);
                    }
                    break;
                case 6:
                    foreach (var item in entities.Monitor)
                    {
                            if (item.Pic == null)
                            {
                                item.Pic = @"E:\Курсовая\WpfApp3\WpfApp3\logo.png";
                            }
                            products_list.Items.Add(item);
                    }
                    break;
                case 7:
                    foreach (var item in entities.HDD)
                    {
                            if (item.Pic == null)
                            {
                                item.Pic = @"E:\Курсовая\WpfApp3\WpfApp3\logo.png";
                            }
                            products_list.Items.Add(item);
                    }
                    break;
                case 8:
                    foreach (var item in entities.Cases)
                    {
                            if (item.Pic == null)
                            {
                                item.Pic = @"E:\Курсовая\WpfApp3\WpfApp3\logo.png";
                            }
                            products_list.Items.Add(item);
                    }
                    break;
            }
        }
            catch
            {
                MessageBox.Show("Ошибка работы базы данных");
            }
        }

        private void basket_of_products_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Basket_Window();
            window_.Show();
            this.Close();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (Class_Login.IdProduct)
            {
                case 1:
                    products_list.Items.Clear();
                    foreach (var item in entities.CPU)
                    {
                        if (search.Text != "")
                        {
                            if (item.Model.ToLower().Trim().Contains(search.Text.Trim().ToLower()))
                            {
                                products_list.Items.Add(item);
                            }
                        }
                        else
                        {
                            products_list.Items.Add(item);
                        }
                    }
                    break;
                case 2:
                    products_list.Items.Clear();
                    foreach (var item in entities.Motherboard)
                    {
                        if (search.Text != "")
                        {
                            if (item.Model.ToLower().Trim().Contains(search.Text.Trim().ToLower()))
                            {
                                products_list.Items.Add(item);
                            }
                        }
                        else
                        {
                            products_list.Items.Add(item);
                        }
                    }
                    break;
                case 3:
                    products_list.Items.Clear();
                    foreach (var item in entities.VideoCard)
                    {
                        if (search.Text != "")
                        {
                            if (item.Model.ToLower().Trim().Contains(search.Text.Trim().ToLower()))
                            {
                                products_list.Items.Add(item);
                            }
                        }
                        else
                        {
                            products_list.Items.Add(item);
                        }
                    }
                    break;
                case 4:
                    products_list.Items.Clear();
                    foreach (var item in entities.PowerUnit)
                    {
                        if (search.Text != "")
                        {
                            if (item.Model.ToLower().Trim().Contains(search.Text.Trim().ToLower()))
                            {
                                products_list.Items.Add(item);
                            }
                        }
                        else
                        {
                            products_list.Items.Add(item);
                        }
                    }
                    break;
                case 5:
                    products_list.Items.Clear();
                    foreach (var item in entities.RAM)
                    {
                        if (search.Text != "")
                        {
                            if (item.Model.ToLower().Trim().Contains(search.Text.Trim().ToLower()))
                            {
                                products_list.Items.Add(item);
                            }
                        }
                        else
                        {
                            products_list.Items.Add(item);
                        }
                    }
                    break;
                case 6:
                    products_list.Items.Clear();
                    foreach (var item in entities.Monitor)
                    {
                        if (search.Text != "")
                        {
                            if (item.Model.ToLower().Trim().Contains(search.Text.Trim().ToLower()))
                            {
                                products_list.Items.Add(item);
                            }
                        }
                        else
                        {
                            products_list.Items.Add(item);
                        }
                    }
                    break;
                case 7:
                    products_list.Items.Clear();
                    foreach (var item in entities.HDD)
                    {
                        if (search.Text != "")
                        {
                            if (item.Model.ToLower().Trim().Contains(search.Text.Trim().ToLower()))
                            {
                                products_list.Items.Add(item);
                            }
                        }
                        else
                        {
                            products_list.Items.Add(item);
                        }
                    }
                    break;
                case 8:
                    products_list.Items.Clear();
                    foreach (var item in entities.Cases)
                    {
                        if (search.Text != "")
                        {
                            if (item.Model.ToLower().Trim().Contains(search.Text.Trim().ToLower()))
                            {
                                products_list.Items.Add(item);
                            }
                        }
                        else
                        {
                            products_list.Items.Add(item);
                        }
                    }
                    break;
            }
        }

        private void go_back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Products_Win();
            window_.Show();
            this.Close();
        }

        private void orders_products_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Orders_Window();
            window_.Show();
            this.Close();
        }

        private void products_list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            switch (Class_Login.IdProduct)
            {
                case 1:
                        
                        var selectedCPU = products_list.SelectedItem as CPU;
                        Class_Login.Id = selectedCPU.Id_Processor;
                    if (selectedCPU == null)
                    {
                        MessageBox.Show("Выберите товар из списка!");
                    }
                    break;
                case 2:
                    var selectedMB = products_list.SelectedItem as Motherboard;
                    Class_Login.Id = selectedMB.Id_Motherboard;
                    if (selectedMB == null)
                    {
                        MessageBox.Show("Выберите товар из списка!");
                    }
                    break;
                case 3:
                    var selectedVC = products_list.SelectedItem as VideoCard;
                    Class_Login.Id = selectedVC.Id_VideoCard;
                    if (selectedVC == null)
                    {
                        MessageBox.Show("Выберите товар из списка!");
                    }
                    break;
                case 4:
                    var selectedPU = products_list.SelectedItem as PowerUnit;
                    Class_Login.Id = selectedPU.Id_PowerUnit;
                    if (selectedPU == null)
                    {
                        MessageBox.Show("Выберите товар из списка!");
                    }
                    break;
                case 5:
                    var selectedRAM = products_list.SelectedItem as RAM;
                    Class_Login.Id = selectedRAM.Id_RAM;
                    if (selectedRAM == null)
                    {
                        MessageBox.Show("Выберите товар из списка!");
                    }
                    break;
                case 6:
                    var selectedMonitor = products_list.SelectedItem as Monitor;
                    Class_Login.Id = selectedMonitor.Id_Monitor;
                    if (selectedMonitor == null)
                    {
                        MessageBox.Show("Выберите товар из списка!");
                    }
                    break;
                case 7:
                    var selectedHDD = products_list.SelectedItem as HDD;
                    Class_Login.Id = selectedHDD.Id_HDD;
                    if (selectedHDD == null)
                    {
                        MessageBox.Show("Выберите товар из списка!");
                    }
                    break;
                case 8:
                    var selectedCases = products_list.SelectedItem as Cases;
                    Class_Login.Id = selectedCases.Id_Case;
                    if (selectedCases == null)
                    {
                        MessageBox.Show("Выберите товар из списка!");
                    }
                    break;
            }

                var window_ = new DetailProduct();
                window_.Show();
                this.Close();
        }

        private void SearchPrice_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                products_list.Items.Clear();
                if (MinPrice.Text == "")
                {
                    MinPrice.Text = "0";
                }
                if (MaxPrice.Text == "")
                {
                    MaxPrice.Text = "0";
                }

            switch (Class_Login.IdProduct)
            {

                case 1:

                    foreach (var CPUItem in entities.CPU)
                    {
                        if (CPUItem.Coast <= Convert.ToInt32(MaxPrice.Text) && CPUItem.Coast >= Convert.ToInt32(MinPrice.Text))
                        {
                            products_list.Items.Add(CPUItem);
                        }
                    }
                    break;
                case 2:

                    foreach (var MotherboardItem in entities.Motherboard)
                    {
                        if (MotherboardItem.Coast <= Convert.ToInt32(MaxPrice.Text) && MotherboardItem.Coast >= Convert.ToInt32(MinPrice.Text))
                        {
                            products_list.Items.Add(MotherboardItem);
                        }
                    }
                    break;
                case 3:

                    foreach (var VCItem in entities.VideoCard)
                    {
                        if (VCItem.Coast <= Convert.ToInt32(MaxPrice.Text) && VCItem.Coast >= Convert.ToInt32(MinPrice.Text))
                        {
                            products_list.Items.Add(VCItem);
                        }
                    }
                    break;
                case 4:

                    foreach (var PUItem in entities.PowerUnit)
                    {
                        if (PUItem.Coast <= Convert.ToInt32(MaxPrice.Text) && PUItem.Coast >= Convert.ToInt32(MinPrice.Text))
                        {
                            products_list.Items.Add(PUItem);
                        }
                    }
                    break;
                case 5:
                    foreach (var RAMItem in entities.RAM)
                    {
                        if (RAMItem.Coast <= Convert.ToInt32(MaxPrice.Text) && RAMItem.Coast >= Convert.ToInt32(MinPrice.Text))
                        {
                            products_list.Items.Add(RAMItem);
                        }
                    }
                    break;
                case 6:
                    foreach (var MonitorItem in entities.Monitor)
                    {
                        if (MonitorItem.Coast <= Convert.ToInt32(MaxPrice.Text) && MonitorItem.Coast >= Convert.ToInt32(MinPrice.Text))
                        {
                            products_list.Items.Add(MonitorItem);
                        }
                    }
                    break;
                case 7:
                    foreach (var HDDItem in entities.HDD)
                    {
                        if (HDDItem.Coast <= Convert.ToInt32(MaxPrice.Text) && HDDItem.Coast >= Convert.ToInt32(MinPrice.Text))
                        {
                            products_list.Items.Add(HDDItem);
                        }
                    }
                    break;
                case 8:
                    foreach (var CaseItem in entities.Cases)
                    {
                        if (CaseItem.Coast <= Convert.ToInt32(MaxPrice.Text) && CaseItem.Coast >= Convert.ToInt32(MinPrice.Text))
                        {
                            products_list.Items.Add(CaseItem);
                        }
                    }
                    break;
            }
        }
            catch
            {
                MessageBox.Show("Вы ввели не число!!!");
            }
        }

        private void CancelSearch_Click(object sender, RoutedEventArgs e)
        {
            products_list.Items.Clear();
            MinPrice.Clear();
            MaxPrice.Clear();
            try
            {
                switch (Class_Login.IdProduct)
                {
                    case 1:
                        foreach (var item in entities.CPU)
                        {
                            products_list.Items.Add(item);
                        }
                        break;
                    case 2:
                        foreach (var item in entities.Motherboard)
                        {
                            products_list.Items.Add(item);
                        }
                        break;
                    case 3:
                        foreach (var item in entities.VideoCard)
                        {
                            products_list.Items.Add(item);
                        }
                        break;
                    case 4:
                        foreach (var item in entities.PowerUnit)
                        {
                            products_list.Items.Add(item);
                        }
                        break;
                    case 5:
                        foreach (var item in entities.RAM)
                        {
                            products_list.Items.Add(item);
                        }
                        break;
                    case 6:
                        foreach (var item in entities.Monitor)
                        {
                            products_list.Items.Add(item);
                        }
                        break;
                    case 7:
                        foreach (var item in entities.HDD)
                        {
                            products_list.Items.Add(item);
                        }
                        break;
                    case 8:
                        foreach (var item in entities.Cases)
                        {
                            products_list.Items.Add(item);
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы базы данных");
            }
        }

        private void UserImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Registration();
            window_.Show();
            this.Close();
        }
    }
}




