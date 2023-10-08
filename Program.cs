using System;
using System.Security.Cryptography.X509Certificates;

namespace learningdotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dogobj = new Dog();
            
            Console.WriteLine(dogobj.name);
        }
    }
}
