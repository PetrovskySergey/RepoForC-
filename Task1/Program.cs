// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от M до N. Использовать рекурсию, не использовать циклы.

void FromMToN(int m, int n)
{
if (m > n)
{
FromMToN(m - 1, n);
System.Console.Write(m + " ");
}
else if (n > m)
{
FromMToN(m, n - 1);
System.Console.Write(n + " ");
}
else System.Console.Write(m + " ");
}
FromMToN(4, 9);
