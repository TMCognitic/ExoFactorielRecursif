using System;

namespace ExoFactorielRecursif
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte value; //Factoriel maximum calculable est 27 => valeur maximale du sbyte est 127

            do
            {
                Console.Clear();
                Console.Write("Veuillez entrer un nombre > 1 : ");
            } while (!sbyte.TryParse(Console.ReadLine(), out value) || value < 1);

            Console.WriteLine(Factoriel(value));
        }

        static decimal Factoriel(decimal x)
        {
            if(x < 1) 
                return -1;

            return (x == 1) ? 1 : x * Factoriel(x - 1);
        }
    }
}

/*
 * 5! => 5 * 4 * 3 * 2 * 1
 * 4! => 4 * 3 * 2 * 1
 * 
 * 5! => 5 * 4!
 * 4! => 4 * 3!
 * 1! = 1
 */
