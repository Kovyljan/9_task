using System;

namespace _9._1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            Console.WriteLine("Вас приветствует калькулятор!");
            int X = 0, Y = 0, operation_code = 0, operation = 0;
            
            try
            {
                Console.Write("Введите целое число. X=");
                int x = Convert.ToInt32(Console.ReadLine());
                X = x;
            }
            catch
            {
                Console.WriteLine("Ошибка! Входная строка на число X имеет не верный формат.");
                b = false;                
            }

            if (b == true)
            {
                try
                {
                    Console.Write("Введите целое число. Y=");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Y = y;
                }
                catch
                {
                    Console.WriteLine("Ошибка! Входная строка на число Y имеет не верный формат.");
                    b = false;
                }

                if (b == true)
                {
                    Console.WriteLine("Введите код операции:");
                    Console.WriteLine("     1 - Сложение");
                    Console.WriteLine("     2 - вычитание");
                    Console.WriteLine("     3 - произведение");
                    Console.WriteLine("     4 - частное");
                    Console.Write("Ваш выбор: ");
                    int oper_code = Convert.ToInt32(Console.ReadLine());
                    operation_code = oper_code;
                }

            }
                        
                if (operation_code == 1)
                {
                    operation = X + Y;
                Console.WriteLine("Ваш результат = {0}", operation);
                }
                else if(operation_code == 2)
                {
                    operation = X - Y;
                Console.WriteLine("Ваш результат = {0}", operation);
                }
                else if (operation_code == 3)
                {
                    operation = X * Y;
                Console.WriteLine("Ваш результат = {0}", operation);
                }
                else if (operation_code == 4)
                {
                    operation = X / Y;
                Console.WriteLine("Ваш результат = {0}", operation);
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }
               
            Console.ReadKey();
        }
    }
}
