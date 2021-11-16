using System;
using System.IO;
namespace FruitAndVeggies
{
    class Program
    {
        static void Main(string[] args)
        {
            //read data from fruit.txt
            string fruitpath = @"C:\Users\opilane\Samples\fruit.txt";
            string[] veggiedata = File.ReadAllLines(fruitpath);

            //read data from veggie.txt
            string veggiepath = @"C:\Users\opilane\Samples\veggie.txt";
            string[] fruitdata = File.ReadAllLines(veggiepath);

            File.WriteAllLines(fruitpath, fruitdata);
            File.WriteAllLines(veggiepath, veggiedata);
        }
    }
}
