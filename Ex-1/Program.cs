﻿// Console.Write("Write number: ");
// int number = Convert.ToInt32(Console.ReadLine()); //тип данных имя = значение
// //int result = number * number; //результат возведения в квадрат
// double result = Math.Pow(number, 2);// вариант через функцию: результат возведения в квадрат
// Console.WriteLine(number); //вывод числа
// System.Console.WriteLine(result);//вывод результата

// ==========================================================================================

// Console.Write("Write first number: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Write second number: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (secondNumber * secondNumber == firstNumber)
// {
//     System.Console.WriteLine("TRUE");
// }
// else System.Console.WriteLine("Folse");

// ==========================================================================================

// System.Console.WriteLine("Write your number: ");
// int positiveNumber = Convert.ToInt32(Console.ReadLine());
// if (positiveNumber <1) positiveNumber *= -1;
// int negativeNumber = positiveNumber * (-1);
// while (negativeNumber <= positiveNumber)
// {
//     System.Console.Write(negativeNumber + " ");
//     negativeNumber += 1;
// }

// ==========================================================================================

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 450;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 313;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// System.Console.WriteLine(max);

// ==========================================================================================

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > arg1) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// ==========================================================================================

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 45;
// int c2 = 33;
// int a3 = 201;
// int b3 = 23;
// int c3 = 313;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// // int max = Max(max1, max2, max3);

// int max = Max(
//         Max(a1, b1, c1), 
//         Max(a2, b2, c2), 
//         Max(a3, b3, c3));

// System.Console.WriteLine(max);

// ==========================================================================================


// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > arg1) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int[] array = {11, 21, 31, 14, 15, 61, 17, 18, 19};
// array[0] = 121;

// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );

// System.Console.WriteLine(max);

// ==========================================================================================

// int[] array = {11, 21, 31, 14, 18, 15, 61, 17, 18, 19};

// int n = array.Length;
// int find = 18;

// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//     {
//         System.Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

// ==========================================================================================

// void FillArray(int[] collection)
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }
// int indexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while (index < count)
//     {
//         if(collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();

// int pos = indexOf(array, 4);
// System.Console.WriteLine(pos);

// ==========================================================================================

// int number = new Random().Next(10, 100);
// // Console.WriteLine(number);

// int FirstDigit = number / 10; //первая цифра рандомного числа

// int SecondDigit = number % 10;//вторая цифра рандомного числа

// // Console.WriteLine(FirstDigit);
// // Console.WriteLine(SecondDigit);

// int max = FirstDigit; //пусть максимум - первая цифра числа

// if(SecondDigit > max)
// {
//     max = SecondDigit;
// }

// Console.WriteLine("Исходное число равно: " + number);
// Console.WriteLine("Максимальная цифра в исходном числе: " + max);

// ==========================================================================================

//Задача №11
// int number = new Random().Next(100, 1000);
// int FirstDigit = number / 100;
// int LastDigit = number % 10;
// System.Console.WriteLine(number);
// System.Console.WriteLine(FirstDigit);
// System.Console.WriteLine(LastDigit);
// int NewNumber = (FirstDigit * 10) + LastDigit;
// System.Console.WriteLine(NewNumber);
//Задача №12
// int FirstNumber = new Random().Next(10, 99);
// int SecondNumber = new Random().Next(10, 99);
// System.Console.WriteLine(FirstNumber);
// System.Console.WriteLine(SecondNumber);
// int Del = SecondNumber % FirstNumber; 

// if (Del == 0)
// {
//     System.Console.WriteLine(SecondNumber + " кратно " + FirstNumber);
// }
// else
// {
//     System.Console.WriteLine("Остаток от деления равен: " + Del);
// }

// ==========================================================================================

//Задача №14
// int number = new Random().Next(10, 1000);
// //int number = 161;
// int FirstDigitDel = number % 7;
// int SecondDigitDel = number % 23;
// System.Console.WriteLine(number);
// if(FirstDigitDel == 0 && SecondDigitDel == 0)
// {
// //    if(SecondDigitDel == 0);
//     System.Console.WriteLine(FirstDigitDel);
//     System.Console.WriteLine(SecondDigitDel);
//     System.Console.WriteLine("Yep");
// }
// else
// {
//     System.Console.WriteLine(FirstDigitDel);
//     System.Console.WriteLine(SecondDigitDel);
//     System.Console.WriteLine("Nope");
// }
// //System.Console.WriteLine(FirstDigitDel);
// //System.Console.WriteLine(SecondDigitDel);
// //System.Console.WriteLine("Nope");

//==========================================================================================

//HomeWork
//Ex10
// int number = new Random().Next(100, 1000);
// int del = (number / 10) % 10;
// System.Console.WriteLine(number);
// System.Console.WriteLine("второе число равно: " + del);

//==========================================================================================

// //Ex13
// int number = new Random().Next(-10000, 1000000);
// //int number = 24;
// int del = number;
// int index = 0;
// while  (del / 10 != 0)
// {
//         del = del / 10;
//     index ++;
// }
// if ((index+1) < 3) System.Console.WriteLine("Третьей цифры нет. В текущем числе " + (index + 1) + " знака");
// else
// {
//     int stepen = Convert.ToInt32(Math.Pow(10, (index-1)));
//     int thirdDigit = (number % stepen)/(stepen / 10);

//     System.Console.WriteLine(number);
//     //System.Console.WriteLine(stepen);
//     System.Console.WriteLine("количество знаков введенного числа: " + (index + 1));
//     System.Console.WriteLine("третья цифра равна: " + thirdDigit);
// }
// int stepen = Convert.ToInt32(Math.Pow(10, (index-1)));
// int thirdDigit = (number % stepen)/(stepen / 10);

// System.Console.WriteLine(number);
// //System.Console.WriteLine(stepen);
// System.Console.WriteLine("количество знаков введенного числа: " + (index + 1));
// System.Console.WriteLine("третья цифра равна: " + thirdDigit);

//==========================================================================================
// //Ex15
// System.Console.WriteLine("Введите цифровое значение дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// //System.Console.WriteLine(day);
// while (day < 1 || day > 7) 
// {
//     System.Console.WriteLine("Ошибка ввода! Введите значение от 1 до 7: ");
//     day = Convert.ToInt32(Console.ReadLine());
// }
// if (day>=1 && day<6) System.Console.WriteLine("Сегогдня будний день " + day);
// else System.Console.WriteLine("Сегодня выходной " + day);
// //System.Console.WriteLine(day);
//==========================================================================================
// System.Console.WriteLine("Введите координату по оси X:");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату по оси Y:");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x > 0 && y > 0) System.Console.WriteLine("1 четверть");
// else if(x < 0 && y > 0) System.Console.WriteLine("2 четверть");
// else if(x < 0 && y < 0) System.Console.WriteLine("3 четверть");
// else if(x > 0 && y < 0) System.Console.WriteLine("4 четверть");
// else if(x = 0 && y = 0) System.Console.WriteLine("На пересечении осей X и Y");
//==========================================================================================
//==========================================================================================
//ClassWork
//
// // System.Console.WriteLine("Введите координату X1 по оси X:");
// // int x1 = Convert.ToInt32(Console.ReadLine());
// int x1 = new Random().Next(-100, 100);
// System.Console.WriteLine("координата X1 по оси X = " + x1);
// // System.Console.WriteLine("Введите координату Y1 по оси Y:");
// // int y1 = Convert.ToInt32(Console.ReadLine());
// int y1 = new Random().Next(-100, 100);
// System.Console.WriteLine("координата Y1 по оси Y = " + y1);
// // System.Console.WriteLine("Введите координату X2 по оси X:");
// // int x2 = Convert.ToInt32(Console.ReadLine());
// int x2 = new Random().Next(-100, 100);
// System.Console.WriteLine("координата по оси X1 = " + x2);
// // System.Console.WriteLine("Введите координату Y2 по оси Y:");
// // int y2 = Convert.ToInt32(Console.ReadLine());
// int y2 = new Random().Next(-100, 100);
// System.Console.WriteLine("координата Y2 = " + y2);

// int x1x2 = x2 - x1;
// int y1y2 = y2 - y1;

// // int KvLen = Convert.ToInt32(Math.Pow(x1x2, 2)) + Convert.ToInt32(Math.Pow(y1y2, 2));
// // System.Console.WriteLine("Квадрат гипотенузы равен: " + KvLen);

// // double Len = Math.Sqrt(KvLen);
// double Len = Math.Sqrt(Convert.ToInt32(Math.Pow(x1x2, 2)) + Convert.ToInt32(Math.Pow(y1y2, 2)));
// System.Console.WriteLine("Длинна отрезка равна: " + Math.Round(Len, 3));
// ==========================================================================================
//Ex22
// int N = new Random().Next(-10, 10);
// int index = 0;
// System.Console.Write(N + " -> ");
// if(N < 0) N = N * (-1);
// while (index <= N)
// {
//     int Kv = Convert.ToInt32(Math.Pow(index, 2));
//     System.Console.Write(Kv + " ");
//     index++;
// }
// ==========================================================================================
// var2
// int N = new Random().Next(-10, 10);
// int index = 0;
// System.Console.Write(N + " -> ");
// if(N > 0)
// {
//     while (index <= N)
// {
//     int Kv = Convert.ToInt32(Math.Pow(index, 2));
//     System.Console.Write(Kv + " ");
//     index++;
// }
// }
// else
// {
//     while (N <= index)
// {
//     int Kv = Convert.ToInt32(Math.Pow(N, 2));
//     System.Console.Write(Kv + " ");
//     N++;
// }
// }
// ==========================================================================================
// var3
// int N = new Random().Next(-10, 10);
// System.Console.Write(N + " -> ");
// if(N > 0)
// {
//     for (int i = 0; i <= N; i++)
//     {
//         System.Console.Write(Math.Pow(i, 2) + " ");
//     }
// }
// else
// {
//     for (int i = 0; i >= N; i--)
//     {
//         System.Console.Write(Math.Pow(i, 2) + " ");
//     }
// }
// ==========================================================================================
// ==========================================================================================
//HomeWork
// // Ex19
// // int N = new Random().Next(10000, 100000);
// System.Console.WriteLine("введите пятизначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // System.Console.Write(N);
// int del = N;
// int index = 0;
// while  (del / 10 != 0)
// {
//         del = del / 10;
//         index ++;
// }
// if ((index+1) == 5)
// {
//     System.Console.WriteLine("количество знаков введенного числа: " + (index + 1));
//     int NewNumber = ((N % 10)*(10000)) + (((N % 100) - (N % 10))*(100)) + ((N % 1000) - (N % 100)) + (((N % 10000) - (N % 1000)) / (100)) + (((N % 100000) - (N % 10000)) / (10000));
//     System.Console.WriteLine(NewNumber);
//     if(N == NewNumber) System.Console.WriteLine("Число является полиндромом");
//     else System.Console.WriteLine("Число НЕ является полиндромом");
// }
// else System.Console.WriteLine("Это не пятизанчное число. В текущем числе " + (index + 1) + " знака");

// ==========================================================================================
// // // Ex19 Var.2


// System.Console.WriteLine("введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// while (number < 10000 || number >= 100000)
// {
//     System.Console.WriteLine("Это не пятизначное число. Введите пятизначное число: ");
//     number = Convert.ToInt32(Console.ReadLine());
// }

// int FirstDigit = (number % 10);
// int SecondDigit = ((number / 10)) % 10;
// int FirdDigit = ((number / 100)) % 10;
// int ForthDigit = (number / 1000) % 10; 
// int FifthDigit = (number / 10000) % 10; 
// System.Console.WriteLine(FirstDigit + " " + SecondDigit + " " + FirdDigit + " " + ForthDigit + " " + FifthDigit);
// int NewNumber = FirstDigit * 10000 + SecondDigit * 1000 + FirdDigit * 100 + ForthDigit * 10 + FifthDigit;
// System.Console.WriteLine(NewNumber);
// if(number == NewNumber) System.Console.WriteLine("Число является полиндромом");
// else System.Console.WriteLine("Число НЕ является полиндромом");

// ==========================================================================================

//Ex 21


// System.Console.WriteLine("Введите координату X1 по оси X:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// // int x1 = new Random().Next(-100, 100);
// // System.Console.WriteLine("координата X1 по оси X = " + x1);
// System.Console.WriteLine("Введите координату Y1 по оси Y:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// // int y1 = new Random().Next(-100, 100);
// // System.Console.WriteLine("координата Y1 по оси Y = " + y1);
// System.Console.WriteLine("Введите координату Z1 по оси Z:");
// int z1 = Convert.ToInt32(Console.ReadLine());
// // int z1 = new Random().Next(-100, 100);
// // System.Console.WriteLine("координата Z1 по оси Z = " + z1);
// System.Console.WriteLine("Введите координату X2 по оси X:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// // int x2 = new Random().Next(-100, 100);
// // System.Console.WriteLine("координата X2 по оси X = " + x2);
// System.Console.WriteLine("Введите координату Y2 по оси Y:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// // int y2 = new Random().Next(-100, 100);
// // System.Console.WriteLine("координата Y2 по оси Y = " + y2);
// System.Console.WriteLine("Введите координату Z2 по оси Z:");
// int z2 = Convert.ToInt32(Console.ReadLine());
// // int z2 = new Random().Next(-100, 100);
// // System.Console.WriteLine("координата Z2 по оси Z = " + z2);

// int x1x2 = x2 - x1;
// int y1y2 = y2 - y1;
// int z1z2 = z2 - z1;

// // int KvLen = Convert.ToInt32(Math.Pow(x1x2, 2)) + Convert.ToInt32(Math.Pow(y1y2, 2));
// // System.Console.WriteLine("Квадрат гипотенузы равен: " + KvLen);

// // double Len = Math.Sqrt(KvLen);
// double Len = Math.Sqrt(Convert.ToInt32(Math.Pow(x1x2, 2)) + Convert.ToInt32(Math.Pow(y1y2, 2)) + Convert.ToInt32(Math.Pow(z1z2, 2)));
// System.Console.WriteLine("Длинна отрезка равна: " + Math.Round(Len, 3));

// ==========================================================================================
// //Ex 23
// // var1
// int N = new Random().Next(-10, 10);
// System.Console.Write(N + " -> ");
// if(N > 0)
// {
//     for (int i = 0; i <= N; i++)
//     {
//         System.Console.Write(Math.Pow(i, 3) + " ");
//     }
// }
// else
// {
//     for (int i = 0; i >= N; i--)
//     {
//         System.Console.Write(Math.Pow(i, 3) + " ");
//     }
// }
// ==========================================================================================
// ==========================================================================================
//ClassWork
/*
Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
// int GetSum(int A)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i; // sum = sum + i
//     }
//     return sum;
// }
// System.Console.Write("Write number A: ");
// int N = int.Parse(Console.ReadLine()!);// int.Parse == Convert.ToInt32.
// System.Console.WriteLine(GetSum(N));
// ==========================================================================================
/*
Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 
*/
// int SumIndex(int A)
// {
//     int sum = A;
//     int count = 1; 
//     while (sum/10 != 0)
//     {
//         sum = sum/10;
//         count++;
//     }
//     return count;
// }
// System.Console.Write("Write number A: ");
// int N = int.Parse(Console.ReadLine()!);// int.Parse == Convert.ToInt32.
// System.Console.WriteLine(SumIndex(N));
// ==========================================================================================
//Задача № 28 
//На вход число N, на выходе произведение чисел от 1 до N

// int multiplierNumber(int N)
// {
//     int multiplier = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         multiplier *= i;
//     }
//     return multiplier;
// }
// System.Console.Write("Write number A: ");
// int N = int.Parse(Console.ReadLine()!);// int.Parse == Convert.ToInt32.
// System.Console.WriteLine(multiplierNumber(N));
// ==========================================================================================
/*
Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
// System.Console.Write("Write count array: ");
// int count = int.Parse(Console.ReadLine()!);// int.Parse == Convert.ToInt32.
// int[] GetArray()
// {
//     int[] array = new int[count];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
        
//     }
//     return array;
// }
// var str = string.Join(", ", GetArray());
// System.Console.WriteLine("[" + str + "]");

