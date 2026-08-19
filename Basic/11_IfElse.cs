using System;

namespace HelloWorld {
    class Program {
        public static void Main(string[] args) {
            
            //if Condition
            
            int x = 15;
            int y = 15;
            
            if(x>=y){
                Console.WriteLine("x is greater than or equal to y.");
            }
            
            //if else
            
            if (x <= 6) {
                Console.WriteLine("Good Afternoon.");
            } else {
                Console.WriteLine("Good Evening.");
            }
            
            //else if
            if(y < 5) {
                Console.WriteLine("Good Morning.");
            } else if (y >= 11) {
                Console.WriteLine ("Good afternoon.");
            } else {
                Console.WriteLine("good evening.");
            }
            
            //ternary operator
            string isAdult = (y >= 18) ? "yes, he is adult." : "no, he't Adult." ;
            
            Console.WriteLine(isAdult);
            Console.WriteLine((y >= 18) ? "yes, he is adult." : "no, he't Adult.");
        }
    }
}