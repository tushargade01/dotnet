using System;

namespace HelloWorld {
    class Program {
        public static void Main(string[] args) {
            
            for(int i = 0; i <= 3; i++){
                Console.WriteLine("Main: "+i);
                
                for(int j = 0; j<4; j++){
                    Console.WriteLine("sub: "+j);
                }
            }
            
        }
    }
}