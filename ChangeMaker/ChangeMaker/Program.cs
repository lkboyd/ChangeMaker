using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
           ChangeAmount(4.19m);
           ChangeAmount(3.18m);
           ChangeAmount(.99m);
           ChangeAmount(12.93m);

           Console.ReadKey();

                    
           

        }

        public static Change ChangeAmount(decimal amount) 
        {
            //this is our object that will hold the data of how many coins of each type to return
                       
            Change amountAsChange = new Change();
            
            //declaring my variables at 0
            amountAsChange.Quarters = 0;
            amountAsChange.Dimes = 0;
            amountAsChange.Nickles = 0;
            amountAsChange.Pennies = 0;

            //Defining the amount in the console before I mess with it all.  
            Console.WriteLine("Total amount $ " + amount);


            //start my while loop by taking out a quarter at at time and adding it to my amountAsChange above
            while (amount >= .25m)
            {
                amount = amount - .25m;
                amountAsChange.Quarters++;
            }

            //dimes
            while (amount >= .10m)
            {
                amount = amount - .10m;
                amountAsChange.Dimes++;
            }

            //nickels
            while (amount >= .05m)
            {
                amount = amount - .05m;
                amountAsChange.Nickles++;
            }
            
            //pennies
            while (amount >= .01m)
            {
                amount = amount - .01m;
                amountAsChange.Pennies++;
            }

            //printing out to the console 
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);
            Console.WriteLine("Dimes: " + amountAsChange.Dimes);
            Console.WriteLine("Nickels: " + amountAsChange.Nickles);
            Console.WriteLine("Pennies: " + amountAsChange.Pennies);
            

            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;

            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }
}
