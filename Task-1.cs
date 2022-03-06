using System;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Cumleni daxil edin :");
           string Sentence=Console.ReadLine();
           Console.WriteLine("Axtardiginiz herfi  daxil edin :");
           char letter=Convert.ToChar(Console.ReadLine());
           Word(Sentence,letter); 
        }
        static void Word (string Sentence,char letter,int count=0){
        
        for (int j = 0; j<Sentence.Length ; j ++)
        {
           if(Sentence[j] == letter) 
           {
              count++;
           }
  
        }
       Console.WriteLine($"Herflerin sayi : {count}");
       return;
       

      
}
}
}


