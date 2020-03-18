using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
             string personName = ""; 

            Console.WriteLine("Please enter your name: ");
            
            personName = Console.ReadLine(); 

            Console.WriteLine("Hello" + personName);
          
        }
    }
}
