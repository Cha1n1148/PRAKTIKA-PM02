using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika2._1
{
    public class ArrayProcessor
    {
        private int[] _array;

        public ArrayProcessor(int size)
        {
            _array = new int[size];
        }

        // Убедитесь, что метод публичный
        public void GenerateRandomArray()  // <-- Убедитесь, что здесь стоит public
        {
            Random random = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = random.Next(1, 100);  // генерируем числа от 0 до 99
            }
        }

        public int[] GetArray() => _array;

        public int[] GetEvenNumbers()
        {
            return _array.Where(x => x % 2 == 0).ToArray();
        }

        public int[] GetOddNumbers()
        {
            return _array.Where(x => x % 2 != 0).ToArray();
        }
    }
}
