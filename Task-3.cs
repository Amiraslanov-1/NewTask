using System;

namespace Task
{
    class Task3
    {
        static void Main(string[] args)
        {
        int [] array = {10,20,25,30,35,45,46};
        Console.WriteLine(BinarySearch (array ,46));
        }
       
        static bool BinarySearch (int[] array , int search){

        int low=0;
        int high=array.Length-1;

         while (low <=high) 
   {
          int middle = (low + high) / 2;
                 if (search == array[middle]) {
                      
                       Console.WriteLine(middle);
                       return true;
                 } 
      
                else if (search < array[middle]) {

                        high = middle - 1;
                 }  
      
                else {
                        low = middle + 1;
                }
   }
    
   return false ;
       

      
      }
}
}


