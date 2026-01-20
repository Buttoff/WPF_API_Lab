using System;
using System.Collections.ObjectModel; // Для динамического обновления списка
using System.Windows;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        // Специальный класс для хранения записи в истории
        public class Calculation
        {
            public double NumA { get; set; }
            public double NumB { get; set; }
            public double Result { get; set; }
            public string Time { get; set; }
        }

        // Коллекция для хранения истории (ObservableCollection сама обновляет таблицу)
        private ObservableCollection<Calculation> historyList = new ObservableCollection<Calculation>();

        public MainWindow()
        {
            InitializeComponent();
            // Привязываем коллекцию к таблице
            dgHistory.ItemsSource = historyList;
        }

        // Логика расчета
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b))
            {
                double res = a - b; // Для 2 варианта выбрали вычитание
                txtResult.Text = $"Результат: {res}";

                // Добавляем объект в историю
                historyList.Add(new Calculation
                {
                    NumA = a,
                    NumB = b,
                    Result = res,
                    Time = DateTime.Now.ToLongTimeString()
                });
            }
            else
            {
                MessageBox.Show("Ошибка: введите числа!");
            }
        }

        // Переключение видимости таблицы
        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            if (dgHistory.Visibility == Visibility.Collapsed)
            {
                dgHistory.Visibility = Visibility.Visible;
                btnHistory.Content = "Скрыть историю";
            }
            else
            {
                dgHistory.Visibility = Visibility.Collapsed;
                btnHistory.Content = "Показать историю";
            }
        }
    }
}