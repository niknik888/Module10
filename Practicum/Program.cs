using System;



namespace Practicum
{
    public class Program
    {
        ILogger Logger { get; set; }
        public static void Main(string[] args)
        {
            Calculate calculate = new Calculate(new Logger());
            try
            {
                Console.Write("Введите первое число: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"Результат: {calculate.Action(a, b)}");
            }
            catch (FormatException)
            {
                calculate.ActionError("Ошибка: Введите корректное числовое значение.");
            }
            catch (Exception ex)
            {
                calculate.ActionError($"Произошла ошибка: {ex.Message}");
            }
        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);

    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }



    public interface ICalculate
    {
        public int Action(int a, int b);
        public void ActionError(string message);
    }


    public class Calculate : ICalculate
    {
        private readonly ILogger _logger;

        public Calculate(ILogger logger)
        {
            _logger = logger;
        }

        public int Action(int a, int b)
        {
            _logger.Event("Выполнена операция сложения.");
            return a + b;
        }

        public void ActionError(string message)
        {
            _logger.Error(message);
        }
    }
}