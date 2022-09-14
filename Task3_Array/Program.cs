// Задать массив из N = 8 элементов и вывести его на экран

Console.Clear();
Console.WriteLine ("Введите число элементов массива");
int N = Convert.ToInt32(Console.ReadLine());

int [] Array = new int [N];
Console.WriteLine("Массив из N элементов:");
for (int i = 0; i < N; i++)
{
    Array[i] = new Random().Next(1, 100);
    Console.Write($"{Array[i]}    ");
}

