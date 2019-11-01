using System;


namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("value\tSquared\tCubed");
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);


        }
    }
}
