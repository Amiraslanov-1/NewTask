using System;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Daxil Edeceyiniz Ededlerin Sayi :");
         int[] arr = new int [Convert.ToInt32(Console.ReadLine())]  ;
          Number(arr);
        }
        static void Number ( int [] arr,int total=0 )
        {

            Console.WriteLine("Ededleri Daxil Edin : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Eded [" + (i + 1) + "] : ");
                arr[i] = int.Parse(Console.ReadLine());}

            for (int i = 0; i < arr.Length; i++){
			
             total=total+arr[i];
					
			 }
          Console.WriteLine($" Ededlerin Cemi : {total}");
       
        }

        }

       

      
}




