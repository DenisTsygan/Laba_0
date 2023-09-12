using System;

namespace Laba_0
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFunction();

        }
        /// <summary>
        /// Тестирование на роботоспособность и правильность выполнения функции CubingDiferenceOfTwoNumbers
        /// </summary>
        private static void TestFunction()
        {
            int firstNumber = GenerateRandomValue();
            int secondNumber = GenerateRandomValue();
            Console.WriteLine($"({firstNumber} - {secondNumber})^3 = {CubingDiferenceOfTwoNumbers(firstNumber, secondNumber)} ");
        }
        /// <summary>
        /// Генерация рандомного числа
        /// </summary>
        /// <returns></returns>
        private static int GenerateRandomValue()
        {
            Random random = new ();
            int minValue = -100;
            int maxValue = 100;
            int rundomNumber = random.Next(minValue, maxValue);
            return rundomNumber;
        }
        /// <summary>
        /// Возведения в куб разности двух целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static double CubingDiferenceOfTwoNumbers(int a,int b)
        {
            return Math.Pow((a - b), 3);
        }
        
    }
}
