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

System.Console.WriteLine("Write your number: ");
int positiveNumber = Convert.ToInt32(Console.ReadLine());
if (positiveNumber <1) positiveNumber *= -1;
int negativeNumber = positiveNumber * (-1);
while (negativeNumber <= positiveNumber)
{
    System.Console.Write(negativeNumber);
    negativeNumber += 1;
}