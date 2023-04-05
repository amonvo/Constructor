using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Car
    {
        public string modelName;
        public int year;

        public Car(string modelName, int year) 
        {
            this.modelName = modelName;
            this.year = year;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 1990);
            Console.WriteLine(car);
            Console.ReadKey();
        }
    }
}
