using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var ray = new int[50];
            
            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(ray);

            //Print the first number of the array
            Console.WriteLine(ray[0]);

            //Print the last number of the array            
            Console.WriteLine(ray[ray.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(ray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(ray);
            NumberPrinter(ray);
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(ray);
            NumberPrinter(ray);
            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(ray);
            NumberPrinter(ray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var listy = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(listy.Count);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(listy);

            //Print the new capacity
            Console.WriteLine(listy.Count);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var inputNumber = Console.ReadLine();
            int theNum;
            if (int.TryParse(inputNumber, out theNum))
                NumberChecker(listy, theNum);
            else
                Console.WriteLine("You did not enter a valid number");

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(listy);
            Console.WriteLine("-------------------");

            //Create a method that will remove all even numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(listy);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            listy.Sort();
            NumberPrinter(listy);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var newRay = listy.ToArray();

            //Clear the list
            listy.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 3 == 0)
                    numbers[i] = 0;
        }

        private static void OddKiller(List<int> numberList)
        {
            int i = 0;
            while(i < numberList.Count)
            {
                if (numberList[i] % 2 == 0)
                    numberList.Remove(numberList[i]);
                else
                    i++;
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
                Console.WriteLine($"{searchNumber} is in the List");
            else
                Console.WriteLine($"{searchNumber} is not in the List");
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
                numberList.Add(rng.Next(0, 51));

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rng.Next(0,51);

        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int j = array.Length - 1 - i;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
