using System;

namespace HelloWorld {
    class program {
        public static void Main(string[] args){
            int num = 34;
            double num1 = num;
            //implicit Casting
            Console.WriteLine(num);
            Console.WriteLine(num1);
            
            //Explicit Casting
            
            float percantage = 70.33F;
            int roundPer = (int) percantage;
            
            Console.WriteLine(percantage);
            Console.WriteLine(roundPer);
            
            //inbuild method to convert
            int myInt = 33;
            double myDouble = 70.23;
            bool myBool = true;
            
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToInt32(myDouble));
        }
    }
}