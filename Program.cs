using System;
using Abstraction.Interface;

namespace Abstractionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnime ianime;


            ianime = new kimetsu no yaiba();
            ianime.Cartoon();

            Console.WriteLine();
            ianime = new one punch man();
            ianime.Cartoon();
            Console.ReadKey();
        }
    }
}
