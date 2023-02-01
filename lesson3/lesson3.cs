internal class Program
{
    private static void Main(string[] args)
    {
        // программа выводит таблицу умножения 
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i * j);
                Console.Write("\t");
            }
            Console.WriteLine();
        }
    }
}