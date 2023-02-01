// программа считает наибольшую сумму нескольких подряд элементов массива
using System.Diagnostics;
int InputNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int size = InputNumber("введите количество элементов массива");
int seq = InputNumber("введите количество элементов для суммирования");
int[] array = Enumerable.Range(1, size)
                        .Select(item=>Random.Shared.Next(10))
                        .ToArray();
//Console.WriteLine($"[{string.Join(", ", array)}]");
Stopwatch sw = new();
sw.Start();
int max = 0;
for (int j = 0; j<max; j++) max+=array[j];
int t = max;
for (int i=1; i<array.Length-seq; i++)
{
    t = t - array[i-1]+array[i+(seq-1)];
    if (t>max) max = t;
}
sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine(max);