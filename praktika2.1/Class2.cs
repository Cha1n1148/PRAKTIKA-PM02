using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace praktika2._1
{
    public class GraphDrawer
    {
        public static void DrawHistogram(Canvas canvas, int[] data, string title)
        {
            // Очищаем старые элементы
            canvas.Children.Clear();

            // Размеры
            double barWidth = 40;
            double maxHeight = 250;  // максимальная высота гистограммы

            // Заголовок
            TextBlock titleBlock = new TextBlock
            {
                Text = title,
                FontSize = 16,
                FontWeight = FontWeights.Bold,
                Foreground = Brushes.Black,
                Margin = new Thickness(10, 10, 0, 0)
            };
            canvas.Children.Add(titleBlock);

            // Рисуем гистограмму
            for (int i = 0; i < data.Length; i++)
            {
                // Высота гистограммы пропорциональна значению массива
                double barHeight = data[i] * maxHeight / 100;  // масштабируем по максимальному значению

                // Создаем столбик гистограммы
                Rectangle bar = new Rectangle
                {
                    Width = barWidth,
                    Height = barHeight,
                    Fill = Brushes.DeepSkyBlue,
                    Margin = new Thickness(50 + (i * (barWidth + 10)), 50 + (maxHeight - barHeight), 0, 0)  // отступы
                };

                // Добавляем столбик в Canvas
                canvas.Children.Add(bar);

                // Создаем подпись к столбцу
                TextBlock valueText = new TextBlock
                {
                    Text = data[i].ToString(),  // отображаем значение
                    FontSize = 12,
                    Foreground = Brushes.Black,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Top,
                    Margin = new Thickness(50 + (i * (barWidth + 10)) + (barWidth / 2) - 10, 50 + (maxHeight - barHeight) - 20, 0, 0) // поднимаем текст чуть выше столбика
                };

                // Добавляем подпись к Canvas
                canvas.Children.Add(valueText);
            }
        }
    }
}
