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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    }
}
























    //    private void loginBTN_Click(object sender, RoutedEventArgs e)
    //    {
    //        try
    //        {
    //            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["TryEkz.Properties.Settings.TryEkzConnectionString"].ConnectionString)) // подключение к БД
    //            {
    //                connect.Open(); // открытие подключения
    //                SqlCommand command = new SqlCommand("select * from Пользователи where Логин='" + loginText.Text + "' and Пароль='" + passwordText.Password + "'", connect); // запрос на пользователя
    //                SqlDataReader reader = command.ExecuteReader(); // выполнение запроса
    //                if (reader.HasRows) // проверка если есть данные
    //                {
    //                    reader.Read();//  считывание данныъ
    //                    string rol = reader.GetValue(3).ToString(); //Сохранение должности
    //                    MessageBox.Show("Добро пожаловать! " + rol); // Ображение к пользователю
    //                    switch (rol) // Отктрытие формы в зависимости от должности
    //                    {
    //                        case "Менеджер":
    //                            managerForm f2 = new managerForm(); f2.Show(); this.Close(); //открытие формы менеджера
    //                            break;
    //                        default:
    //                            MessageBox.Show("Неизветсная роль");
    //                            break;
    //                    }
    //                }
    //                else
    //                {
    //                    MessageBox.Show("Неверный логин или пароль"); // если данных нет вывод сообщения
    //                }
    //            }
    //        }
    //        catch
    //        {
    //            MessageBox.Show("Произошла ошибка");
    //            throw;
    //        }
    //    }
    //}

//        if (okBTN.Content == "Добавить")
//            {
//                using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["TryEkz.Properties.Settings.TryEkzConnectionString"].ConnectionString))
//                {
//                    connect.Open();
//                    SqlCommand command = new SqlCommand("insert into Клиент (Имя, Фамилия, Страна, Город,[Номер телефона], Статус) values ('" + nameText.Text + "','" + famText.Text + "','" + countryText.Text + "','" + cityText.Text + "','" + phoneText.Text + "',1)", connect);
//        SqlDataReader reader = command.ExecuteReader();
//        MessageBox.Show("Клиент успешно добавлен!");
//                }
//}
//            if (okBTN.Content == "Изменить")
//            {
//                using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["TryEkz.Properties.Settings.TryEkzConnectionString"].ConnectionString))
//                {
//                    connect.Open();
//                    SqlCommand command = new SqlCommand("update [Клиент] set [Имя]='" + nameText.Text + "',[Фамилия]='" + famText.Text + "',[Страна]='" + countryText.Text + "',[Город]='" + cityText.Text + "',[Номер телефона]='" + phoneText.Text + "' where ID ='" + selectedKlient + "'", connect);
//SqlDataReader reader = command.ExecuteReader();
//MessageBox.Show("Клиент успешно изменён!");
//                }
//            }
//            refreshClientTable();
//cleanInputGroup();
//inputGroup.IsEnabled = false;
//        }

//        private void Window_Loaded(object sender, RoutedEventArgs e) // Загурзка таблицы при запуске
//{
//    refreshClientTable();
//}

//void refreshClientTable() // функция для обновления таблицы клиентов
//{
//    try
//    {
//        using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["TryEkz.Properties.Settings.TryEkzConnectionString"].ConnectionString))
//        {
//            connect.Open(); // открытие подключения
//            DataTable clientTable = new DataTable(); //создание таблицы
//            SqlDataAdapter clientAdapter = new SqlDataAdapter("Select * from Клиент where Статус=1", connect); //получение таблицы клиентов
//            clientAdapter.Fill(clientTable); //заполение таблицы из БД
//            clientGrid.ItemsSource = clientTable.DefaultView; // вывод таблицы на форму
//        }
//    }
//    catch (Exception)
//    {
//        MessageBox.Show("Произошла ошибка");
//        throw;
//    }
//}
//void cleanInputGroup()
//{
//    nameText.Text = "";
//    famText.Text = "";
//    countryText.Text = "";
//    cityText.Text = "";
//    phoneText.Text = "";
//}

//private void deleteBTN_Copy_Click(object sender, RoutedEventArgs e)
//{
//    if (clientGrid.SelectedItem == null)
//    {
//        MessageBox.Show("Выбирите клиента для удаления");
//    }
//    else if (MessageBox.Show("Вы уверены что хотите удалить клиента " + ((DataRowView)clientGrid.SelectedItem)[1].ToString() + " " + ((DataRowView)clientGrid.SelectedItem)[2].ToString() + "?", "", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
//    {
//        using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["TryEkz.Properties.Settings.TryEkzConnectionString"].ConnectionString))
//        {
//            connect.Open();
//            SqlCommand command = new SqlCommand("update [Клиент] set [Статус]=0 where ID ='" + ((DataRowView)clientGrid.SelectedItem)[0].ToString() + "'", connect);
//            SqlDataReader reader = command.ExecuteReader();
//            MessageBox.Show("Клиент успешно удалён!");
//        }
//        refreshClientTable();
//    }
//}

//private void addBTN_Click(object sender, RoutedEventArgs e)
//{
//    inputGroup.IsEnabled = true;
//    okBTN.Content = "Добавить";
//}

//int selectedKlient;
//private void changeBTN_Click(object sender, RoutedEventArgs e)
//{
//    if (clientGrid.SelectedItem == null)
//    {
//        MessageBox.Show("Выбирите клиента для изменения");
//    }
//    else
//    {
//        selectedKlient = (int)((DataRowView)clientGrid.SelectedItem)[0];
//        nameText.Text = ((DataRowView)clientGrid.SelectedItem)[1].ToString();
//        famText.Text = ((DataRowView)clientGrid.SelectedItem)[2].ToString();
//        countryText.Text = ((DataRowView)clientGrid.SelectedItem)[3].ToString();
//        cityText.Text = ((DataRowView)clientGrid.SelectedItem)[4].ToString();
//        phoneText.Text = ((DataRowView)clientGrid.SelectedItem)[5].ToString();
//        inputGroup.IsEnabled = true;
//        okBTN.Content = "Изменить";
//    }
//}

//private void cancelBTN_Click(object sender, RoutedEventArgs e)
//{
//    cleanInputGroup();
//    okBTN.Content = "OK";
//    inputGroup.IsEnabled = false;
//}

//private void deleteBTN_Click(object sender, RoutedEventArgs e)
//{
//    if (clientGrid.SelectedItem == null)
//    {
//        MessageBox.Show("Выбирите клиента для удаления");
//    }
//    else if (MessageBox.Show("Вы уверены что хотите удалить клиента " + ((DataRowView)clientGrid.SelectedItem)[1].ToString() + " " + ((DataRowView)clientGrid.SelectedItem)[2].ToString() + "?", "", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
//    {
//        using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["TryEkz.Properties.Settings.TryEkzConnectionString"].ConnectionString))
//        {
//            connect.Open();
//            SqlCommand command = new SqlCommand(" DELETE from [Клиент] where ID ='" + ((DataRowView)clientGrid.SelectedItem)[0].ToString() + "'", connect);
//            SqlDataReader reader = command.ExecuteReader();
//            MessageBox.Show("Клиент успешно удалён!");
//        }
//        refreshClientTable();
//    }
//}

//private void srcBTN_Click(object sender, RoutedEventArgs e)
//{
//    try
//    {
//        using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["TryEkz.Properties.Settings.TryEkzConnectionString"].ConnectionString))
//        {
//            connect.Open(); // открытие подключения
//            DataTable clientTable = new DataTable(); //создание таблицы
//            SqlDataAdapter clientAdapter = new SqlDataAdapter("Select * from Клиент where Фамилия like '%" + srcText.Text + "%'", connect); //получение таблицы клиентов
//            clientAdapter.Fill(clientTable); //заполение таблицы из БД
//            clientGrid.ItemsSource = clientTable.DefaultView; // вывод таблицы на форму
//        }
//    }
//    catch (Exception)
//    {
//        MessageBox.Show("Произошла ошибка");
//        throw;
//    }
//}
//    }
//}

