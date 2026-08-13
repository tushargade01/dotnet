using System;

namespace HelloWorld {
    class variables {
        public static void variable() {
            int num;
            num = 15;
            Console.WriteLine(num);
            
            int MyNum = 23;
            float MyFlaot = 34.5f;
            double myPercentage = 70.33D;
            string MyLine = "this is me tushar..";
            char firstCar = 'T';
            bool gender = true;
            
            Console.WriteLine(MyNum);
            Console.WriteLine(MyFlaot);
            Console.WriteLine(myPercentage);
            Console.WriteLine(MyLine);
            Console.WriteLine(firstCar);
            Console.WriteLine(gender);
            
        }
        
        public static void constant () {
            const int myAge = 23;
            Console.WriteLine(myAge);
            //myAge = 24; value not change 
        }
        
        public static void DisplayVariable(){
            string firstName = "tushar ";
            string lastName = "gade";
            string fullName = firstName+lastName;
            Console.WriteLine("Hey, "+fullName+"!");
        }
        
        public static void multipleVariable () {
            int x=2,y=3,z=5;
            int p,q,r;
            p=q=r=10;
            
            Console.WriteLine(x+" "+y+" "+z+" "+p+" "+q+" "+r+" ");
        } 
    }
}