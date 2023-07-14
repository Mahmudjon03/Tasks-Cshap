internal class task7
{
    private static void Main(string[] args)
    {
         int a = 0,b=0;
        a=Convert.ToInt32(Console.ReadLine());
        int[] sm =new int[a];
        for (int i = 0; i < a; i++){
            sm[i]=Convert.ToInt32(Console.ReadLine());
        }
        for (int j = 1; j < a-1; j++)
        {
            if(sm[j-1]<sm[j]&&sm[j]>sm[j+1]){
                        b++;
            }
        }
        System.Console.WriteLine(b); 
    }
}