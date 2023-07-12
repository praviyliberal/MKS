using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
    public partial class Basket_Window : Window
    {
        Entities entities = new Entities();
        public string Name = Class_Login.Sname + " " + Class_Login.Fname + " " + Class_Login.FAname;
        public int Acc = 0;
        public Basket_Window()
        {
            InitializeComponent();

            foreach (var item in entities.PickUp)
            {
                PickUpCombo.Items.Add(item);
            }

            try
            {
                foreach (var basketitem in entities.Basket)
                {
                    foreach (var CPUItem in entities.CPU)
                        if (CPUItem.Id_Processor == basketitem.Id_Processor && basketitem.Id_User == Class_Login.Id_users)
                        {
                            products_list.Items.Add(CPUItem);
                            Acc += Convert.ToInt32(CPUItem.Coast) * Convert.ToInt32(basketitem.Count);
                        }
                    foreach (var MBItem in entities.Motherboard)
                        if (MBItem.Id_Motherboard == basketitem.Id_Motherboard && basketitem.Id_User == Class_Login.Id_users)
                        {
                            products_list.Items.Add(MBItem);
                            Acc += Convert.ToInt32(MBItem.Coast) * Convert.ToInt32(basketitem.Count);
                        }
                    foreach (var VCItem in entities.VideoCard)
                        if (VCItem.Id_VideoCard == basketitem.Id_VideoCard && basketitem.Id_User == Class_Login.Id_users)
                        {
                            products_list.Items.Add(VCItem);
                            Acc += Convert.ToInt32(VCItem.Coast) * Convert.ToInt32(basketitem.Count);
                        }
                    foreach (var PUItem in entities.PowerUnit)
                        if (PUItem.Id_PowerUnit == basketitem.Id_PowerUnit && basketitem.Id_User == Class_Login.Id_users)
                        {
                            products_list.Items.Add(PUItem);
                            Acc += Convert.ToInt32(PUItem.Coast) * Convert.ToInt32(basketitem.Count);
                        }
                    foreach (var CaseItem in entities.Cases)
                        if (CaseItem.Id_Case == basketitem.Id_Case && basketitem.Id_User == Class_Login.Id_users)
                        {
                            products_list.Items.Add(CaseItem);
                            Acc += Convert.ToInt32(CaseItem.Coast) * Convert.ToInt32(basketitem.Count);
                        }
                    foreach (var HDDItem in entities.HDD)
                        if (HDDItem.Id_HDD == basketitem.Id_HDD && basketitem.Id_User == Class_Login.Id_users)
                        {
                            products_list.Items.Add(HDDItem);
                            Acc += Convert.ToInt32(HDDItem.Coast) * Convert.ToInt32(basketitem.Count);
                        }
                    foreach (var RAMItem in entities.RAM)
                        if (RAMItem.Id_RAM == basketitem.Id_RAM && basketitem.Id_User == Class_Login.Id_users)
                        {
                            products_list.Items.Add(RAMItem);
                            Acc += Convert.ToInt32(RAMItem.Coast) * Convert.ToInt32(basketitem.Count);
                        }
                    foreach (var MonitorItem in entities.Monitor)
                        if (MonitorItem.Id_Monitor == basketitem.Id_Monitor && basketitem.Id_User == Class_Login.Id_users)
                        {
                            products_list.Items.Add(MonitorItem);
                            Acc += Convert.ToInt32(MonitorItem.Coast) * Convert.ToInt32(basketitem.Count);
                        }                      
                }
                full_price.Content = Acc.ToString() + " руб.";
            }
            catch
            {
                MessageBox.Show("Ошибка работы базы данных");
            }
        }

        private void go_back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Products_Win();
            window_.Show();
            this.Close();
        }

        private void get_order_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (products_list.Items.Count == 0)
                {
                    MessageBox.Show("Ваша корзина пуста!!!");
                }
                else
                {
                    Random ran = new Random();
                    var NewOrder = new Orders();
                    NewOrder.TimeOrder = DateTime.Now;
                    NewOrder.Status = "В пути";
                    NewOrder.Id_User = Class_Login.Id_users;
                    NewOrder.CodeOrder = Convert.ToString(ran.Next(100, 999));
                    if (PickUpCombo.SelectedItem == null)
                    {
                        MessageBox.Show("!!!");
                    }
                    else
                    {
                        NewOrder.Id_PickUp = (PickUpCombo.SelectedItem as PickUp).Id_PickUp;
                        entities.Orders.Add(NewOrder);

                        entities.SaveChanges();
                    }

                    CreateCheck.Code = NewOrder.CodeOrder;
                    CreateCheck.ID = NewOrder.Id_Order;
                    CreateCheck.CreateDate = NewOrder.TimeOrder;
                    if (PickUpCombo.SelectedItem != null)
                    {
                        CreateCheck.PickUpName = (PickUpCombo.SelectedItem as PickUp).Name;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали пункт выдачи!");
                    }
                    int Acc = 0;
                    foreach (var item in entities.Basket)
                    {
                        if (item.Id_Case != null)
                        {
                            foreach (var Case in entities.Cases)
                            {
                                if (Case.Id_Case == item.Id_Case && item.Id_User == Class_Login.Id_users)
                                {
                                    var order = new TovarToOrder();
                                    order.Id_User = Class_Login.Id_users;
                                    order.Id_Case = Case.Id_Case;
                                    order.Count = item.Count;
                                    Acc += Convert.ToInt32(Case.Coast) * Convert.ToInt32(item.Count);
                                    order.Id_Order = NewOrder.Id_Order;
                                    entities.TovarToOrder.Add(order);
                                }
                            }
                        }
                        if (item.Id_Processor != null)
                        {
                            foreach (var CPU in entities.CPU)
                            {
                                if (CPU.Id_Processor == item.Id_Processor && item.Id_User == Class_Login.Id_users)
                                {
                                    var order = new TovarToOrder();
                                    order.Id_User = Class_Login.Id_users;
                                    order.Id_Processor = CPU.Id_Processor;
                                    order.Count = item.Count;
                                    Acc += Convert.ToInt32(CPU.Coast) * Convert.ToInt32(item.Count);
                                    order.Id_Order = NewOrder.Id_Order;
                                    entities.TovarToOrder.Add(order);
                                }
                            }
                        }
                        if (item.Id_HDD != null)
                        {
                            foreach (var HDD in entities.HDD)
                            {
                                if (HDD.Id_HDD == item.Id_HDD && item.Id_User == Class_Login.Id_users)
                                {
                                    var order = new TovarToOrder();
                                    order.Id_User = Class_Login.Id_users;
                                    order.Id_HDD = HDD.Id_HDD;
                                    order.Count = item.Count;
                                    Acc += Convert.ToInt32(HDD.Coast) * Convert.ToInt32(item.Count);
                                    order.Id_Order = NewOrder.Id_Order;
                                    entities.TovarToOrder.Add(order);
                                }
                            }
                        }
                        if (item.Id_Monitor != null)
                        {
                            foreach (var Monitor in entities.Monitor)
                            {
                                if (Monitor.Id_Monitor == item.Id_Monitor && item.Id_User == Class_Login.Id_users)
                                {
                                    var order = new TovarToOrder();
                                    order.Id_User = Class_Login.Id_users;
                                    order.Id_Monitor = Monitor.Id_Monitor;
                                    order.Count = item.Count;
                                    Acc += Convert.ToInt32(Monitor.Coast) * Convert.ToInt32(item.Count);
                                    order.Id_Order = NewOrder.Id_Order;
                                    entities.TovarToOrder.Add(order);
                                }
                            }
                        }
                        if (item.Id_Motherboard != null)
                        {
                            foreach (var MB in entities.Motherboard)
                            {
                                if (MB.Id_Motherboard == item.Id_Motherboard && item.Id_User == Class_Login.Id_users)
                                {
                                    var order = new TovarToOrder();
                                    order.Id_User = Class_Login.Id_users;
                                    order.Id_Motherboard = MB.Id_Motherboard;
                                    order.Count = item.Count;
                                    Acc += Convert.ToInt32(MB.Coast) * Convert.ToInt32(item.Count);
                                    order.Id_Order = NewOrder.Id_Order;
                                    entities.TovarToOrder.Add(order);
                                }
                            }
                        }
                        if (item.Id_PowerUnit != null)
                        {
                            foreach (var PU in entities.PowerUnit)
                            {
                                if (PU.Id_PowerUnit == item.Id_PowerUnit && item.Id_User == Class_Login.Id_users)
                                {
                                    var order = new TovarToOrder();
                                    order.Id_User = Class_Login.Id_users;
                                    order.Id_PowerUnit = PU.Id_PowerUnit;
                                    order.Count = item.Count;
                                    Acc += Convert.ToInt32(PU.Coast) * Convert.ToInt32(item.Count);
                                    order.Id_Order = NewOrder.Id_Order;
                                    entities.TovarToOrder.Add(order);
                                }
                            }
                        }
                        if (item.Id_RAM != null)
                        {
                            foreach (var RAM in entities.RAM)
                            {
                                if (RAM.Id_RAM == item.Id_RAM && item.Id_User == Class_Login.Id_users)
                                {
                                    var order = new TovarToOrder();
                                    order.Id_User = Class_Login.Id_users;
                                    order.Id_RAM = RAM.Id_RAM;
                                    order.Count = item.Count;
                                    Acc += Convert.ToInt32(RAM.Coast) * Convert.ToInt32(item.Count);
                                    order.Id_Order = NewOrder.Id_Order;
                                    entities.TovarToOrder.Add(order);
                                }
                            }
                        }
                        if (item.Id_VideoCard != null)
                        {
                            foreach (var VC in entities.VideoCard)
                            {
                                if (VC.Id_VideoCard == item.Id_VideoCard && item.Id_User == Class_Login.Id_users)
                                {
                                    var order = new TovarToOrder();
                                    order.Id_User = Class_Login.Id_users;
                                    order.Id_VideoCard = VC.Id_VideoCard;
                                    order.Count = item.Count;
                                    Acc += Convert.ToInt32(VC.Coast) * Convert.ToInt32(item.Count);
                                    order.Id_Order = NewOrder.Id_Order;
                                    entities.TovarToOrder.Add(order);
                                }
                            }
                        }
                    }
                    NewOrder.Price = Acc;
                    entities.SaveChanges();
                    MessageBox.Show("Заказ успешно оформлен!");
                    var window_ = new CheckWindow();
                    window_.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы прогаммы!");
            }      
        }

        private void get_some_prod_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (products_list.SelectedItem != null)
                {

                    full_price.Content = Acc.ToString();
                }
                else
                {
                    MessageBox.Show("Выберите элемент из списка");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали товар, нажмите на элемент списка");
            }
        }

        private void delete_prod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (products_list.SelectedItems != null)
                {
                    var Tovar = products_list.SelectedItem;

                    if (Tovar is Cases)
                    {
                        var Tovar2 = products_list.SelectedItem as Cases;
                        foreach (var item in entities.Basket)
                        {
                            if (Tovar2.Id_Case == item.Id_Case)
                            {
                                entities.Basket.Remove(item);
                                products_list.Items.Remove(Tovar);
                                Acc -= Convert.ToInt32(Tovar2.Coast) * Convert.ToInt32(item.Count);
                                full_price.Content = Acc.ToString() + " руб.";
                            }
                        }
                        entities.SaveChanges();
                    }
                    else if (Tovar is CPU)
                    {
                        var Tovar2 = products_list.SelectedItem as CPU;
                        foreach (var item in entities.Basket)
                        {
                            if (Tovar2.Id_Processor == item.Id_Processor)
                            {
                                entities.Basket.Remove(item);
                                products_list.Items.Remove(Tovar);
                                Acc -= Convert.ToInt32(Tovar2.Coast) * Convert.ToInt32(item.Count);
                                full_price.Content = Acc.ToString() + " руб.";
                            }
                        }
                        entities.SaveChanges();
                    }
                    else if (Tovar is HDD)
                    {
                        var Tovar2 = products_list.SelectedItem as HDD;
                        foreach (var item in entities.Basket)
                        {
                            if (Tovar2.Id_HDD == item.Id_HDD)
                            {
                                entities.Basket.Remove(item);
                                products_list.Items.Remove(Tovar);
                                Acc -= Convert.ToInt32(Tovar2.Coast) * Convert.ToInt32(item.Count);
                                full_price.Content = Acc.ToString() + " руб.";
                            }
                        }
                        entities.SaveChanges();
                    }
                    else if (Tovar is Monitor)
                    {
                        var Tovar2 = products_list.SelectedItem as Monitor;
                        foreach (var item in entities.Basket)
                        {
                            if (Tovar2.Id_Monitor == item.Id_Monitor)
                            {
                                entities.Basket.Remove(item);
                                products_list.Items.Remove(Tovar);
                                Acc -= Convert.ToInt32(Tovar2.Coast) * Convert.ToInt32(item.Count);
                                full_price.Content = Acc.ToString() + " руб.";
                            }
                        }
                        entities.SaveChanges();
                    }
                    else if (Tovar is Motherboard)
                    {
                        var Tovar2 = products_list.SelectedItem as Motherboard;
                        foreach (var item in entities.Basket)
                        {
                            if (Tovar2.Id_Motherboard == item.Id_Motherboard)
                            {
                                entities.Basket.Remove(item);
                                products_list.Items.Remove(Tovar);
                                Acc -= Convert.ToInt32(Tovar2.Coast) * Convert.ToInt32(item.Count);
                                full_price.Content = Acc.ToString() + " руб.";
                            }
                        }
                        entities.SaveChanges();
                    }
                    else if (Tovar is PowerUnit)
                    {
                        var Tovar2 = products_list.SelectedItem as PowerUnit;
                        foreach (var item in entities.Basket)
                        {
                            if (Tovar2.Id_PowerUnit == item.Id_PowerUnit)
                            {
                                entities.Basket.Remove(item);
                                products_list.Items.Remove(Tovar);
                                Acc -= Convert.ToInt32(Tovar2.Coast) * Convert.ToInt32(item.Count);
                                full_price.Content = Acc.ToString() + " руб.";
                            }
                        }
                        entities.SaveChanges();
                    }
                    else if (Tovar is RAM)
                    {
                        var Tovar2 = products_list.SelectedItem as RAM;
                        foreach (var item in entities.Basket)
                        {
                            if (Tovar2.Id_RAM == item.Id_RAM)
                            {
                                entities.Basket.Remove(item);
                                products_list.Items.Remove(Tovar);
                                Acc -= Convert.ToInt32(Tovar2.Coast) * Convert.ToInt32(item.Count);
                                full_price.Content = Acc.ToString() + " руб.";
                            }
                        }
                        entities.SaveChanges();
                    }
                    else if (Tovar is VideoCard)
                    {
                        var Tovar2 = products_list.SelectedItem as VideoCard;
                        foreach (var item in entities.Basket)
                        {
                            if (Tovar2.Id_VideoCard == item.Id_VideoCard)
                            {
                                entities.Basket.Remove(item);
                                products_list.Items.Remove(Tovar2);
                                Acc -= Convert.ToInt32(Tovar2.Coast) * Convert.ToInt32(item.Count);
                                full_price.Content = Acc.ToString() + " руб.";
                            }
                        }
                        products_list.Items.Refresh();
                        entities.SaveChanges();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали элемент для удаления");
            }
        }

        private void CheckComp_Click(object sender, RoutedEventArgs e)
        {
            bool flagCPU = false;
            bool flagVC = false;
            bool flagMB = false;
            bool flagCase = false;
            bool flagMonitor = false;
            bool flagRAM = false;
            bool flagHDD = false;
            bool flagPU = false;
            bool flagPower = false;
            bool flagSoket = false;
            bool flagMemory = false;

            int PowerHave = 0;
            int PowerNeed = 0;
            int RAMSlots = 0;
            int MBSlots = 0;

            string SoketCPU = "";
            string SoketMB = "";


            foreach (var item in entities.Basket)
            {
                if (item.Id_Processor != null && item.Id_User == Class_Login.Id_users)
                {
                    flagCPU = true;
                    foreach (var kekis in entities.CPU)
                    {
                        if (kekis.Id_Processor == item.Id_Processor)
                        {
                            SoketCPU = kekis.Soket.Trim().ToLower();
                        }
                    }
                }
                else if (item.Id_HDD != null && item.Id_User == Class_Login.Id_users)
                {
                    flagHDD = true;
                }
                else if (item.Id_VideoCard != null && item.Id_User == Class_Login.Id_users)
                {
                    flagVC = true;
                    foreach (var kekis in entities.VideoCard)
                    {
                        if (kekis.Id_VideoCard == item.Id_VideoCard)
                        {
                            PowerNeed += Convert.ToInt32(kekis.Power_Unit);
                        }
                    }
                }
                else if (item.Id_Monitor != null && item.Id_User == Class_Login.Id_users)
                {
                    flagMonitor = true;
                    foreach (var kekis in entities.Monitor)
                    {
                        if (kekis.Id_Monitor == item.Id_Monitor)
                        {
                            PowerNeed += Convert.ToInt32(kekis.PowerNeed);
                        }
                    }
                    
                }
                else if (item.Id_Motherboard != null && item.Id_User == Class_Login.Id_users)
                {
                    flagMB = true;
                    foreach (var kekis in entities.Motherboard)
                    {
                        if (kekis.Id_Motherboard == item.Id_Motherboard)
                        {
                            SoketMB = kekis.Soket.Trim().ToLower();
                            MBSlots = kekis.Memory_slots;
                        }
                    }
                }
                else if (item.Id_PowerUnit != null && item.Id_User == Class_Login.Id_users)
                {
                    flagPU = true;
                    foreach (var kekis in entities.PowerUnit)
                    {
                        if (kekis.Id_PowerUnit == item.Id_PowerUnit)
                        {
                            PowerHave = Convert.ToInt32(kekis.Power);
                        }
                    }
                }
                if (item.Id_RAM != null && item.Id_User == Class_Login.Id_users)
                {
                    flagRAM = true;
                    foreach (var kekis in entities.RAM)
                    {
                        if (kekis.Id_RAM == item.Id_RAM)
                        {
                            RAMSlots = Convert.ToInt32(kekis.Count_RAM);
                        }
                    }
                }
                else if (item.Id_Case != null && item.Id_User == Class_Login.Id_users)
                {
                    flagCase = true;
                }
            }
            if (MBSlots < RAMSlots)
            {
                MessageBox.Show("В вашей материнской плате не хватает слотов для оперативной памяти! Доступно " + MBSlots + " слотов");
            }
            else
            {
                flagMemory = true;
            }
            if (SoketCPU != SoketMB)
            {
                MessageBox.Show("В вашей сборке не подходят центральный процессор к материнской плате! Подберите процессор с сокетом " + SoketCPU);   
            }
            else
            {
                flagSoket = true;
            }
            if (PowerHave < PowerNeed)
            {
                MessageBox.Show("Вашей сборке не хватает мощности блока питания! Минимальная требуемая мощность состовляет " + PowerNeed.ToString());
            }
            else
            {
                flagPower = true;
            }
            if (flagMemory == true && flagSoket == true && flagRAM == true && flagPU == true && flagPower == true && flagVC == true && flagMB == true && flagHDD == true && flagMonitor == true && flagCase == true && flagCPU == true)
            {
                MessageBox.Show("Компоненты вашей сборки сочетаются друг с другом");
            }
            if (flagCPU == false)
            {
                MessageBox.Show("В сборке не хватает центрального процессора! Проверьте правильность сборки");
            }
            if(flagHDD == false)
            {
                MessageBox.Show("В сборке не хватает жесткого диска! Проверьте правильность сборки");
            }
            if(flagVC == false)
            {
                MessageBox.Show("В сборке не хватает видеокарты! Проверьте правильность сборки");
            }
            if(flagRAM == false)
            {
                MessageBox.Show("В сборке не хватает оперативной памяти! Проверьте правильность сборки");
            }
            if(flagPU == false)
            {
                MessageBox.Show("В сборке не хватает блока питания! Проверьте правильность сборки");
            }
            if(flagMonitor == false)
            {
                MessageBox.Show("В сборке не хватает монитора! Проверьте правильность сборки");
            }
            if(flagCase == false)
            {
                MessageBox.Show("В сборке не хватает корпуса! Проверьте правильность сборки");
            }
            if (flagMB == false)
            {
                MessageBox.Show("В сборке не хватает материнской платы! Проверьте правильность сборки");
            }
        }

        private void products_list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (products_list.SelectedItems != null)
                {
                    var Tovar = products_list.SelectedItem;

                    if (Tovar is Cases)
                    {
                        var Tovar2 = products_list.SelectedItem as Cases;
                        Class_Login.IdProduct = 8;
                        Class_Login.Id = Tovar2.Id_Case;

                    }
                    else if (Tovar is CPU)
                    {
                        var Tovar2 = products_list.SelectedItem as CPU;
                        Class_Login.IdProduct = 1;
                        Class_Login.Id = Convert.ToInt32(Tovar2.Id_Processor);
                    }
                    else if (Tovar is HDD)
                    {
                        var Tovar2 = products_list.SelectedItem as HDD;
                        Class_Login.IdProduct = 7;
                        Class_Login.Id = Convert.ToInt32(Tovar2.Id_HDD);
                    }
                    else if (Tovar is Monitor)
                    {
                        var Tovar2 = products_list.SelectedItem as Monitor;
                        Class_Login.IdProduct = 6;
                        Class_Login.Id = Convert.ToInt32(Tovar2.Id_Monitor);
                    }
                    else if (Tovar is Motherboard)
                    {
                        var Tovar2 = products_list.SelectedItem as Motherboard;
                        Class_Login.IdProduct = 2;
                        Class_Login.Id = Convert.ToInt32(Tovar2.Id_Motherboard);
                    }
                    else if (Tovar is PowerUnit)
                    {
                        var Tovar2 = products_list.SelectedItem as PowerUnit;
                        Class_Login.IdProduct = 4;
                        Class_Login.Id = Convert.ToInt32(Tovar2.Id_PowerUnit);
                    }
                    else if (Tovar is RAM)
                    {
                        var Tovar2 = products_list.SelectedItem as RAM;
                        Class_Login.IdProduct = 5;
                        Class_Login.Id = Convert.ToInt32(Tovar2.Id_RAM);
                    }
                    else if (Tovar is VideoCard)
                    {
                        var Tovar2 = products_list.SelectedItem as VideoCard;
                        Class_Login.IdProduct = 3;
                        Class_Login.Id = Convert.ToInt32(Tovar2.Id_VideoCard);
                    }
                    var window_ = new DetailProduct();
                    window_.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали элемент для удаления");
            }
        }
    }
}