// Принять на вход два число и сосчитать
// Сумму цифр в числе

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int Nex = N;
int Result = 0;

while (N  > 0)
{
    Result += N % 10;
    N /= 10;
}
Console.WriteLine($"Сумма цифр числа {Nex} равна {Result}");