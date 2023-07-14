int a = 0,n=0;
        a=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("mc");
        int[] mc =new int[a];
        for (int i = 0; i < a; i++){
            mc[i]=Convert.ToInt32(Console.ReadLine());
        }
       bool bl=false;
       System.Console.Write("n=");
      
      
   n=Convert.ToInt32(Console.ReadLine());
        for (int j = 0; j < a; j++)
        {
            if(n==mc[j]){
                bl=true;
            }
        }
        if(bl==true)
        System.Console.WriteLine("yes");
        else
         System.Console.WriteLine("no");