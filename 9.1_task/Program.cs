using System;

namespace _9._1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                int x = GetIntegerFromUserInput("X");
                int y = GetIntegerFromUserInput("Y");
                int operationCode = GetOperationCodeFromUserInput();

                int result = Calculate(x, y, operationCode);
                Console.WriteLine($"Ваш результат = {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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

        private static int Calculate(int x, int y, int operationCode)
        {
            if (operationCode == 1)
            {
                return x + y;
            }

            if (operationCode == 2)
            {
                return x - y;
            }

            if (operationCode == 3)
            {
                return x * y;
            }

            if (operationCode == 4)
            {
                try
                {
                    return x / y;
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
