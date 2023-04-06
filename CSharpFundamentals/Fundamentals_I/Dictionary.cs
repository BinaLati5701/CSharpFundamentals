using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Fundamentals_I
{
    public class Dictionary
    {
        public void PrintDictionary()
        {
            Dictionary<string, string> profile = new Dictionary<string, string>();
            //Almost all the methods that exists with Lists are the same with Dictionaries
            profile.Add("Name", "Speros");
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            Console.WriteLine("Instructor Profile");
            Console.WriteLine("Name - " + profile["Name"]);
            Console.WriteLine("From - " + profile["Location"]);
            Console.WriteLine("Favorite Language - " + profile["Language"]);

            foreach (KeyValuePair<string, string> entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

            //The var keyword takes the place of a type in type-inference
            foreach (var entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }

        /// <summary>
        /// Create a dictionary that will store both string keys as well as string values
        ///Add key/value pairs to this dictionary where:
        ///Each key is a name from your names array
        ///Each value is a randomly selected flavor from your flavors list
        ///Loop through the dictionary and print out each user's name and their associated ice cream flavor
        /// </summary>
        public void userInfoDictionary()
        {
            Dictionary<string, string> userInfo = new Dictionary<string, string>();

            userInfo.Add("Tim", "Vanilla");
            userInfo.Add("Martin", "Chocolate");
            userInfo.Add("Nikki", "Mint");
            userInfo.Add("Sara", "Caramel");

            foreach(KeyValuePair<string, string> entry in userInfo)
            {
                Console.Write(entry.Key + " - " + entry.Value);
            } 

        }
    }
}
