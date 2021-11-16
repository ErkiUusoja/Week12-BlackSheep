using System;
using System.IO;
namespace ChuckNorrisJokes
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filepath = @"C:\Users\opilane\Samples\chuck.txt";
            //string[] jokesAboutChuck = File.ReadAllLines(filepath);

            //Random rnd = new Random();
            //int randomIndex = rnd.Next(0, jokesAboutChuck.Length);
            //Console.WriteLine(jokesAboutChuck[randomIndex]);
            Console.WriteLine(GetRandomJoke());
        }

        public static string GetRandomJoke()
        {
            string filepath = @"C:\Users\opilane\Samples\chuck.txt";
            string[] jokesAboutChuck = File.ReadAllLines(filepath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, jokesAboutChuck.Length);

            return jokesAboutChuck[randomIndex];
        }

    }
}
