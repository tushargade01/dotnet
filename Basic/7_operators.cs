using System;

namespace HelloWorld {
    class program {
        public static void Main(string[] args){
            
            int a = 10;
            int b = 5;
            
            //arithmetic
            
            Console.WriteLine("a + b: "+(a+b));
            Console.WriteLine("a - b: "+(a-b));
            Console.WriteLine("a * b: "+(a*b));
            Console.WriteLine("a / b: "+(a/b));
            Console.WriteLine("a % b: "+(a%b));
            
            
            //asinment
            
            Console.WriteLine(a+=5);
            Console.WriteLine((float) b/2);
            
            //comparasion
            
            Console.WriteLine(a>b);
            Console.WriteLine(a<b);
            Console.WriteLine(a>=b);
            Console.WriteLine(a==b);
            Console.WriteLine(a!=b);
            
            //logical
            Console.WriteLine(a>5 && b<=5);
            Console.WriteLine(a<5 || b>5);
            // ! oprator to reverse the condition
        }
    }
}