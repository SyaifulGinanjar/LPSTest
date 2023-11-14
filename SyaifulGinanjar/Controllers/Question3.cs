using System;
using SyaifulGinanjar.Controllers;

namespace SyaifulGinanjar.Controllers
{
    /***
     * add access modified to private class Laptop in class Question3
     * then declare the Laptop class in the same class
    ***/
    public class Question3
    {
        public static void Main()
        {
            var laptop = new Laptop("macOs");
            Console.WriteLine(laptop.Os); // Laptop os: macOs
        }

        private class Laptop
        {
            public string Os { get; set; } // can be modified public Laptop(string os)
            public Laptop(string os)
            {
                Os = os;
            }
        }
    }
}