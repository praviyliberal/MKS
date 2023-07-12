using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
    public partial class OrdersInfo : Window
    {
        Entities entities = new Entities();
        public OrdersInfo()
        {
            InitializeComponent();
            int FullCost = 0;
            int acc = 0;
            txtOrdersInfo.Text += "\n В период с " + InfoOrders.Start + " по " + InfoOrders.End + "\n";
            foreach (var date_ in entities.Orders)
            {
                foreach (var item in entities.TovarToOrder)
                {
                    if (date_.Id_Order == item.Id_Order)
                    { 
                        if (date_.TimeOrder >= InfoOrders.Start && date_.TimeOrder <= InfoOrders.End)
                        {
                            if (item.Id_Processor != null)
                            {
                                foreach (var CPU in entities.CPU)
                                {
                                    if (CPU.Id_Processor == item.Id_Processor)
                                    {
                                        acc++;
                                        FullCost += Convert.ToInt32(CPU.Coast);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            txtOrdersInfo.Text += "\n Процессоры: " + acc + " шт. " + "Сумма прибыли: " + FullCost + " руб.";
            acc = 0;
            FullCost = 0;
            foreach (var date_ in entities.Orders)
            {
                foreach (var item in entities.TovarToOrder)
                {
                    if (date_.Id_Order == item.Id_Order)
                    {
                        if (date_.TimeOrder >= InfoOrders.Start && date_.TimeOrder <= InfoOrders.End)
                        {
                            if (item.Id_Case != null)
                            {
                                foreach (var Cases in entities.Cases)
                                {
                                    if (Cases.Id_Case == item.Id_Case)
                                    {
                                        acc++;
                                        FullCost += Convert.ToInt32(Cases.Coast);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            txtOrdersInfo.Text += "\n Корпусы: " + acc + " шт. " + "Сумма прибыли: " + FullCost + " руб.";
            acc = 0;
            FullCost = 0;
            foreach (var date_ in entities.Orders)
            {
                foreach (var item in entities.TovarToOrder)
                {
                    if (date_.Id_Order == item.Id_Order)
                    {
                        if (date_.TimeOrder >= InfoOrders.Start && date_.TimeOrder <= InfoOrders.End)
                        {
                            if (item.Id_Motherboard != null)
                            {
                                foreach (var MB in entities.Motherboard)
                                {
                                    if (MB.Id_Motherboard == item.Id_Motherboard)
                                    {
                                        acc++;
                                        FullCost += Convert.ToInt32(MB.Coast);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            txtOrdersInfo.Text += "\n Материнские платы: " + acc + " шт. " + "Сумма прибыли: " + FullCost + "руб.";
            acc = 0;
            FullCost = 0;
            foreach (var date_ in entities.Orders)
            {
                foreach (var item in entities.TovarToOrder)
                {
                    if (date_.Id_Order == item.Id_Order)
                    {
                        if (date_.TimeOrder >= InfoOrders.Start && date_.TimeOrder <= InfoOrders.End)
                        {
                            if (item.Id_HDD != null)
                            {
                                foreach (var HDD in entities.HDD)
                                {
                                    if (HDD.Id_HDD == item.Id_HDD)
                                    {
                                        acc++;
                                        FullCost += Convert.ToInt32(HDD.Coast);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            txtOrdersInfo.Text += "\n Жесткие диски: " + acc + " шт. " + "Сумма прибыли: " + FullCost + " руб.";
            acc = 0;
            FullCost = 0;
            foreach (var date_ in entities.Orders)
            {
                foreach (var item in entities.TovarToOrder)
                {
                    if (date_.Id_Order == item.Id_Order)
                    {
                        if (date_.TimeOrder >= InfoOrders.Start && date_.TimeOrder <= InfoOrders.End)
                        {
                            if (item.Id_Monitor != null)
                            {
                                foreach (var Monitor in entities.Monitor)
                                {
                                    if (Monitor.Id_Monitor == item.Id_Monitor)
                                    {
                                        acc++;
                                        FullCost += Convert.ToInt32(Monitor.Coast);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            txtOrdersInfo.Text += "\n Мониторы: " + acc + " шт. " + "Сумма прибыли: " + FullCost + " руб.";
            acc = 0;
            FullCost = 0;
            foreach (var date_ in entities.Orders)
            {
                foreach (var item in entities.TovarToOrder)
                {
                    if (date_.Id_Order == item.Id_Order)
                    {
                        if (date_.TimeOrder >= InfoOrders.Start && date_.TimeOrder <= InfoOrders.End)
                        {
                            if (item.Id_PowerUnit != null)
                            {
                                foreach (var PU in entities.PowerUnit)
                                {
                                    if (PU.Id_PowerUnit == item.Id_PowerUnit)
                                    {
                                        acc++;
                                        FullCost += Convert.ToInt32(PU.Coast);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            txtOrdersInfo.Text += "\n Блоки питания: " + acc + " шт. " + "Сумма прибыли: " + FullCost + " руб.";
            acc = 0;
            FullCost = 0;
            foreach (var date_ in entities.Orders)
            {
                foreach (var item in entities.TovarToOrder)
                {
                    if (date_.Id_Order == item.Id_Order)
                    {
                        if (date_.TimeOrder >= InfoOrders.Start && date_.TimeOrder <= InfoOrders.End)
                        {
                            if (item.Id_VideoCard != null)
                            {
                                foreach (var VC in entities.VideoCard)
                                {
                                    if (VC.Id_VideoCard == item.Id_VideoCard)
                                    {
                                        acc++;
                                        FullCost += Convert.ToInt32(VC.Coast);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            txtOrdersInfo.Text += "\n Видеокарты: " + acc + " шт. " + "Сумма прибыли: " + FullCost + " руб.";
            acc = 0;
            FullCost = 0;
            foreach (var date_ in entities.Orders)
            {
                foreach (var item in entities.TovarToOrder)
                {
                    if (date_.Id_Order == item.Id_Order)
                    {
                        if (date_.TimeOrder >= InfoOrders.Start && date_.TimeOrder <= InfoOrders.End)
                        {
                            if (item.Id_RAM != null)
                            {
                                foreach (var RAM in entities.RAM)
                                {
                                    if (RAM.Id_RAM == item.Id_RAM)
                                    {
                                        acc++;
                                        FullCost += Convert.ToInt32(RAM.Coast);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            txtOrdersInfo.Text += "\n Оперативная память: " + acc + " шт. " + "Сумма прибыли: " + FullCost + " руб.";
            acc = 0;
            FullCost = 0;
        }

        private void SaveCheck_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog saveFileDialog = new PrintDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                IDocumentPaginatorSource idp = CheckOrder;
                saveFileDialog.PrintDocument(idp.DocumentPaginator, "Flow Document");
            }
        }
    }
}
