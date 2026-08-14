using System;

namespace HelloWorld {
    class program {
        public static void Main(string[] args){
            Console.WriteLine("Enter Usernamae: ");
            string username = Console.ReadLine();
            
            Console.WriteLine("Dear "+username+" you successfully logined....");

            //for int and other data types

            Console.WriteLine("Enter Your Age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dear"+username+", your age is "+userAge+".");
        }
    }
}