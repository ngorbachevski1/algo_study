
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите верхнюю границу: ");
            decimal levelUp = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите нижнюю границу: ");
            decimal levelDown = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите шаг уровня: ");
            decimal stepSize = Convert.ToDecimal(Console.ReadLine());

            // Определяем количество уровней
            int stepLevels = (int)((levelUp - levelDown) / stepSize) + 1;
            
            Console.WriteLine($"\nВаши текущие значения:\n" +
                $"Верхняя граница = {levelUp}\n" +
                $"Нижняя граница = {levelDown}\n" +
                $"Шаг уровня = {stepSize}\n" +
                $"Предлагаемое количество уровней = {stepLevels}\n");

            
            Console.WriteLine("\nВведены верные значения? Yes - 1 No - 0");

            int answerData = Convert.ToInt32(Console.ReadLine());

            var stepLevelsArray = new List<decimal>();

            // Проверка на правильность введенных данных. Согласие пользователя
            if (answerData == 1)
            {
                // Проверка на реальную правильность введенных данных
                if (levelUp > levelDown + stepSize)
                {
                    for (decimal i = levelDown; i <= levelUp; i = i + stepSize)
                    {
                        stepLevelsArray.Add(i);
                        Console.WriteLine($"Уровень: {i}");
                    }
                }
                else
                {
                    Console.WriteLine("Введены неверные данные или невозможно определить уровни");
                }
            }
            else
            {
                Console.WriteLine("\nПерезапустите программу и введите правильные значения");
            }
            Console.WriteLine($"\nКоличество уровней в массиве = {stepLevelsArray.Count}\n");
        }
    }
}


/*
Нужна нижняя цена
Нужна верхняя цена
Шаг уровня

Программа должна расчитать количество уровней (целое число)
Заполнить массив и вывести на экран
 */