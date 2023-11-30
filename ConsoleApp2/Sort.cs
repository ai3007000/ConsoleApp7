using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Task2
{
    /// <summary>
    /// Специальный класс для сортировки массивов строк
    /// </summary>
    class Sort
    {
        string[] arr { get; set; }
        public delegate void DelegateSort(string message);
        public event DelegateSort? EventInputSort;
        public Sort(string[] arr)
        {
            this.arr = arr;
        }
        /// <summary>
        /// Простая сортировка массива
        /// </summary>
        /// <param name="arr">Массив сток</param>
        /// <returns>Отсортированный массив</returns>
        public string[] SortArray(string[] arr)
        {
            this.EventInputSort?.Invoke("Простая сортировка массива.");
            Array.Sort(arr);
            return arr;
        }
        /// <summary>
        /// Реверсивная сортировка массива
        /// </summary>
        /// <param name="arr">Массив строк</param>
        /// <returns>Отсортированный массив</returns>
        public string[] SortReverseArray(string[] arr)
        {
            this.EventInputSort?.Invoke("Реверсивная сортировка массива.");
            Array.Sort(arr);
            Array.Reverse(arr);
            return arr;
        }
    }
}
