// Сортировка массива пузырьковым методом"
Console.WriteLine("введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] massiv = new int[n];
for(int i = 0; i<n; i++) 
{
    Console.WriteLine("введите элементы массива");
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i=0; i<n; i++)
{
    for (int j=0; j<n-1; j++)
    {
        if (massiv[j]>massiv[j+1])
        {
            int temp = massiv[j];
            massiv[j] = massiv[j+1];
            massiv[j+1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", massiv) + "]");
}