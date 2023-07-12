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
    public partial class DetailProduct : Window
    {
        Entities entities = new Entities();
        public int CountBuy = 0;
        public int CountProduct = 0;
        public DetailProduct()
        {
            InitializeComponent();
            CountLabel.Content = CountBuy.ToString();
                switch (Class_Login.IdProduct)
                {
                    case 1:

                        foreach (var item in entities.CPU)
                        {
                            if (item.Id_Processor == Class_Login.Id)
                            {
                                if (item.Pic == null)
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@"//Images/logo.png"));
                                }
                                else
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@item.Pic));
                                }
                            CountProduct = Convert.ToInt32(item.Count);
                            Detail1.Content = item.Model.Trim();
                                LabelDetail2.Content = "Сокет";
                                Detail13.Content = item.Soket.Trim();
                                LabelDetail3.Content = "Кол-во ядер";
                                Detail3.Content = item.Count_of_Cores.Trim();
                                LabelDetail4.Content = "Кол-во потоков";
                                Detail4.Content = item.Num_of_Threads.Trim();
                                LabelDetail5.Content = "Базовая частота";
                                Detail5.Content = item.Base_CPU.Trim() + "Ггц";
                                LabelDetail6.Content = "Максимальная частота";
                                Detail6.Content = item.Max_CPU.Trim() + "Ггц";
                                LabelDetail7.Content = "Свободный множитель";
                                if (item.CPU_overclocking == true)
                                    Detail7.Content = "есть";
                                else
                                    Detail7.Content = "нету";
                                LabelDetail8.Content = "Максимальная память";
                                Detail8.Content = item.Max_Memory.Trim() + "Гб";
                                LabelDetail9.Content = "Расчетная мощность";
                                Detail9.Content = item.TDP.Trim() + "Вт";
                                LabelDetail10.Content = "Графическое ядро";
                                if (item.Graphics_core == true)
                                    Detail10.Content = "есть";
                                else
                                    Detail10.Content = "нету";
                                LabelDetail11.Content = "Цена";
                                Detail11.Content = item.Coast.ToString().Trim() + " руб.";
                                Detail12.Visibility = Visibility.Hidden;
                                LabelDetail12.Visibility = Visibility.Hidden;
                            }
                        }


                        break;
                    case 2:

                        foreach (var item in entities.Motherboard)
                        {
                            if (item.Id_Motherboard == Class_Login.Id)
                            {
                                if (item.Pic == null)
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@"E:\Курсовая\WpfApp3\WpfApp3\logo.png"));
                                }
                                else
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@item.Pic));
                                }
                            CountProduct = Convert.ToInt32(item.Count);
                            Detail1.Content = item.Model.Trim();
                                LabelDetail2.Content = "Сокет";
                                Detail13.Content = item.Soket.Trim();
                                LabelDetail3.Content = "Форм-фактор";
                                Detail3.Content = item.Form_factor.Trim();
                                LabelDetail4.Content = "Кол-во слотов памяти";
                                Detail4.Content = item.Memory_slots.ToString().Trim();
                                LabelDetail5.Content = "Тип памяти";
                                Detail5.Content = item.Type_memory.Trim();
                                LabelDetail6.Content = "Максимальное кол-во памяти";
                                Detail6.Content = item.Max_memory.Trim() + "Гб";
                                LabelDetail7.Content = "Максимальная частота";
                                Detail7.Content = item.Max_frequency.Trim();
                                LabelDetail8.Content = "Цена";
                                Detail8.Content = item.Coast.ToString().Trim() + " руб.";
                                LabelDetail9.Visibility = Visibility.Hidden;
                                Detail9.Visibility = Visibility.Hidden;
                                LabelDetail10.Visibility = Visibility.Hidden;
                                Detail10.Visibility = Visibility.Hidden;
                                Detail11.Visibility = Visibility.Hidden;
                                Detail12.Visibility = Visibility.Hidden;
                                LabelDetail11.Visibility = Visibility.Hidden;
                                LabelDetail12.Visibility = Visibility.Hidden;
                            }
                        }

                        break;
                    case 3:

                        foreach (var item in entities.VideoCard)
                        {
                            if (item.Id_VideoCard == Class_Login.Id)
                            {
                                if (item.Pic == null)
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@"F:\Курсовая\WpfApp3\WpfApp3\logo.png"));
                                }
                                else
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@item.Pic));
                                }
                            CountProduct = Convert.ToInt32(item.Count);
                            Detail1.Content = item.Model.Trim();
                                LabelDetail2.Content = "Кол-во памяти";
                                Detail13.Content = item.Count_Memory.Trim();
                                LabelDetail3.Content = "Тип памяти";
                                Detail3.Content = item.Type_Memory.Trim();
                                LabelDetail4.Content = "Частота памяти";
                                Detail4.Content = item.Memory_frequency.Trim() + "Ггц";
                                LabelDetail5.Content = "Видео память";
                                Detail5.Content = item.Video_frequency.Trim() + "Ггц";
                                LabelDetail6.Content = "Турбочастота";
                                Detail6.Content = item.Turbo.Trim() + "Ггц";
                                LabelDetail7.Content = "Кол-во процессоров";
                                Detail7.Content = item.Count_CPU.Trim();
                                LabelDetail8.Content = "Подключение видеокарты";
                                Detail8.Content = item.Connector.Trim();
                                LabelDetail9.Content = "Интерфейс подключения";
                                Detail9.Content = item.Conn_interface.Trim();
                                LabelDetail10.Content = "Потребляемая мощность";
                                Detail10.Content = item.Power_Unit.Trim() + "Вт";
                                LabelDetail11.Content = "Цена";
                                Detail11.Content = item.Coast.ToString().Trim() + " руб.";
                                Detail12.Visibility = Visibility.Hidden;
                                LabelDetail12.Visibility = Visibility.Hidden;
                            }
                        }
                        break;
                    case 4:

                        foreach (var item in entities.PowerUnit)
                        {
                            if (item.Id_PowerUnit == Class_Login.Id)
                            {
                                if (item.Pic == null)
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@"E:\Курсовая\WpfApp3\WpfApp3\logo.png"));
                                }
                                else
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@item.Pic));
                                }
                            CountProduct = Convert.ToInt32(item.Count);
                            Detail1.Content = item.Model.Trim();
                                LabelDetail2.Content = "Мощность";
                                Detail13.Content = item.Power.Trim();
                                LabelDetail3.Content = "Форм-фактор";
                                Detail3.Content = item.Form.Trim();
                                LabelDetail4.Content = "Сертификат 80PLUS";
                                Detail4.Content = item.Sertificat.Trim();
                                LabelDetail5.Content = "Основной разъем питания";
                                Detail5.Content = item.PowerConn.Trim();
                                LabelDetail6.Content = "Питание процессора";
                                Detail6.Content = item.PowerConnCPU.Trim();
                                LabelDetail7.Content = "Питание видеокарты";
                                Detail7.Content = item.PowerConnVideo.Trim();
                                LabelDetail8.Content = "Цена";
                                Detail8.Content = item.Coast.ToString().Trim() + " руб.";
                                LabelDetail9.Visibility = Visibility.Hidden;
                                Detail9.Visibility = Visibility.Hidden;
                                LabelDetail10.Visibility = Visibility.Hidden;
                                Detail10.Visibility = Visibility.Hidden;
                                LabelDetail11.Visibility = Visibility.Hidden;
                                Detail11.Visibility = Visibility.Hidden;
                                Detail12.Visibility = Visibility.Hidden;
                                LabelDetail12.Visibility = Visibility.Hidden;
                            }
                        }

                        break;
                    case 5:

                        foreach (var item in entities.RAM)
                        {
                            if (item.Id_RAM == Class_Login.Id)
                            {
                                if (item.Pic == null)
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@"E:\Курсовая\WpfApp3\WpfApp3\logo.png"));
                                }
                                else
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@item.Pic));
                                }
                            CountProduct = Convert.ToInt32(item.Count);
                            Detail1.Content = item.Model.Trim();
                                LabelDetail2.Content = "Тип памяти";
                                Detail13.Content = item.Type_Memory.Trim();
                                LabelDetail3.Content = "Кол-во памяти";
                                Detail3.Content = item.Count_Memory.Trim();
                                LabelDetail4.Content = "Кол-во слотов";
                                Detail4.Content = item.Count_RAM.Trim();
                                LabelDetail5.Content = "Тайминги";
                                Detail5.Content = item.Timings.Trim();
                                LabelDetail6.Content = "Цена";
                                Detail6.Content = item.Coast.ToString().Trim() + " руб.";
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
                            }
                        }

                        break;
                    case 6:

                        foreach (var item in entities.Monitor)
                        {
                            if (item.Id_Monitor == Class_Login.Id)
                            {
                                if (item.Pic == null)
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@"E:\Курсовая\WpfApp3\WpfApp3\logo.png"));
                                }
                                else
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@item.Pic));
                                }
                            CountProduct = Convert.ToInt32(item.Count);
                            Detail1.Content = item.Model.Trim();
                                LabelDetail2.Content = "Диагональ";
                                Detail13.Content = item.Diagonal.Trim();
                                LabelDetail3.Content = "Тип матрицы";
                                Detail3.Content = item.Type_Matrix.Trim();
                                LabelDetail4.Content = "Максимальное разрешение";
                                Detail4.Content = item.Max_Resolution.Trim();
                                LabelDetail5.Content = "Частота";
                                Detail5.Content = item.frequency.Trim() + "Ггц";
                                LabelDetail6.Content = "Интерфейс подключения";
                                Detail6.Content = item.VideoConn.Trim();
                                LabelDetail7.Content = "Потребляемая мощность";
                                Detail7.Content = item.PowerNeed.Trim();
                                LabelDetail8.Content = "Цена";
                                Detail8.Content = item.Coast.ToString().Trim() + " руб.";
                                LabelDetail9.Visibility = Visibility.Hidden;
                                Detail9.Visibility = Visibility.Hidden;
                                LabelDetail10.Visibility = Visibility.Hidden;
                                Detail10.Visibility = Visibility.Hidden;
                                LabelDetail11.Visibility = Visibility.Hidden;
                                Detail11.Visibility = Visibility.Hidden;
                                Detail12.Visibility = Visibility.Hidden;
                                LabelDetail12.Visibility = Visibility.Hidden;
                            }
                        }

                        break;
                    case 7:

                        foreach (var item in entities.HDD)
                        {
                            if (item.Id_HDD == Class_Login.Id)
                            {
                                if (item.Pic == null)
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@"E:\Курсовая\WpfApp3\WpfApp3\logo.png"));
                                }
                                else
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@item.Pic));
                                }
                            CountProduct = Convert.ToInt32(item.Count);
                            Detail1.Content = item.Model.Trim();
                                LabelDetail2.Content = "Кол-во памяти";
                                Detail13.Content = item.Count_Memory.Trim() + "ТБ";
                                LabelDetail3.Content = "Скорость передачи данных";
                                Detail3.Content = item.Max_Memory_Speed.Trim();
                                LabelDetail4.Content = "Интерфейс";
                                Detail4.Content = item.Interface.Trim();
                                LabelDetail5.Content = "Технология записи";
                                Detail5.Content = item.Record.Trim();
                                LabelDetail6.Content = "Цена";
                                Detail6.Content = item.Coast.ToString().Trim() + " руб.";
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
                            }
                        }

                        break;
                    case 8:

                        foreach (var item in entities.Cases)
                        {
                            if (item.Id_Case == Class_Login.Id)
                            {
                                if (item.Pic == null)
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@"\logo.png"));
                                }
                                else
                                {
                                    ProductImage.Source = BitmapFrame.Create(new Uri(@item.Pic));
                                }
                            CountProduct = Convert.ToInt32(item.Count);
                            Detail1.Content = item.Model.Trim();
                                LabelDetail2.Content = "Тип корпуса";
                                Detail13.Content = item.Type_Case.Trim();
                                LabelDetail3.Content = "Форм-фактор материнской платы";
                                Detail3.Content = item.FormMB.Trim();
                                LabelDetail4.Content = "Форм-фактор блока питания";
                                Detail4.Content = item.FormPU.Trim();
                                LabelDetail5.Content = "Цена";
                                Detail5.Content = item.Coast.ToString().Trim() + " руб.";
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
                            }
                        }

                        break;
                }
        }

        private void go_back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window_ = new User();
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

        private void GetToBasket_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            bool basketFlag = false;
            if (Class_Login.Id_users != 0)
            {
                switch (Class_Login.IdProduct)
                {
                    case 1:
                        foreach (var basket in entities.Basket)
                        {
                            if (basket.Id_Processor == Class_Login.Id && basket.Id_User == Class_Login.Id_users)
                            {
                                basketFlag = true;
                            }
                        }
                        foreach (var item in entities.CPU)
                        {
                            if (basketFlag == false)
                            {
                                if (item.Id_Processor == Class_Login.Id)
                                {
                                    if (item.Count > 0)
                                    {
                                        var tovar = new Basket();
                                        tovar.Id_User = Class_Login.Id_users;
                                        tovar.Id_Processor = item.Id_Processor;
                                        tovar.Count = CountBuy;
                                        item.Count -= CountBuy;
                                        entities.Basket.Add(tovar);
                                        flag = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Неверное кол-во выбранных товаров!");
                                    }
                                }
                            }
                        }
                        if (basketFlag == true)
                        {
                            MessageBox.Show("Данный товар уже добавлен в корзину!");
                        }


                        break;
                    case 2:
                                foreach (var basket in entities.Basket)
                                {
                                    if (basket.Id_Motherboard == Class_Login.Id && basket.Id_User == Class_Login.Id_users)
                                    {
                                        basketFlag = true;
                                    }
                                }
                                if (basketFlag == false)
                                {
                                    foreach (var item in entities.Motherboard)
                                    {
                                        if (item.Id_Motherboard == Class_Login.Id)
                                        {
                                            if (item.Count > 0)
                                            {
                                                var tovar = new Basket();
                                                tovar.Id_User = Class_Login.Id_users;
                                                tovar.Id_Motherboard = item.Id_Motherboard;
                                                tovar.Count = CountBuy;
                                                item.Count -= CountBuy;
                                                entities.Basket.Add(tovar);
                                                flag = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Неверное кол-во выбранных товаров!");
                                            }
                                        }
                                    }
                                }
                        if (basketFlag == true)
                        {
                            MessageBox.Show("Данный товар уже добавлен в корзину!");
                        }
                        break;
                    case 3:
                                foreach (var basket in entities.Basket)
                                {
                                    if (basket.Id_VideoCard == Class_Login.Id && basket.Id_User == Class_Login.Id_users)
                                    {
                                        basketFlag = true;
                                    }
                                }
                                if (basketFlag == false)
                                {
                                    foreach (var item in entities.VideoCard)
                                    {
                                        if (item.Id_VideoCard == Class_Login.Id)
                                        {
                                            if (item.Count > 0)
                                            {
                                                var tovar = new Basket();
                                                tovar.Id_User = Class_Login.Id_users;
                                                tovar.Id_VideoCard = item.Id_VideoCard;
                                                tovar.Count = CountBuy;
                                                item.Count -= CountBuy;
                                                entities.Basket.Add(tovar);
                                                flag = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Неверное кол-во выбранных товаров!");
                                            }
                                        }
                                    }
                                }
                        if (basketFlag == true)
                        {
                            MessageBox.Show("Данный товар уже добавлен в корзину!");
                        }
                        break;
                    case 4:

                                foreach (var basket in entities.Basket)
                                {
                                    if (basket.Id_PowerUnit == Class_Login.Id && basket.Id_User == Class_Login.Id_users)
                                    {
                                        basketFlag = true;
                                    }
                                }
                                if (basketFlag == false)
                                {
                                    foreach (var item in entities.PowerUnit)
                                    {
                                        if (item.Id_PowerUnit == Class_Login.Id)
                                        {
                                            if (item.Count > 0)
                                            {
                                                var tovar = new Basket();
                                                tovar.Id_User = Class_Login.Id_users;
                                                tovar.Id_PowerUnit = item.Id_PowerUnit;
                                                tovar.Count = CountBuy;
                                                item.Count -= CountBuy;
                                                entities.Basket.Add(tovar);
                                                flag = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Неверное кол-во выбранных товаров!");
                                            }
                                        }
                                    }
                                }
                        if (basketFlag == true)
                        {
                            MessageBox.Show("Данный товар уже добавлен в корзину!");
                        }
                        break;
                    case 5:

                                foreach (var basket in entities.Basket)
                                {
                                    if (basket.Id_VideoCard == Class_Login.Id && basket.Id_User == Class_Login.Id_users)
                                    {
                                        basketFlag = true;
                                    }
                                }
                                if (basketFlag == false)
                                {
                                    foreach (var item in entities.RAM)
                                    {
                                        if (item.Id_RAM == Class_Login.Id)
                                        {
                                            if (item.Count > 0)
                                            {
                                                var tovar = new Basket();
                                                tovar.Id_User = Class_Login.Id_users;
                                                tovar.Id_RAM = item.Id_RAM;
                                                tovar.Count = CountBuy;
                                                item.Count -= CountBuy;
                                                entities.Basket.Add(tovar);
                                                flag = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Неверное кол-во выбранных товаров!");
                                            }
                                        }
                                    }
                                }
                        if (basketFlag == true)
                        {
                            MessageBox.Show("Данный товар уже добавлен в корзину!");
                        }
                        break;
                    case 6:
                                foreach (var basket in entities.Basket)
                                {
                                    if (basket.Id_VideoCard == Class_Login.Id && basket.Id_User == Class_Login.Id_users)
                                    {
                                        basketFlag = true;
                                    }
                                }
                                if (basketFlag == false)
                                {
                                    foreach (var item in entities.Monitor)
                                    {
                                        if (item.Id_Monitor == Class_Login.Id)
                                        {
                                            if (item.Count > 0)
                                            {
                                                var tovar = new Basket();
                                                tovar.Id_User = Class_Login.Id_users;
                                                tovar.Id_Monitor = item.Id_Monitor;
                                                tovar.Count = CountBuy;
                                                item.Count -= CountBuy;
                                                entities.Basket.Add(tovar);
                                                flag = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Неверное кол-во выбранных товаров!");
                                            }
                                        }
                                    }
                                }
                        if (basketFlag == true)
                        {
                            MessageBox.Show("Данный товар уже добавлен в корзину!");
                        }
                        break;
                    case 7:
                                foreach (var basket in entities.Basket)
                                {
                                    if (basket.Id_VideoCard == Class_Login.Id && basket.Id_User == Class_Login.Id_users)
                                    {
                                        basketFlag = true;
                                    }
                                }
                                if (basketFlag == false)
                                {
                                    foreach (var item in entities.HDD)
                                    {
                                        if (item.Id_HDD == Class_Login.Id)
                                        {
                                            if (item.Count > 0)
                                            {
                                                var tovar = new Basket();
                                                tovar.Id_User = Class_Login.Id_users;
                                                tovar.Id_HDD = item.Id_HDD;
                                                tovar.Count = CountBuy;
                                                item.Count -= CountBuy;
                                                entities.Basket.Add(tovar);
                                                flag = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Неверное кол-во выбранных товаров!");
                                            }
                                        }
                                    }
                                }
                        if (basketFlag == true)
                        {
                            MessageBox.Show("Данный товар уже добавлен в корзину!");
                        }
                        break;
                    case 8:
                                foreach (var basket in entities.Basket)
                                {
                                    if (basket.Id_VideoCard == Class_Login.Id && basket.Id_User == Class_Login.Id_users)
                                    {
                                        basketFlag = true;
                                    }
                                }
                                if (basketFlag == false)
                                {
                                    foreach (var item in entities.Cases)
                                    {
                                        if (item.Id_Case == Class_Login.Id)
                                        {
                                            if (item.Count > 0)
                                            {
                                                var tovar = new Basket();
                                                tovar.Id_User = Class_Login.Id_users;
                                                tovar.Id_Case = item.Id_Case;
                                                tovar.Count = CountBuy;
                                                item.Count -= CountBuy;
                                                entities.Basket.Add(tovar);
                                                flag = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Неверное кол-во выбранных товаров!");
                                            }
                                        }
                                    }
                                }
                        if (basketFlag == true)
                        {
                            MessageBox.Show("Данный товар уже добавлен в корзину!");
                        }
                        break;
                }
                if (flag == true)
                {
                    MessageBox.Show("Товар успешно добавлен!");
                }
                else if (flag == false)
                {
                    MessageBox.Show("Что-то пошло не так...");
                }
            }
            else if (Class_Login.Id_users == 0)
            {
                MessageBox.Show("Чтобы добавить товар в корзину, пройдите авторизацию!");
                var window_ = new MainWindow();
                window_.Show();
                this.Close();
            }
            entities.SaveChanges();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (CountBuy == 0)
            {
                MessageBox.Show("Невозможно изменить кол-во товара");
            }
            else if (CountBuy > 0)
            {
                CountBuy -= 1;
            }
            CountLabel.Content = CountBuy.ToString();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (CountBuy == CountProduct)
            {
                MessageBox.Show("Невозможно изменить кол-во товара");
            }
            else if (CountBuy <= CountProduct)
            {
                CountBuy += 1;
            }
            CountLabel.Content = CountBuy.ToString();
        }
    }
}
