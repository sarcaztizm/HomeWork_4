// Принять на вход два числа (А и В)
// и возвести числа А в натуральную степень В

Console.Clear();
Console.WriteLine("Введите числа A и B");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
double Result = 1;

// Решение с использованием мат. функицей Math.Pow
// double Result = Math.Pow(A, B);
// Console.WriteLine($"{A} в степени {B} равно {Result}");

for (int i = 0; i < B; i++)
{
   Result *= A;
}
Console.WriteLine($"{A} в степени {B} равно {Result}");