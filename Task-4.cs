using System;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)

        
        { 
           Console.WriteLine("Cevrenin Sahesinin Hesablanmasi");
           Console.WriteLine($"Pi={3}");
           Console.WriteLine("Radisu Daxil Edin :");
           int radius=Convert.ToInt32(Console.ReadLine());
           CircleArea(3,radius);


           Console.WriteLine("Duzbucaqlinin Sahesinin Hesablanmasi");
           Console.WriteLine("A Terefin Daxil Edin :");
           int A=Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("B Terefin Daxil Edin :");
           int B=Convert.ToInt32(Console.ReadLine());
           SquareArea(A,B);

           Console.WriteLine("Ucbucaqlinin Daxilinə Cekilmiş Cevrenin  Sahesinin Hesablanmasi");
           Console.WriteLine("a Terefin Daxil Edin :");
           int a=Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("b Terefin Daxil Edin :");
           int b=Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("c Terefin Daxil Edin :");
           int c=Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Radius Daxil Edin :");
           int Radius=Convert.ToInt32(Console.ReadLine());
           Insidetriangle(a,b,c,Radius);

    }
    static void CircleArea (int p,int radius){
    int CircleArea;
    CircleArea=p*radius*radius;
    System.Console.WriteLine($"Ucbucagin Sahesi : {CircleArea}");
    return;
       

      
    }
    static void SquareArea (int A,int B){
    int SquareArea;
    SquareArea=A*B;
    System.Console.WriteLine($"Kvadratin Sahesi : {SquareArea}");
    return;

      
    }
    static void Insidetriangle (int a,int b,int c,int Radius){
    int P;
    int InsideAreaTriangle;
   
    P=(a+b+c)/2;
    InsideAreaTriangle=P*Radius;

    System.Console.WriteLine($"Uçbucaqlinin Daxiline Cekilmiş Cevrenin Sahesi : {InsideAreaTriangle}");
    return;
      
    
}
}
}



