using System;
using System.Collections.Generic;

namespace MyFirstDotnet
{
    public class Program
    {
    private const bool V = false;

    static void Main(string[] args)
        {
            /******************* STRINGS *******************/
            string place = "Coding Dojo";
            Console.WriteLine($"Hello {place}");
            Console.WriteLine("Hi, {0}. Welcome to {1}. You're goin to {2}!", "Parker", "Csharp", "fail");
            string name = "Aleks";

            /******************* INTS/FLOATS *******************/
            int age = 28;
            float radius = 1.32f;
            double height = 5.685496;

            /******************* BOOLS *******************/
            bool isThirty = false;
            Console.WriteLine($"{age}, {height}, {radius}, {isThirty}");

            /******************* CONDITIONALS *******************/
            int numRings = 5;
            if (numRings >= 5)
            {
                Console.WriteLine("You are welcome to the party");
            }
            else if (numRings > 2)
            {
                Console.WriteLine($"Decent... but {numRings} rings aren't enough");
            }
            else
            {
                Console.WriteLine("Go win some more rings");
            }

            // COMPARISON OPERATORS
            //  <
            //  >
            //  <=
            //  >=
            //  ==
            //  !=

            // LOGIC OPERATORS
            //  && -> are two conditions BOTH true?
            //  || are either conditions true?
            //  ! true becomes false, false becomes true


            string name2 = "Kobe";
            if (numRings >= 5 && name2 == "Kobe")
            {
                Console.WriteLine($"Welcome to the party {name}, congratulations on your {numRings} championships!");
            }


            int numOfAllStarAppearances = 17;
            if (numRings >= 5 || numOfAllStarAppearances > 3)
            {
                Console.WriteLine("Welcome, you are truly a legend");
            }

            bool crazy = false;
            if (!crazy)
            {
                Console.WriteLine("Let's party!");
            }

            /******************* LOOPS *******************/
            // for loops
            // loop from 1 to 5 including 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("for loop 1 index is currently at " + i);
            }
            // loop from 1 to 5 excluding 5
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("for loop 2 index is currently at " + i);
            }

            // for loop vs while loop
            for (int i = 1; i < 6; i = i + 1)
            {
                Console.WriteLine("for loop vs while loop " + i);
            }
            int k = 1;
            while (k < 6)
            {
                Console.WriteLine("This is the while loop " + k);
                k = k + 1;
            }

            Random rand = new Random();
            Console.WriteLine("random number: " + rand.Next());
            for (int val = 0; val < 10; val++) 
            {
                Console.WriteLine("random number between 2 and 10: " + rand.Next(2, 10));
            }

            /******************* ARRAYS *******************/
            // Int arrays
            int[] numArray = new int[5];
            Console.WriteLine(numArray); //prints object
            for (int x = 0; x < numArray.Length; x++)
            {
                Console.WriteLine($"Value at position {x}: {numArray[x]}");
            }

            int[] numArray2 = {1,2,3,4,6};
            Console.WriteLine(numArray2); //prints object
            for (int x = 0; x < numArray2.Length; x++)
            {
                Console.WriteLine($"Value at position {x}: {numArray2[x]}");
            }

            numArray2 = new int[] {6,2,0,5,6};
            for (int x = 0; x < numArray2.Length; x++)
            {
                Console.WriteLine($"Value at position {x}: {numArray2[x]}");
            }

            // String arrays
            string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
            // The 'Length' property tells us how many values are in the Array (4 in our example here). 
            // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
            for (int idx = 0; idx < myCars.Length; idx++)
            {
                Console.WriteLine($"I own a {myCars[idx]}");
            }

            string[] myCars2 = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
            foreach (string car in myCars2)
            {
                // We no longer need the index, because variable 'car' already represents each indexed value
                Console.WriteLine($"I own a {car}");
            }

            /******************* LISTS *******************/
            List<string> bikes = new List<string>();

            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley");
            bikes.Add("Suzuki");

            Console.WriteLine(bikes[0]); // prints first position in list
            Console.WriteLine($"We currently know of {bikes.Count} motercycle manufacturers.");

            Console.WriteLine("The current manufaturers we have seen are:");
            for (var x = 0; x < bikes.Count; x++)
            {
                Console.WriteLine("-" + bikes[x]);
            }

            bikes.Insert(2, "Yamaha");
            Console.WriteLine("The current manufaturers we have seen are:");
            for (var x = 0; x < bikes.Count; x++)
            {
                Console.WriteLine("-" + bikes[x]);
            }

            bikes.Remove("Suzuki");
            bikes.Remove("Yamaha");

            Console.WriteLine("The current manufaturers we have seen are:");
            for (var x = 0; x < bikes.Count; x++)
            {
                Console.WriteLine("-" + bikes[x]);
            }

            bikes.RemoveAt(0); // Removes At specified index of list

            Console.WriteLine("List of Non-Japanese Manufacturers:");
            foreach (string manu in bikes)
            {
                Console.WriteLine("-" + manu);
            }

            /******************* DICTS *******************/
            Dictionary<string,string> profile = new Dictionary<string,string>();
            
            Console.WriteLine(profile); // prints entire object

            profile.Add("Name", "Speros"); // adds KeyValuePair 
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            Console.WriteLine("Instructor Profile");
            Console.WriteLine("Name - " + profile["Name"]); // prints specified keys value
            Console.WriteLine("From - " + profile["Location"]);
            Console.WriteLine("Favorite Language - " + profile["Language"]);

            // Iterating through dicts
            Console.WriteLine("Instructor Profile");
            foreach (KeyValuePair<string,string> entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }


            foreach (var entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            
            /******************* FUNCTIONS *******************/

            SayHello(); //invoke the function within main program function

            SayHello("Parker"); // function takes in a string parameter

            // We can call it without providing any arguments and the default value will be used...
            SayHelloTwo();
            // ...or we can call it with an argument and that argument's value will be used
            SayHelloTwo("Yoda");

            string greeting;
            greeting = SayHelloThree();
            Console.WriteLine(greeting);
            
        }
        /******************* FUNCTIONS *******************/
        public static void SayHello()
        // the function must be placed outside of the Main function, but still inside the Program class
        // C# does not support embedding of functions, so they must be seperate
        {
            Console.WriteLine("Hello how are you doing today?");
        }

        public static void SayHello(string firstName) 
        // You can name your function the same if they are taking in different parameters
        // function takes in a string
        {
            Console.WriteLine($"Hello, {firstName}, how are you doing today?");
            // prints string and passes in string set to varible firstname in parameters
        }

        public static void SayHelloTwo(string firstName = "buddy")
        // Set the parameters equal to a default value --> or pass in another string that overides default
        {
            Console.WriteLine($"Hey {firstName}");
        }

        public static string SayHelloThree(string firstName = "buddy")
        // This function specifies string as the return type
        {
            return $"Hey {firstName}";
        }
    }
}
