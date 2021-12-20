using System;

namespace _9._1_task
{
    class Program
    {
        private static int _x = 0;
        private static int _y = 0;
        private static int _operation_code = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                _x = GetIntegerFromUserInput("X");
                _y = GetIntegerFromUserInput("Y");
                _operation_code = GetOperationCodeFromUserInput();

                var result = Calculate();
                Console.WriteLine($"Ваш результат = {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
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

        private static int Calculate()
        {
            if (_operation_code == 1)
            {
                return _x + _y;
            }

            if (_operation_code == 2)
            {
                return _x - _y;
            }

            if (_operation_code == 3)
            {
                return _x * _y;
            }

            if (_operation_code == 4)
            {
                try
                {
                    return _x / _y;
                }
                catch (DivideByZeroException)
                {
                    throw new Exception("Ошибка! Деление на нуль!");
                }
            }

            throw new Exception("Нет операции с указанным номером");
        }
    }
}
