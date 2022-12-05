// Console.Write("Write number: ");
// int number = Convert.ToInt32(Console.ReadLine()); //тип данных имя = значение
// //int result = number * number; //результат возведения в квадрат
// double result = Math.Pow(number, 2);// вариант через функцию: результат возведения в квадрат
// Console.WriteLine(number); //вывод числа
// System.Console.WriteLine(result);//вывод результата

// Console.Write("Write first number: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Write second number: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (secondNumber * secondNumber == firstNumber)
// {
//     System.Console.WriteLine("TRUE");
// }
// else System.Console.WriteLine("Folse");

// System.Console.WriteLine("Write your number: ");
// int positiveNumber = Convert.ToInt32(Console.ReadLine());
// if (positiveNumber <1) positiveNumber *= -1;
// int negativeNumber = positiveNumber * (-1);
// while (negativeNumber <= positiveNumber)
// {
//     System.Console.Write(negativeNumber + " ");
//     negativeNumber += 1;
// }

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


// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > arg1) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

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
// test

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

//HomeWork
//Ex10
// int number = new Random().Next(100, 1000);
// int del = (number / 10) % 10;
// System.Console.WriteLine(number);
// System.Console.WriteLine("второе число равно: " + del);

//Ex13
// int number = new Random().Next(1000, 1000000);
// int del = number;
// int index = 0;
// while  (del / 10 != 0)
// {
//         del = del / 10;
//     index ++;
// }

// int stepen = Convert.ToInt32(Math.Pow(10, (index-1)));
// int thirdDigit = (number % stepen)/(stepen / 10);

// System.Console.WriteLine(number);
// //System.Console.WriteLine(stepen);
// System.Console.WriteLine("количество знаков введенного числа: " + (index + 1));
// System.Console.WriteLine("третья цифра равна: " + thirdDigit);

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