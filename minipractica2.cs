<<<<<<< HEAD:main.cs
using System;  
  public class FibonacciExample  
   {  
     public static void Main(string[] args)  
      {  
         int n1=0,n2=1,n3,i,number;    
         Console.Write("Enter the number of elements: ")
         number = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" "); 
         for(i=2;i<number;++i)  
         {
          n3=n1+n2;    
          Console.Write(n3+" ")    
          n1=n2;    
          n2=n3;    
         }    
      }  
=======
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Hello World");
    int a = 4, b = 3;
    int c = a + b;
    Console.WriteLine(c);
    
       ////////////////////
  }
}
>>>>>>> abd31d2ddf53354d906bdbbc946b1144588c70d4:minipractica2.cs
