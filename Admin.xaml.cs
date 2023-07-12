using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class Admin : Window
    {
        Entities entities = new Entities();
        public Admin()
        {
            InitializeComponent();
            UserName.Content = Class_Login.Sname + " " + Class_Login.Fname + " " + Class_Login.FAname;
            
            try
            {
                switch (Class_Login.IdProduct)
                {
                    case 1:
                        LabelDetail2.Content = "Сокет";

                        LabelDetail3.Content = "Кол-во ядер";

                        LabelDetail4.Content = "Кол-во потоков";

                        LabelDetail5.Content = "Базовая частота";

                        LabelDetail6.Content = "Максимальная частота";

                        LabelDetail7.Content = "Свободный множитель";

                        LabelDetail8.Content = "Максимальная память";

                        LabelDetail9.Content = "Расчетная мощность";

                        LabelDetail10.Content = "Графическое ядро";

                        LabelDetail11.Content = "Цена";

                        Detail12.Visibility = Visibility.Hidden;
                        LabelDetail12.Visibility = Visibility.Hidden;
                        foreach (var item in entities.CPU)
                        {
                            products_list.Items.Add(item);
                        }


                        break;
                    case 2:

                        LabelDetail2.Content = "Сокет";

                        LabelDetail3.Content = "Форм-фактор";

                        LabelDetail4.Content = "Кол-во слотов памяти";

                        LabelDetail5.Content = "Тип памяти";

                        LabelDetail6.Content = "Максимальное кол-во памяти";

                        LabelDetail7.Content = "Максимальная частота";

                        LabelDetail8.Content = "Цена";

                        LabelDetail9.Visibility = Visibility.Hidden;
                        Detail9.Visibility = Visibility.Hidden;
                        LabelDetail10.Visibility = Visibility.Hidden;
                        Detail10.Visibility = Visibility.Hidden;
                        Detail11.Visibility = Visibility.Hidden;
                        Detail12.Visibility = Visibility.Hidden;
                        LabelDetail11.Visibility = Visibility.Hidden;
                        LabelDetail12.Visibility = Visibility.Hidden;
                        foreach (var item in entities.Motherboard)
                        {
                            products_list.Items.Add(item);
                        }

                        break;
                    case 3:
                        LabelDetail2.Content = "Кол-во памяти";

                        LabelDetail3.Content = "Тип памяти";

                        LabelDetail4.Content = "Частота памяти";

                        LabelDetail5.Content = "Видео память";

                        LabelDetail6.Content = "Турбочастота";

                        LabelDetail7.Content = "Кол-во процессоров";

                        LabelDetail8.Content = "Подключение видеокарты";

                        LabelDetail9.Content = "Интерфейс подключения";

                        LabelDetail10.Content = "Потребляемая мощность";

                        LabelDetail11.Content = "Цена";
                        ;
                        Detail12.Visibility = Visibility.Hidden;
                        LabelDetail12.Visibility = Visibility.Hidden;
                        foreach (var item in entities.VideoCard)
                        {
                            products_list.Items.Add(item);
                        }
                        break;
                    case 4:

                        LabelDetail2.Content = "Мощность";

                        LabelDetail3.Content = "Форм-фактор";

                        LabelDetail4.Content = "Сертификат 80PLUS";

                        LabelDetail5.Content = "Основной разъем питания";

                        LabelDetail6.Content = "Питание процессора";

                        LabelDetail7.Content = "Питание видеокарты";

                        LabelDetail8.Content = "Цена";

                        LabelDetail9.Visibility = Visibility.Hidden;
                        Detail9.Visibility = Visibility.Hidden;
                        LabelDetail10.Visibility = Visibility.Hidden;
                        Detail10.Visibility = Visibility.Hidden;
                        LabelDetail11.Visibility = Visibility.Hidden;
                        Detail11.Visibility = Visibility.Hidden;
                        Detail12.Visibility = Visibility.Hidden;
                        LabelDetail12.Visibility = Visibility.Hidden;
                        foreach (var item in entities.PowerUnit)
                        {
                            products_list.Items.Add(item);
                        }

                        break;
                    case 5:
                        LabelDetail2.Content = "Тип памяти";

                        LabelDetail3.Content = "Кол-во памяти";

                        LabelDetail4.Content = "Кол-во слотов";

                        LabelDetail5.Content = "Частота";

                        LabelDetail6.Content = "Тайминги";

                        LabelDetail7.Content = "Цена";

                        LabelDetail8.Visibility = Visibility.Hidden;
                        Detail8.Visibility = Visibility.Hidden;
                        LabelDetail9.Visibility = Visibility.Hidden;
                        Detail9.Visibility = Visibility.Hidden;
                        LabelDetail10.Visibility = Visibility.Hidden;
                        Detail10.Visibility = Visibility.Hidden;
                        LabelDetail11.Visibility = Visibility.Hidden;
                        Detail11.Visibility = Visibility.Hidden;
                        Detail12.Visibility = Visibility.Hidden;
                        LabelDetail12.Visibility = Visibility.Hidden;
                        foreach (var item in entities.RAM)
                        {
                            products_list.Items.Add(item);
                        }

                        break;
                    case 6:
                        LabelDetail2.Content = "Диагональ";

                        LabelDetail3.Content = "Тип матрицы";

                        LabelDetail4.Content = "Разрешение";

                        LabelDetail5.Content = "Частота";

                        LabelDetail6.Content = "Интерфейс подключения";

                        LabelDetail7.Content = "Потребляемая мощность";

                        LabelDetail8.Content = "Цена";

                        LabelDetail9.Visibility = Visibility.Hidden;
                        Detail9.Visibility = Visibility.Hidden;
                        LabelDetail10.Visibility = Visibility.Hidden;
                        Detail10.Visibility = Visibility.Hidden;
                        LabelDetail11.Visibility = Visibility.Hidden;
                        Detail11.Visibility = Visibility.Hidden;
                        Detail12.Visibility = Visibility.Hidden;
                        LabelDetail12.Visibility = Visibility.Hidden;
                        foreach (var item in entities.Monitor)
                        {
                            products_list.Items.Add(item);
                        }

                        break;
                    case 7:
                        LabelDetail2.Content = "Кол-во памяти";

                        LabelDetail3.Content = "Скорость передачи данных";

                        LabelDetail4.Content = "Интерфейс";

                        LabelDetail5.Content = "Технология записи";

                        LabelDetail6.Content = "Цена";

                        LabelDetail7.Visibility = Visibility.Hidden;
                        Detail7.Visibility = Visibility.Hidden;
                        LabelDetail8.Visibility = Visibility.Hidden;
                        Detail8.Visibility = Visibility.Hidden;
                        LabelDetail9.Visibility = Visibility.Hidden;
                        Detail9.Visibility = Visibility.Hidden;
                        LabelDetail10.Visibility = Visibility.Hidden;
                        Detail10.Visibility = Visibility.Hidden;
                        LabelDetail11.Visibility = Visibility.Hidden;
                        Detail11.Visibility = Visibility.Hidden;
                        Detail12.Visibility = Visibility.Hidden;
                        LabelDetail12.Visibility = Visibility.Hidden;
                        foreach (var item in entities.HDD)
                        {
                            products_list.Items.Add(item);
                        }

                        break;
                    case 8:
                        LabelDetail2.Content = "Тип корпуса";

                        LabelDetail3.Content = "Форм-фактор МП";

                        LabelDetail4.Content = "Форм-фактор БП";

                        LabelDetail5.Content = "Цена";

                        LabelDetail6.Visibility = Visibility.Hidden;
                        Detail6.Visibility = Visibility.Hidden;
                        LabelDetail7.Visibility = Visibility.Hidden;
                        Detail7.Visibility = Visibility.Hidden;
                        LabelDetail8.Visibility = Visibility.Hidden;
                        Detail8.Visibility = Visibility.Hidden;
                        LabelDetail9.Visibility = Visibility.Hidden;
                        Detail9.Visibility = Visibility.Hidden;
                        LabelDetail10.Visibility = Visibility.Hidden;
                        Detail10.Visibility = Visibility.Hidden;
                        LabelDetail11.Visibility = Visibility.Hidden;
                        Detail11.Visibility = Visibility.Hidden;
                        Detail12.Visibility = Visibility.Hidden;
                        LabelDetail12.Visibility = Visibility.Hidden;
                        foreach (var item in entities.Cases)
                        {
                            products_list.Items.Add(item);
                        }

                        break;
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так...");
            }
        }

        private void go_back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Products_Win();
            window_.Show();
            this.Close();
        }

        private void UserImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new Registration();
            window_.Show();
            this.Close();
        }

        private void products_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (products_list.SelectedItem != null)
            {
                switch (Class_Login.IdProduct)
                {
                    case 1:
                        var selectedCPU = products_list.SelectedItem as CPU;
                        ModelDetail.Text = selectedCPU.Model.Trim();
                        Detail2.Text = selectedCPU.Soket.Trim();
                        Detail3.Text = selectedCPU.Count_of_Cores.Trim();
                        Detail4.Text = selectedCPU.Num_of_Threads.Trim();
                        Detail5.Text = selectedCPU.Base_CPU.Trim();
                        Detail6.Text = selectedCPU.Max_CPU.Trim();
                        if (selectedCPU.CPU_overclocking == true)
                        {
                            Detail7.Text = "есть";
                        }
                        else
                        {
                            Detail7.Text = "нету";
                        }
                        Detail8.Text = selectedCPU.Max_Memory.Trim();
                        Detail9.Text = selectedCPU.TDP.Trim();
                        if (selectedCPU.Graphics_core == true)
                        {
                            Detail10.Text = "есть";
                        }
                        else
                        {
                            Detail10.Text = "нету";
                        }
                        Detail11.Text = selectedCPU.Coast.ToString().Trim();
                        break;

                    case 2:
                        var selectedMB = products_list.SelectedItem as Motherboard;
                        ModelDetail.Text = selectedMB.Model.Trim();
                        Detail2.Text = selectedMB.Form_factor.Trim();
                        Detail3.Text = selectedMB.Soket.Trim();
                        Detail4.Text = selectedMB.Memory_slots.ToString().Trim();
                        Detail5.Text = selectedMB.Type_memory.Trim();
                        Detail6.Text = selectedMB.Max_memory.Trim();
                        Detail7.Text = selectedMB.Max_frequency.Trim();
                        Detail8.Text = selectedMB.Coast.ToString().Trim();

                        break;

                    case 3:
                        var selectedVC = products_list.SelectedItem as VideoCard;
                        ModelDetail.Text = selectedVC.Model.Trim();
                        Detail2.Text = selectedVC.Count_Memory.Trim();
                        Detail3.Text = selectedVC.Type_Memory.Trim();
                        Detail4.Text = selectedVC.Memory_frequency.Trim();
                        Detail5.Text = selectedVC.Video_frequency.Trim();
                        Detail6.Text = selectedVC.Turbo.Trim();
                        Detail7.Text = selectedVC.Count_CPU.Trim();
                        Detail8.Text = selectedVC.Connector.Trim();
                        Detail9.Text = selectedVC.Conn_interface.Trim();
                        Detail10.Text = selectedVC.Power_Unit.Trim();
                        Detail11.Text = selectedVC.Coast.ToString().Trim(); 
                        break;

                    case 4:
                        var selectedPU = products_list.SelectedItem as PowerUnit;
                        ModelDetail.Text = selectedPU.Model.Trim();
                        Detail2.Text = selectedPU.Power.Trim();
                        Detail3.Text = selectedPU.Form.Trim();
                        Detail4.Text = selectedPU.Sertificat.Trim();
                        Detail5.Text = selectedPU.PowerConn.Trim();
                        Detail6.Text = selectedPU.PowerConnCPU.Trim();
                        Detail7.Text = selectedPU.PowerConnVideo.Trim();
                        Detail8.Text = selectedPU.Coast.ToString().Trim();
                        break;

                    case 5:
                        var selectedRAM = products_list.SelectedItem as RAM;
                        ModelDetail.Text = selectedRAM.Model.Trim();
                        Detail3.Text = selectedRAM.Count_Memory.Trim();
                        Detail2.Text = selectedRAM.Type_Memory.Trim();
                        Detail4.Text = selectedRAM.Count_RAM.Trim();
                        Detail5.Text = selectedRAM.RAM_frequency.Trim();
                        Detail6.Text = selectedRAM.Timings.Trim();
                        Detail7.Text = selectedRAM.Coast.ToString().Trim();
                        break;

                    case 6:
                        var selectedMonitor = products_list.SelectedItem as Monitor;
                        ModelDetail.Text = selectedMonitor.Model.Trim();
                        Detail2.Text = selectedMonitor.Diagonal.Trim();
                        Detail3.Text = selectedMonitor.Type_Matrix.Trim();
                        Detail4.Text = selectedMonitor.Max_Resolution.Trim();
                        Detail5.Text = selectedMonitor.frequency.Trim();
                        Detail6.Text = selectedMonitor.VideoConn.Trim();
                        Detail7.Text = selectedMonitor.PowerNeed.Trim();
                        Detail8.Text = selectedMonitor.Coast.ToString().Trim();
                        break;

                    case 7:
                        var selectedHDD = products_list.SelectedItem as HDD;
                        ModelDetail.Text = selectedHDD.Model.Trim();
                        Detail2.Text = selectedHDD.Count_Memory.Trim();
                        Detail3.Text = selectedHDD.Max_Memory_Speed.Trim();
                        Detail4.Text = selectedHDD.Interface.Trim();
                        Detail5.Text = selectedHDD.Record.Trim();
                        Detail6.Text = selectedHDD.Coast.ToString().Trim();
                        break;

                    case 8:
                        var selectedCases = products_list.SelectedItem as Cases;
                        ModelDetail.Text = selectedCases.Model.Trim();
                        Detail2.Text = selectedCases.Type_Case.Trim();
                        Detail3.Text = selectedCases.FormMB.Trim();
                        Detail4.Text = selectedCases.FormPU.Trim();
                        Detail5.Text = selectedCases.Coast.ToString().Trim();
                        break;
                }
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

                switch (Class_Login.IdProduct)
                {
                    case 1:
                        var selectedCPU = products_list.SelectedItem as CPU;
                        if (products_list.SelectedItem == null)
                        {
                            selectedCPU = new CPU();
                            entities.CPU.Add(selectedCPU);
                            products_list.Items.Add(selectedCPU);
                        }
                        
                        selectedCPU.Model = ModelDetail.Text.Trim();
                        selectedCPU.Soket = Detail2.Text.Trim();
                        selectedCPU.Count_of_Cores = Detail3.Text.Trim();
                        selectedCPU.Num_of_Threads = Detail4.Text.Trim();
                        selectedCPU.Base_CPU = Detail5.Text.Trim();
                        selectedCPU.Max_CPU = Detail6.Text.Trim();
                        if (Detail7.Text.ToLower() == "есть")
                        {
                            selectedCPU.CPU_overclocking = true;
                        }
                        else if (Detail7.Text.ToLower() == "нету")
                        {
                            selectedCPU.CPU_overclocking = false;
                        }
                        selectedCPU.Max_Memory = Detail8.Text.Trim();
                        selectedCPU.TDP = Detail9.Text.Trim();
                        if (Detail10.Text.ToLower() == "есть")
                        {
                            selectedCPU.Graphics_core = true;
                        }
                        else if (Detail10.Text.ToLower() == "нету")
                        {
                            selectedCPU.Graphics_core = false;
                        }
                        selectedCPU.Coast = Convert.ToInt32(Detail11.Text.Trim());
                        entities.SaveChanges();
                        products_list.Items.Refresh();
                        MessageBox.Show("Изменения успешно сохранились");
                        
                        break;
                    case 2:

                        var selectedMB = products_list.SelectedItem as Motherboard;
                        if ( products_list.SelectedItem == null)
                        {
                            selectedMB = new Motherboard();
                            entities.Motherboard.Add(selectedMB);
                            products_list.Items.Add(selectedMB);
                        }
                        selectedMB.Model = ModelDetail.Text.Trim();
                        selectedMB.Soket = Detail2.Text.Trim();
                        selectedMB.Form_factor = Detail3.Text.Trim();
                        selectedMB.Memory_slots = Convert.ToInt32(Detail4.Text.Trim());
                        selectedMB.Type_memory = Detail5.Text.Trim();
                        selectedMB.Max_memory = Detail6.Text.Trim();
                        selectedMB.Max_frequency = Detail7.Text.Trim();
                        selectedMB.Coast = Convert.ToInt32(Detail8.Text.Trim());

                        entities.SaveChanges();
                        products_list.Items.Refresh();
                        MessageBox.Show("Изменения успешно сохранились");
                        break;
                    case 3:

                        var selectedVC = products_list.SelectedItem as VideoCard;
                        if (products_list.SelectedItem == null)
                        {
                            selectedVC = new VideoCard();
                            entities.VideoCard.Add(selectedVC);
                            products_list.Items.Add(selectedVC);
                        }
                        selectedVC.Model = ModelDetail.Text.Trim();
                        selectedVC.Count_Memory = Detail2.Text.Trim();
                        selectedVC.Type_Memory = Detail3.Text.Trim();
                        selectedVC.Memory_frequency = Detail4.Text.Trim();
                        selectedVC.Video_frequency = Detail5.Text.Trim();
                        selectedVC.Turbo = Detail6.Text.Trim();
                        selectedVC.Count_CPU = Detail7.Text.Trim();
                        selectedVC.Connector = Detail8.Text.Trim();
                        selectedVC.Conn_interface = Detail9.Text.Trim();
                        selectedVC.Power_Unit = Detail10.Text.Trim();
                        selectedVC.Coast = Convert.ToInt32(Detail11.Text.Trim());

                        entities.SaveChanges();
                        products_list.Items.Refresh();
                        MessageBox.Show("Изменения успешно сохранились");
                        break;
                    case 4:

                        var selectedPU = products_list.SelectedItem as PowerUnit;
                        if (products_list.SelectedItem == null)
                        {
                            selectedPU = new PowerUnit();
                            entities.PowerUnit.Add(selectedPU);
                            products_list.Items.Add(selectedPU);
                        }
                        selectedPU.Model = ModelDetail.Text.Trim();
                        selectedPU.Power = Detail2.Text.Trim();
                        selectedPU.Form = Detail3.Text.Trim();
                        selectedPU.Sertificat = Detail4.Text.Trim();
                        selectedPU.PowerConn = Detail5.Text.Trim();
                        selectedPU.PowerConnCPU = Detail6.Text.Trim();
                        selectedPU.PowerConnVideo = Detail7.Text.Trim();
                        selectedPU.Coast = Convert.ToInt32(Detail8.Text.Trim());

                        entities.SaveChanges();
                        products_list.Items.Refresh();
                        MessageBox.Show("Изменения успешно сохранились");
                        break;
                    case 5:

                        var selectedRAM = products_list.SelectedItem as RAM;
                        if (products_list.SelectedItem == null)
                        {
                            selectedRAM = new RAM();
                            entities.RAM.Add(selectedRAM);
                            products_list.Items.Add(selectedRAM);
                        }
                        selectedRAM.Model = ModelDetail.Text.Trim();
                        selectedRAM.Type_Memory = Detail2.Text.Trim();
                        selectedRAM.Count_Memory = Detail3.Text.Trim();
                        selectedRAM.Count_RAM = Detail4.Text.Trim();
                        selectedRAM.RAM_frequency = Detail5.Text.Trim();
                        selectedRAM.Timings = Detail6.Text.Trim();
                        selectedRAM.Coast = Convert.ToInt32(Detail7.Text.Trim());

                        entities.SaveChanges();
                        products_list.Items.Refresh();
                        MessageBox.Show("Изменения успешно сохранились");
                        break;
                    case 6:

                        var selectedMonitor = products_list.SelectedItem as Monitor;
                        if (products_list.SelectedItem == null)
                        {
                            selectedMonitor = new Monitor();
                            entities.Monitor.Add(selectedMonitor);
                            products_list.Items.Add(selectedMonitor);
                        }
                        selectedMonitor.Model = ModelDetail.Text.Trim();
                        selectedMonitor.Diagonal = Detail2.Text.Trim();
                        selectedMonitor.Type_Matrix = Detail3.Text.Trim();
                        selectedMonitor.Max_Resolution = Detail4.Text.Trim();
                        selectedMonitor.frequency = Detail5.Text.Trim();
                        selectedMonitor.VideoConn = Detail6.Text.Trim();
                        selectedMonitor.PowerNeed = Detail7.Text.Trim();
                        selectedMonitor.Coast = Convert.ToInt32(Detail8.Text.Trim());

                        entities.SaveChanges();
                        products_list.Items.Refresh();
                        MessageBox.Show("Изменения успешно сохранились");
                        break;
                    case 7:

                        var selectedHDD = products_list.SelectedItem as HDD;
                        if (products_list.SelectedItem == null)
                        {
                            selectedHDD = new HDD();
                            entities.HDD.Add(selectedHDD);
                            products_list.Items.Add(selectedHDD);
                        }
                        selectedHDD.Model = ModelDetail.Text.Trim();
                        selectedHDD.Count_Memory = Detail2.Text.Trim();
                        selectedHDD.Max_Memory_Speed = Detail3.Text.Trim();
                        selectedHDD.Interface = Detail4.Text.Trim();
                        selectedHDD.Record = Detail5.Text.Trim();
                        selectedHDD.Coast = Convert.ToInt32(Detail6.Text.Trim());

                        entities.SaveChanges();
                        products_list.Items.Refresh();
                        MessageBox.Show("Изменения успешно сохранились");
                        break;
                    case 8:

                        var selectedCases = products_list.SelectedItem as Cases;
                        if (products_list.SelectedItem == null)
                        {
                            selectedCases = new Cases();
                            entities.Cases.Add(selectedCases);
                            products_list.Items.Add(selectedCases);
                        }
                        selectedCases.Model = ModelDetail.Text.Trim();
                        selectedCases.Type_Case = Detail2.Text.Trim();
                        selectedCases.FormMB = Detail3.Text.Trim();
                        selectedCases.FormPU = Detail4.Text.Trim();
                        selectedCases.Coast = Convert.ToInt32(Detail5.Text.Trim());

                        entities.SaveChanges();
                        products_list.Items.Refresh();
                        MessageBox.Show("Изменения успешно сохранились");
                        break;
                }

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (products_list.SelectedItem == null)
                {
                    MessageBox.Show("Выберите элемент из списка!");
                }
                else
                {
                    switch (Class_Login.IdProduct)
                    {
                        case 1:
                            var selectedCPU = products_list.SelectedItem as CPU;

                            entities.CPU.Remove(selectedCPU);
                            entities.SaveChanges();
                            products_list.Items.Remove(selectedCPU);
                            products_list.Items.Refresh();
                            break;
                        case 2:
                            var selectedMB = products_list.SelectedItem as Motherboard;

                            entities.Motherboard.Remove(selectedMB);
                            entities.SaveChanges();
                            products_list.Items.Remove(selectedMB);
                            products_list.Items.Refresh();
                            break;
                        case 3:
                            var selectedVC = products_list.SelectedItem as VideoCard;

                            entities.VideoCard.Remove(selectedVC);
                            entities.SaveChanges();
                            products_list.Items.Remove(selectedVC);
                            products_list.Items.Refresh();
                            break;
                        case 4:
                            var selectedPU = products_list.SelectedItem as PowerUnit;

                            entities.PowerUnit.Remove(selectedPU);
                            entities.SaveChanges();
                            products_list.Items.Remove(selectedPU);
                            products_list.Items.Refresh();
                            break;
                        case 5:
                            var selectedRAM = products_list.SelectedItem as RAM;

                            entities.RAM.Remove(selectedRAM);
                            entities.SaveChanges();
                            products_list.Items.Remove(selectedRAM);
                            products_list.Items.Refresh();
                            break;
                        case 7:
                            var selectedHDD = products_list.SelectedItem as HDD;

                            entities.HDD.Remove(selectedHDD);
                            entities.SaveChanges();
                            products_list.Items.Remove(selectedHDD);
                            products_list.Items.Refresh();
                            break;
                        case 6:
                            var selectedMonitor = products_list.SelectedItem as Monitor;

                            entities.Monitor.Remove(selectedMonitor);
                            entities.SaveChanges();
                            products_list.Items.Remove(selectedMonitor);
                            products_list.Items.Refresh();
                            break;
                        case 8:
                            var selectedCases = products_list.SelectedItem as Cases;

                            entities.Cases.Remove(selectedCases);
                            entities.SaveChanges();
                            products_list.Items.Remove(selectedCases);
                            products_list.Items.Refresh();
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить уже заказанный товара!");
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ModelDetail.Text = "";
            Detail2.Text = "";
            Detail3.Text = "";
            Detail4.Text = "";
            Detail5.Text = "";
            Detail6.Text = "";
            Detail7.Text = "";
            Detail8.Text = "";
            Detail9.Text = "";
            Detail10.Text = "";
            Detail11.Text = "";
            Detail12.Text = "";
            products_list.SelectedItem = null;
        }
    }
}