using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentScoreData
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иванов Иван Иванович";
            int age = 20;
            string email = "ivanov@mail.ru";
            double scoreProgramming = 30.75;
            double scoreMath = 50.89;
            double scorePhysics = 40.32;
            string studentScoreData = "Ф.И.О.: {0} \nВозраст: {1} \nEmail: {2} \nПрограммирование, баллы: {3} \nМатематика, баллы: {4} \nФизика, баллы: {5}";
            Console.WriteLine(studentScoreData,
                fullName,
                age,
                email,
                scoreProgramming,
                scoreMath,
                scorePhysics);
            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();

            Console.WriteLine();

            double scoreSum = scoreProgramming + scoreMath + scorePhysics;
            double scoreArithmeticMean = scoreSum / 3;
            Console.WriteLine("Сумма баллов: {0} \nСреднее арифметическое баллов: {1}",
                scoreSum,
                scoreArithmeticMean);
            Console.WriteLine();
            Console.WriteLine("Для закрытия окна нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
