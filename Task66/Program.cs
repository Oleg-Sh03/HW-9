// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void IncorrectValue()
{
Console.WriteLine("Введено некорректное значение");
Environment.Exit(0);
}

int UserInput()
{
if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
return temp;
}

int sumM = 0;
int sumN = 0;
int sumE = 0;
void IntegerSum(int numM, int numN)
{
if (numM < numN)
{
sumM = sumM + numM;
IntegerSum(numM + 1, numN);
}
else if (numM > numN)
{
sumN = sumM + numM;
IntegerSum(numM - 1, numN);
}
else if (numM == numN)
{
    sumE = numM;
}

}

Console.Write("Введите целое число M: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
int number1 = UserInput();
Console.Write("Введите целое число N: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
int number2 = UserInput();
IntegerSum(number1, number2);
Console.WriteLine($"M = {number1}; N = {number2} -> {sumM + sumN + sumE}");

