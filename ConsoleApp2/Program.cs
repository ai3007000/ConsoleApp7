using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] LastNames = new string[5];
                LastNames[0] = "Иванов";
                LastNames[1] = "Розетта";
                LastNames[2] = "Зора";
                LastNames[3] = "Кудрявцев";
                LastNames[4] = "Таратынов";

                Sort sortArr = new Sort(LastNames);
                sortArr.EventInputSort += Console.WriteLine;

                Console.WriteLine("Введите параметр сортировки\nЧисло 1 (сортировка А-Я), либо число 2 (сортировка Я-А)");
                var Input = Console.ReadLine();

                bool result = byte.TryParse(Input, out var InputNumber);
                if (result)
                {
                    switch (InputNumber)
                    {
                        case 1:
                            LastNames = sortArr.SortArray(LastNames);
                            break;
                        case 2:
                            LastNames = sortArr.SortReverseArray(LastNames);
                            break;
                        default:
                            throw new MyException("Ошибка ввода параметра сортирвки.");
                    }
                }
                else
                {
                    throw new MyException("Ошибка конвертации.");
                }


                foreach (var item in LastNames) // Вывод ответа
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}