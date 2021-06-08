using System;
class Program{
  static void Main(string[] ards) {
    
 double a, b, x=0, y, h ;
 Console.WriteLine("a:");
 a = double.Parse(Console.ReadLine());
 
 Console.WriteLine("b:");
 b = double.Parse(Console.ReadLine());
 
  Console.WriteLine("h:");
  h = double.Parse(Console.ReadLine());
 
   while(x <= b){
    if(x < 0.2){
        y= Math.Log10 (3*x + 1)/Math.Log10(5) ;
        x+=h;
        
    }else if(0.2<=x && x<0.4){
        
        y=Math.Pow(x,Math.Cos(x));
        x+=h;
    }else {
        y=1/Math.Sin(Math.Log(x));
        x+=h;
    }
      Console.WriteLine("x =" +" "+ x );
      Console.WriteLine("y =" +" "+ y );
}

  }
    
}