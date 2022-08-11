﻿Console.WriteLine("Введите любое целое число, и я покажу его третью цифру, если она есть");
int a = Convert.ToInt32 (Console.ReadLine());
int discharge = 1; // переменная для поиска третьего числа (на 2 разряда меньше, чем число)
int step = 100; // переменная для цикла
int third = 0; // третья цифра числа
a = Math.Abs (a); // вводим модуль для возможности работы с отрицательными числами
if ((a%10 == a) || (a%100 == a)) // условие для 1- и 2-значных чисел
{
    Console.WriteLine ("В числе нет третьей цифры!");
}
else 
{
while (a > a % step) // открываем цикл, для чисел, начиная со 100, для поиска 3 цифры
    {
        third = (a % (discharge*10)) / (discharge); // поиск третьей цифры (например, 5678%100 = 78, 78/10 = 7)
        step = step * 10;
        discharge = discharge * 10;
    }
    Console.WriteLine ($"Третья цифра числа равна {third}");
}
