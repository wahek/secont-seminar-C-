﻿//Привет, не смотри что у меня тут написано, Листай дальше вниз, это просто семинар =) 45 Строка
//       ||||
//       ||||
//       ||||
//       ||||
//       \\//
//        \/
//_____________________________________________________________________________________________________________________
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int number = new Random ().Next (100,1000); 
// int num1 = number/ 100; 
// int num2 = number % 10; 
// Console.WriteLine($"Получили число {num1}{num2}");

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// Console.WriteLine("Введи два числа");
// int num0 = int.Parse(Console.ReadLine());
// int num1 = int.Parse(Console.ReadLine());
// if (num0%num1 == 0){
//     Console.Write("Первое число кратно второму");
// }
// else {
//     Console.WriteLine($"Первое число не кратно второму, остаток от деления {num0%num1}");
// }

// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 -> 
// ___________________________________________________________________________________________________

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if ((num>=100)&&(num<1000)){
    int lost = num % 100;
    int second = lost / 10;
    Console.Write($"Вторая цифра числа: {second}");
}
else Console.Write("Число не соответствует указанным требованиям");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
