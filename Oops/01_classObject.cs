using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	    
	   string color;
	   int MaxSpeed;
	   
	   public void FullThrottle() {
	       Console.WriteLine("The car is going fast as it can!");
	   }
	    
		public static void Main(string[] args)
		{
		    Program p = new Program();
		    p.color = "red";
		    p.MaxSpeed = 200;
		    
		    Console.WriteLine(p.color);
		    Console.WriteLine(p.MaxSpeed);
		    p.FullThrottle();
// 			NewClass1 nw = new NewClass1();
// 			Console.WriteLine(nw.SayHelloFromNewClass());
		}
	}
}