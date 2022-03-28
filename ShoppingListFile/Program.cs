using System;
using System.IO;

namespace ShoppingListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Matu\samples";
            Console.WriteLine("Sisestage kausta nimi 'ShoppingList:'");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sisestage faili nimi 'MyShoppingList.txt'");
            string fileName = Console.ReadLine();

            


            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and file exists.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
                Console.WriteLine("Teie kaust ning fail on loodud. Kena päeva!");
            }

        }
    }
}
