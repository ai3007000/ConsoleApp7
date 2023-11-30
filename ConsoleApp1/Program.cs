using System;

namespace ConsoleApp.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Exception[] exceptions = new Exception[5];
                exceptions[0] = new MyException(); // Моё исключение
                exceptions[1] = new FileNotFoundException(); // Файл не найден
                exceptions[2] = new IndexOutOfRangeException(); // Выход индекса за диапазон значений
                exceptions[3] = new InvalidCastException(); // ошибка преобразования типов
                exceptions[4] = new NullReferenceException(); // Обращение к объекту, который равен Null

                foreach (var item in exceptions)
                {
                    try
                    {
                        throw item;
                    }catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}