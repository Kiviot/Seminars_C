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


