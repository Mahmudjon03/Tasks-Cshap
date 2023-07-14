mmint a = 0,n=0,s=0;
        a=Convert.ToInt32(Console.ReadLine());
        
        int[] mc =new int[a];
        for (int i = 0; i < a; i++){
            mc[i]=Convert.ToInt32(Console.ReadLine());
        }
       
      n=Convert.ToInt32(Console.ReadLine());
        for (int j = 0; j < a; j++)
        {
            if(n==mc[j]){
               s++;
            }
        }
        System.Console.WriteLine(s);