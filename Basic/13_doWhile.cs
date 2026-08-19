using System;

namespace HelloWorld {
    class Program {
        public static void Main(string[] args) {
            
            int i = 5;
            
            while(i <= 10){
                Console.WriteLine(i++);
            }
            
            int j=5;
            
            do {
                Console.WriteLine(j--);
            } while (j>=1);
        }
    }
}