using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace praktika2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ArrayProcessor _arrayProcessor;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void GenerateArray(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(SizeTextBox.Text, out int size))
            {
                // Создаем обработчик для массива
                _arrayProcessor = new ArrayProcessor(size);

                // Генерация случайных чисел в массиве
                _arrayProcessor.GenerateRandomArray();

                MessageBox.Show("Массив сгенерирован!");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите целое число.");
            }
        }

        private void ShowOriginalGraph(object sender, RoutedEventArgs e)
        {
            if (_arrayProcessor == null) return;

            int[] array = _arrayProcessor.GetArray();
            GraphDrawer.DrawHistogram(GraphCanvas, array, "Исходный массив");
        }

        private void ShowEvenGraph(object sender, RoutedEventArgs e)
        {
            if (_arrayProcessor == null) return;

            int[] evenNumbers = _arrayProcessor.GetEvenNumbers();
            GraphDrawer.DrawHistogram(GraphCanvas, evenNumbers, "Четные числа");
        }

        private void ShowOddGraph(object sender, RoutedEventArgs e)
        {
            if (_arrayProcessor == null) return;

            int[] oddNumbers = _arrayProcessor.GetOddNumbers();
            GraphDrawer.DrawHistogram(GraphCanvas, oddNumbers, "Нечетные числа");
        }
    }

}


