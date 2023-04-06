using System;
using System.Collections.Generic;
using System.Text;




namespace CSharpFundamentals.Fundamentals_I
{
    public class List
    {
        public void PrintList()
        {
            //Initializing an empty list of Motorcycle Manufacturers
            List<string> bikes = new List<string>();
            //Use the Add function in a similar fashion to push
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");
            //Accessing a generic list value is the same as you would an array
            Console.WriteLine(bikes[2]); //Prints "BMW"
            Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

            //Using our array of motorcycle manufacturers from before
            //we can easily loop through the list of them with a C-style for loop
            //this time, however, Count is the attribute for a number of items.
            Console.WriteLine("The current manufacturers we have seen are:");
            for (var idx = 0; idx < bikes.Count; idx++)
            {
                Console.WriteLine("-" + bikes[idx]);
            }
            // Insert a new item between a specific index
            bikes.Insert(2, "Yamaha");
            //Removal from Generic List
            //Remove is a lot like Javascript array pop, but searches for a specified value
            //In this case we are removing all manufacturers located in Japan
            bikes.Remove("Suzuki");
            bikes.Remove("Yamaha");
            bikes.RemoveAt(0); //RemoveAt has no return value however
                               //The updated list can then be iterated through using a foreach loop
            Console.WriteLine("List of Non-Japanese Manufacturers:");
            foreach (string manu in bikes)
            {
                Console.WriteLine("-" + manu);
            }
        }

        /// <summary>
        /// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
        /// Output the length of this list after building it
       ///Output the third flavor in the list, then remove this value
        ///Output the new length of the list(It should just be one fewer!)
        /// </summary>
        public  void listOfFlavors()
        {
            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("Vanilla");
            iceCreamFlavors.Add("Chocolate");
            iceCreamFlavors.Add("Strawberry");
            iceCreamFlavors.Add("Mint");
            iceCreamFlavors.Add("Caramel");

            Console.WriteLine(iceCreamFlavors.Count);
            Console.WriteLine(iceCreamFlavors[2]);
            iceCreamFlavors.Remove("Strawberry");

            Console.WriteLine($"New length of the list is  {iceCreamFlavors.Count} ");


        }
    }
}
