
internal class task8
{
    private static void Main(string[] args)
    {
       int a = 0, b = 0;
        a = Convert.ToInt32(Console.ReadLine()); 
        int[] sf = new int[a];
        for (int i = 0; i < a; i++)
        {
            sf[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a-i-1; j++)
            {
                if (sf[j] > sf[j + 1])
                {
                    b = sf[j];
                    sf[j] = sf[j + 1];
                    sf[j + 1] = b;
                }
            }
        }
        for (int i = a; i >0; i--)
        {
            Console.WriteLine(sf[i]);
        }
    }
}