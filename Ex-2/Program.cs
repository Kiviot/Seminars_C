// Lection 3
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

int[] array = {2, 5, 4, 3, 2, 0, 7, 6, 8, 1};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();//строка для разделения изначального массива от нового
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int maxPosition = i;//считаем что на первой позиции находится максимальный элемент массива
        
        for (int j = i + 1; j < array.Length; j++)//поиск максимального элемента массива
        {
            if(array[j] > array[maxPosition]) maxPosition = j;//берем следующий элемент и сравниваем его с предыдущим (1 and 0; 2 and 1 ...)
        }
        
        int temporary = array[i];//вводим переменную, которая будет временно хранить макс значения
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}


PrintArray(array);
SelectionSort(array);

PrintArray(array);

// ==========================================================================================