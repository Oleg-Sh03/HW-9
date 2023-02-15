// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return A(m - 1, 1);
    else
      return A(m - 1, A(m, n - 1));
} 
int result = A(number1, number2);
Console.WriteLine($"m = {number1}, n = {number2} -> A(m,n) = {result}");
