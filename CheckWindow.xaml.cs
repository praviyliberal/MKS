using Microsoft.Win32;
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
    /// <summary>
    /// Логика взаимодействия для CheckWindow.xaml
    /// </summary>
    public partial class CheckWindow : Window
    {
        Entities entities = new Entities();
        public CheckWindow()
        {
            InitializeComponent();
            int FullCost = 0;
            txtCheckInfo.Text = "Заказ №" + CreateCheck.ID + " от " + CreateCheck.CreateDate + "\n";
            foreach (var item in entities.TovarToOrder)
            {
                if (item.Id_User == Class_Login.Id_users && item.Id_Order == CreateCheck.ID)
                {
                    if (item.Id_Processor != null)
                    {
                        foreach (var CPU in entities.CPU)
                        {
                            if (CPU.Id_Processor == item.Id_Processor && item.Id_Order == CreateCheck.ID)
                            {
                                txtCheckInfo.Text += "\n" + CPU.Model.Trim() + " --- " + CPU.Coast + " руб. " + " --- " + item.Count + " шт. \n";
                                FullCost += Convert.ToInt32(CPU.Coast) * Convert.ToInt32(item.Count);
                            }
                        }
                    }
                    else if (item.Id_Case != null)
                    {
                        foreach (var Case in entities.Cases)
                        {
                            if (Case.Id_Case == item.Id_Case && item.Id_Order == CreateCheck.ID)
                            {
                                txtCheckInfo.Text +=  "\n" + Case.Model.Trim() + " --- " + Case.Coast + " руб. " + " --- " + item.Count + " шт. \n";
                                FullCost += Convert.ToInt32(Case.Coast) * Convert.ToInt32(item.Count);
                            }
                        }
                    }
                    else if (item.Id_HDD != null)
                    {
                        foreach (var HDD in entities.HDD)
                        {
                            if (HDD.Id_HDD == item.Id_HDD && item.Id_Order == CreateCheck.ID)
                            {
                                txtCheckInfo.Text += "\n" + HDD.Model.Trim() + " --- " + HDD.Coast + " руб. " + " --- " + item.Count + " шт. \n";
                                FullCost += Convert.ToInt32(HDD.Coast) * Convert.ToInt32(item.Count);
                            }
                        }
                    }
                    else if (item.Id_Monitor != null)
                    {
                        foreach (var Mon in entities.Monitor)
                        {
                            if (Mon.Id_Monitor == item.Id_Monitor && item.Id_Order == CreateCheck.ID)
                            {
                                txtCheckInfo.Text += "\n" + Mon.Model.Trim() + " --- " + Mon.Coast + " руб. " + " --- " + item.Count + " шт. \n";
                                FullCost += Convert.ToInt32(Mon.Coast) * Convert.ToInt32(item.Count);
                            }
                        }
                    }
                    else if (item.Id_Motherboard != null)
                    {
                        foreach (var MB in entities.Motherboard)
                        {
                            if (MB.Id_Motherboard == item.Id_Motherboard && item.Id_Order == CreateCheck.ID)
                            {
                                txtCheckInfo.Text += "\n" + MB.Model.Trim() + " --- " + MB.Coast + " руб. " + " --- " + item.Count + " шт. \n";
                                FullCost += Convert.ToInt32(MB.Coast) * Convert.ToInt32(item.Count);
                            }
                        }
                    }
                    else if (item.Id_PowerUnit != null)
                    {
                        foreach (var PU in entities.PowerUnit)
                        {
                            if (PU.Id_PowerUnit == item.Id_PowerUnit && item.Id_Order == CreateCheck.ID)
                            {
                                txtCheckInfo.Text += "\n" + PU.Model.Trim() + " --- " + PU.Coast + " руб. " + " --- " + item.Count + " шт. \n";
                                FullCost += Convert.ToInt32(PU.Coast) * Convert.ToInt32(item.Count);
                            }
                        }
                    }
                    else if (item.Id_RAM != null)
                    {
                        foreach (var RAM in entities.RAM)
                        {
                            if (RAM.Id_RAM == item.Id_RAM && item.Id_Order == CreateCheck.ID)
                            {
                                txtCheckInfo.Text += "\n" + RAM.Model.Trim() + " --- " + RAM.Coast + " руб. " + " --- " + item.Count + " шт. \n";
                                FullCost += Convert.ToInt32(RAM.Coast) * Convert.ToInt32(item.Count);
                            }
                        }
                    }
                    else if (item.Id_VideoCard != null)
                    {
                        foreach (var VC in entities.VideoCard)
                        {
                            if (VC.Id_VideoCard == item.Id_VideoCard && item.Id_Order == CreateCheck.ID)
                            {
                                txtCheckInfo.Text += "\n" + VC.Model.Trim() + " --- " + VC.Coast + " руб. " + " --- " + item.Count + " шт. \n" ;
                                FullCost += Convert.ToInt32(VC.Coast) * Convert.ToInt32(item.Count);
                            }
                        }
                    }
                }

            }
            txtCheckInfo.Text += "\nОбщая стоимость заказа: " + FullCost + "\n";
            txtCheckInfo.Text += "Пункт выдачи заказа: " + CreateCheck.PickUpName + "\n";
            txtCheckInfo.Text += "Код выдачи заказа: " + CreateCheck.Code + "\n";
        }

        private void SaveCheck_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog saveFileDialog = new PrintDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                IDocumentPaginatorSource idp = CheckOrder;
                saveFileDialog.PrintDocument(idp.DocumentPaginator, "Flow Document");
            }
            
            var window_ = new Products_Win();
            window_.Show();
            this.Close();
        }
    }
}
