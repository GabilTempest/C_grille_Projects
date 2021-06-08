using System;
class Program{
  static void Main(string[] ards) {
    
  double a, b, h, x=0, y, d, S;
   int k;
   
 Console.WriteLine("a:");
 a = double.Parse(Console.ReadLine());
 
 Console.WriteLine("b:");
 b = double.Parse(Console.ReadLine());
 
  Console.WriteLine("h:");
  h = double.Parse(Console.ReadLine());
 
 Console.WriteLine("d:");
  d = double.Parse(Console.ReadLine());
 
    for(x=a; x<=(b+h); x+=h){
       S=0.0; y=0.0;k=1;
       
       do{
           y=1/Math.Pow(k,2)*Math.Sin(x/Math.Pow(2,k));
           if(Math.Abs(y)>d)
           {
            
               S+=y;
              
               k++;
              
           }  
       } while(Math.Abs(y)>d);
      
        Console.WriteLine("x =" +" "+ x );
        Console.WriteLine("S =" +" "+ S );
        Console.WriteLine("k =" +" "+ k );
   }
     


  }
    
}