using System;

namespace HelloWorld{
    internal class Program1 {
        private string name = "hello";
        
        public string Name{
            get{
                return name;
            } 
            set {
                name = value;
            }
        }
        
        public void setData(){
            Console.WriteLine(name);
        }
    }
    class Program {

        public static void Main(string[] args){
            Program1 p1 = new Program1();
            p1.Name = "tushar";
            Console.WriteLine(p1.Name);
            p1.setData();
        }
    }
}
