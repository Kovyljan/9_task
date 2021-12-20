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
                _x = GetIntegerFromUserInput("X");
                _y = GetIntegerFromUserInput("Y");
                _operation_code = GetOperationCodeFromUserInput();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }


        private static int GetIntegerFromUserInput(string variableName)
        {
            try
            {
                Console.Write($"Введите целое число. {variableName}=");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                throw new Exception($"Ошибка! Входная строка на число {variableName} имеет не верный формат.");
            }
            catch (OverflowException)
            {
                throw new Exception($"Ошибка! Входная строка на число {variableName} больше MaxValue или меньше MinValue.");
            }
        }

        private static int GetOperationCodeFromUserInput()
        {
            Console.WriteLine("Введите код операции:");
            Console.WriteLine(
                "\t1 - Сложение\n" +
                "\t2 - вычитание\n" +
                "\t3 - произведение\n" +
                "\t4 - частное"
            );
            Console.Write("Ваш выбор: ");

            int operationCode;

            try
            {
                operationCode = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
                {
                throw new Exception("Код операции должен быть целым числом, а не строкой.");
                }

            if (operationCode < 1 || operationCode > 4)
                {
                throw new Exception("Нет операции с указанным номером");
                }

            return operationCode;
                }
                else if (_operation_code == 4)
                {
                    try
                    {
                        Console.WriteLine($"Ваш результат = {_x / _y}");
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
            }

            Console.ReadKey();
        }

        private static int GetIntegerFromUserInput(string variableName)
        {
            try
            {
                Console.Write($"Введите целое число. {variableName}=");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                throw new Exception($"Ошибка! Входная строка на число {variableName} имеет не верный формат.");
            }
            catch (OverflowException)
            {
                throw new Exception($"Ошибка! Входная строка на число {variableName} больше MaxValue или меньше MinValue.");
            }
        }
    }
}
