using System;

namespace HelloWorld {
    class program {
        public static void Main(string[] args) {
            //string is object
            //that contain properties and methods
            
            string str = "nice to meet you, Tushar!";
            
            Console.WriteLine(str);
            
            //length is a property
            Console.WriteLine("The length of string is: "+str.Length);
            
            //ToUpper() is method of string
            Console.WriteLine("UpperCase: "+ str.ToUpper());
            Console.WriteLine("LowerCase: "+ str.ToLower());
            
            
            /*string Concatination*/
            string firstName = "Tushar ";
            string lastName = "Gade";
            
            Console.WriteLine(firstName+lastName);
            
            //we can also use Concat() for Concatination
            Console.WriteLine(string.Concat(firstName,lastName));
            
            /*String Interpolation*/
            
            Console.WriteLine($"My name is {firstName+lastName}");
            
            
            /* String Access */
            string fullName = "Tushar Gade";
            
            
            //get index of g
            Console.WriteLine(fullName.IndexOf('G'));
            
            //give string which start from g
            /*
                int count = fullName.IndexOf('g');
                print(fullName.Substring(count));
            */
            Console.WriteLine(fullName.Substring(fullName.IndexOf('G')));
            
            
            /* Special Characters */
            //backslash
            Console.WriteLine("my name is \"tushar\" .to add backslash we can do \\");
            
        }
    }
}