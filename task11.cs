 int a = 0,s=999999999;
        a=Convert.ToInt32(Console.ReadLine());
        int[] sm =new int[a];
        for (int i = 0; i < a; i++){
            sm[i]=Convert.ToInt32(Console.ReadLine());
        }
        for (int j = 0; j < a; j++)
        {
            if(sm[j]<s){
                s=sm[j];
              
                        
            }
        }
        System.Console.WriteLine(s); 