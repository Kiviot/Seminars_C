﻿// Lection 3
// 1. Метод, который ничего не принемает и ничего не возвращает

// void Method1()
// {
//     System.Console.WriteLine("Autor ...");
// }
// Method1();

// ==========================================================================================
// 2. Метод, который что-то принемает, но ничего не возвращает


// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2(msg: "text message");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Text", 5);

// ==========================================================================================

//Var2 
// 3. Метод, который что-то возвращает, но ничего не принимает

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// System.Console.WriteLine(year);

// ==========================================================================================

//4. Метод, который что-то принемает и что-то возвращает

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//         while (i < count)
//         {
//             result = result + text;
//             i++;
//         }
//         return result;
// }
// string res = Method4(10, "New Text ");
// System.Console.WriteLine(res);

// ==========================================================================================

//Цикл со счётчиком "for"

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result; // не забывать про возвращение результата. Иначе будет ошибка!! RETURN RESULT
// }
// string res = Method4(10, "New Text ");
// System.Console.WriteLine(res);

// ==========================================================================================

//Цикл в цикле
// Пример: вывод таблицы умножения на экран

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i*j}"); // интерполяция строк
//     }
//     System.Console.WriteLine();
// }

// ==========================================================================================

// Редактирование текста

// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


//string text = “— Я думаю, — сказал князь, улыбаясь, — что,”
// ● ”ежели бы вас послали вместо нашего милого Винценгероде,”
// ● ”вы бы взяли приступом согласие прусского короля.”
// ● ”Вы так красноречивы. Вы дадите мне чаю?”;
// В нашем случае требуется небольшое пояснение, если будет какая-то строка, то для этой
// строки есть некоторое количество вспомогательного функционала.
// // string s = “qwerty”
// // 012345
// В частности, если требуется обратиться к конкретному символу строки, мы можем это делать,
// начиная отсчитывать позицию символов с 0. То есть «q» — это 0, «w» — 1, «e» — 2 и так далее.
// Чтобы получить конкретный символ, мы можем через квадратные скобки обратиться, указать
// идентификатор строки. Например:
// // s[3] // r

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replayce(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replayce(text, ' ', '_');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replayce(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replayce(newText, 'С', 'с');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// ==========================================================================================

// Упорядочивание массива

// int[] array = {2, 5, 4, 3, 2, 0, 7, 6, 8, 1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length -1; i++)
//     {
//         int minPosition = i;
        
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
        
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }


// PrintArray(array);
// SelectionSort(array);

// PrintArray(array);

// ==========================================================================================

// Упорядочивание массива от большего к меньшему

// int[] array = {2, 5, 4, 3, 2, 0, 7, 6, 8, 1};

// void PrintArray(int[] array)//вводим метод для вывода массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();//строка для разделения изначального массива от нового
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length -1; i++)
//     {
//         int maxPosition = i;//считаем что на первой позиции находится максимальный элемент массива
        
//         for (int j = i + 1; j < array.Length; j++)//поиск максимального элемента массива
//         {
//             if(array[j] > array[maxPosition]) maxPosition = j;//берем следующий элемент и сравниваем его с предыдущим (1 and 0; 2 and 1 ...)
//         }
        
//         int temporary = array[i];//вводим переменную, которая будет временно хранить макс значения
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//     }
// }


// PrintArray(array);
// SelectionSort(array);

// PrintArray(array);

// ==========================================================================================
// ==========================================================================================
// Лекция №4 
// Двумерные массивы и рекурсия

//string[,] table = new string[2, 5];
//String.Empty - инициализация массива
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]

// ==========================================================================================

// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         System.Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }
// ==========================================================================================
// int[,] matrix = new int[3, 4];
// for (int rows = 0; rows < matrix.GetLength(0); rows++)
// {
//     for (int colums = 0; colums < matrix.GetLength(1); colums++)
//     {
//         System.Console.Write($"{matrix[rows, colums]} ");
//     }
//     System.Console.WriteLine();
// }
// ==========================================================================================

// void PrintArray(int[,] matr, int minValue, int maxValue)
// {
//     int sizeRows = matr.GetLength(0);
//     int sizeColums = matr.GetLength(1);
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             matr[i, j] = new Random().Next(minValue, maxValue);
//             System.Console.Write($"{matr[i, j]} ");
//         }
//         System.Console.WriteLine();
// }
// }

// Console.WriteLine("Введите нижнюю границу диапазона: ");
// int minValue = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите верхнюю границу диапазона: ");
// int maxValue = int.Parse(Console.ReadLine()!);

// int[,] matrix = new int[3, 4];
// PrintArray(matrix, minValue, maxValue);

// ==========================================================================================

// void PrintArray(int[,] matr)// Задание массива
// {
//     int sizeRows = matr.GetLength(0);
//     int sizeColums = matr.GetLength(1);
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             System.Console.Write($"{matr[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)// Заполнение массива
// {
//     int sizeRows = matr.GetLength(0);
//     int sizeColums = matr.GetLength(1);
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// ==========================================================================================

// int[,] pic = new int[,]
// {
//     {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//     {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
// };

// void PrintImage(int[,] image)// Задание массива
// {
//     int sizeRows = image.GetLength(0);
//     int sizeColums = image.GetLength(1);
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             if(image[i, j] == 0) System.Console.Write(" ");// чтобы нормально переходило по строчкам - нужно вызывать команду Write!!
//             else System.Console.Write("+");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)// Заполнение массива
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// PrintImage(pic);
// FillImage(5, 5);
// System.Console.WriteLine();
// PrintImage(pic);

// ==========================================================================================

//  double Factorial (int n)
//  {
//     // 1! = 1
//     // 0! = 1
//     if( n == 1) return 1;
//     else return n * Factorial(n-1);
//  }
//  for (int i = 1; i < 40; i++)
//  {
//     System.Console.WriteLine($"{i}! = {Factorial(i)}");
//  }
//  //System.Console.WriteLine(Factorial(5));

// ==========================================================================================
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
// double Fibonachi(int n)
//  {
//     if(n == 1) return 1;
//     else if(n == 2) return 1;
//     else return Fibonachi(n - 1) + Fibonachi(n - 2);
//  }
//  for (int i = 1; i < 20; i++)
//  {
//     System.Console.Write($"{Fibonachi(i)}, ");
//  }
// ==========================================================================================
//Var.2
// double Fibonachi(int n)
//  {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonachi(n - 1) + Fibonachi(n - 2);
//  }
//  for (int i = 1; i < 20; i++)
//  {
//     System.Console.WriteLine($"f{i} = {Fibonachi(i)}, ");
//  }
// ==========================================================================================
// ==========================================================================================
// int a = 12;
// System.Console.WriteLine(a.GetType().Name);

// var b = 12;
// System.Console.WriteLine(b.GetType().Name);

// var data = new int[] {1, 2, 3, 4};

// ==========================================================================================

/*
using System.Diagnostics;

int size = 1_000_000;
int m = 300;
int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();
            
//System.Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();


int max = 0;
for (int i = 0; i < array.Length - m; i++)
{
    int t = 0;
    for (int j = i; j < i + m; j++)
    {
        t += array[j];
                
    }
    if (t > max) max = t;
}


sw.Stop();
System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
System.Console.WriteLine(max);


*/
/*
using System.Diagnostics;

int size = 1_000_000;
int m = 500_000;
int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();
            
//System.Console.WriteLine($"[{string.Join(", ", array)}]");


Stopwatch sw = new();
sw.Start();


int max = 0;
for (int j = 0; j < m; j++) max += array[j];
int t = max;
for (int i = 1; i < array.Length - m; i++)
{
    t = t - array[i - 1] + array[i + (m - 1)];
    if (t > max) max = t;
}


sw.Stop();
System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
System.Console.WriteLine(max);
*/
/*
void SelectionSort(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection[j] < collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
}
*/
/*
using static Sorting;

int[] array = {7, 6, 3, 4, 5, 1, 2, 3};
System.Console.WriteLine($"{String.Join(',', array)}");
SelectionSort(array);
System.Console.WriteLine($"{String.Join(',', array)}");
*/
/*
using static Sorting;
using static System.Console;

int[] array = {7, 6, 3, 4, 5, 1, 2, 3};
WriteLine($"{String.Join(',', array)}");
SelectionSort(array);
WriteLine($"{String.Join(',', array)}");
*/
/*
using static Sorting;
using static Infrastructure;

int[] array = CreateArray(10);

Print(array);
SelectionSort(array);
Print(array);
*/
// using static Sorting;
// using static Infrastructure;
// using System.Diagnostics;

// 15.CreateArray(2, 10)
//   .Print(" | ")
//   .SelectionSort()
//   .Print(" | ")
//   ;

// int[] arr = 10.CreateArray(10, 20);
// arr.Print();
// arr.SelectionSort();
// arr.Print();

/*
10.CreateArray(min: 10, max: 50)
  .Print()
  .SelectionSort()
  .Print()
  ;
*/
/*
Сорьтровка пузырьком
//Попарно сравниваем элементы массива
//Если соседние элементы необходимо поменять, тогда их меняем.
//После обмена проходим массив сначала

0. [3, 1, 5, 0, 7, 9, 8]
1. [1, 3, 5, 0, 7, 9, 8]
2. [1, 3, 0, 5, 7, 9, 8]
3. [1, 0, 3, 5, 7, 9, 8]
4. [0, 1, 3, 5, 7, 9, 8]
5. [0, 1, 3, 5, 7, 8, 9]
6. [0, 1, 3, 5, 7, 8, 9]
*/
/*
10.CreateArray(0, 10)
  .Print()
  .BoobleTipeSort()
  .Print()
  ;
  */
/*
Random random = new Random();

int size= 10 + random.Next(10);
int[] array = new int[size];
int index = 0;
while (index < size)
{
    array[index] = random.Next(20);
    Console.Write(array[index].ToString() + ", ");
    index = index + 1;
}
int i = 0;
int j = 0;
int minPose;
while (i < size)
{
    minPose = i;
    j = i;
    while (j < size)
    {
        if (array[j] < array[minPose]) minPose = j;
        j ++;
    }
    int temp = array[i];
    array[i] = array[minPose];
    array[minPose] = temp;
    i = i + 1;
}
System.Console.WriteLine();
index = 0;
while (index < size)
{
    Console.Write(array[index].ToString() + ", ");
    index ++;
}
*/
using static Sorting;
using static Infrastructure;
using System.Diagnostics;


// Stopwatch sw = new();
// sw.Start();

// 1000.CreateArray(min: 10, max: 100)
//   .Print()
//   .SelectionSort()
//   .Print()
//   ;

// sw.Stop();
// System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");


// Stopwatch sw = new();
// sw.Start();

// 1000.CreateArray(min: 10, max: 100)
//   .Print()
//   .BoobleTipeSort()
//   .Print()
//   ;

// sw.Stop();
// System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");

// Stopwatch sw = new();
// sw.Start();

// int size = 1000;
// size.CreateArray(min: 10, max: 100)
//   .Print()
//   .SortQuick(0, size - 1)
//   .Print()
//   ;

// sw.Stop();
// System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");