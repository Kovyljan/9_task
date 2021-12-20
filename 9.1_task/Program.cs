using System;

namespace _9._1_task
{
    class Program
    {
        private static int _x = 0;
        private static int _y = 0;
        private static int _operation_code = 0;
        private static bool _b = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                Console.Write("Введите целое число. X=");
                _x = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка! Входная строка на число X имеет не верный формат.");
                _b = false;
            }

            if (_b == true)
            {
                try
                {
                    Console.Write("Введите целое число. Y=");
                    _y = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка! Входная строка на число Y имеет не верный формат.");
                    _b = false;
                }

                if (_b == true)
                {
                    Console.WriteLine("Введите код операции:");
                    Console.WriteLine("     1 - Сложение\n     2 - вычитание\n     3 - произведение\n     4 - частное");
                    Console.Write("Ваш выбор: ");

                    _operation_code = Convert.ToInt32(Console.ReadLine());
                }
                }

            if (_b == true)

                if (_operation_code == 1)
                {
                    Console.WriteLine("Ваш результат = {0}", _x + _y);
                }
                else if (_operation_code == 2)
                {
                    Console.WriteLine("Ваш результат = {0}", _x - _y);
                }
                else if (_operation_code == 3)
                {
                    Console.WriteLine("Ваш результат = {0}", _x * _y);
                }
                else if (_operation_code == 4)
                {
                    try
                    {
                        Console.WriteLine("Ваш результат = {0}", _x / _y);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Ошибка! Деление на нуль!");
                    }
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }

            Console.ReadKey();
        }
    }
}
