using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RomanLib;

namespace ChiffreRomain
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Write("Tapez un chiffre romain : ");
                var line = Console.ReadLine();
                try {
                    Console.WriteLine("Valeur : {0}", RomanConverter.Convert(line));
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
