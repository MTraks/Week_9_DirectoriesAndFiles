using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MysShoppingListAddNewElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Matu\samples\ShoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you loke to add an item to your shoppinglist?");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item to shoppinglist");
                    string userItem = Console.ReadLine();
                    myShoppingList.Add(userItem);

                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Now you can go to the store");
                }



            }

            Console.Clear();

            foreach (string item in myShoppingList)
            {
                Console.WriteLine($"Your Shoppinglist item: {item}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);


        }
    }
}
