using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoe
{
    class MenuItem
    {
        public static Random Randomizer = new Random();                 // Random-klassvariabel. We set this field to static, so that all of the MenuItems share the same single Random Instance. Otherwise the menuitems would be the same on the menu. 

        public string[] Proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };                                     // Klass-array.
        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };       // Klass-array.
        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };                                                 // Klass-array.

        public string Description = "";                         // This declared field will later contain the full string of a dish displayed on the menu. 
        public string Price;

        /// <summary>
        /// This method generates a random Protein, Condiment and Bread and stores the result in Description. It also generates a random price for the dish. 
        /// </summary>
        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];                      // We want to store a random index between 0-5 from the Proteins-array, inside "randomProtein". 
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];                // We want to store a random index between 0-5 from the Condiments-array, inside "randomCondiment". 
            string randomBread = Breads[Randomizer.Next(Breads.Length)];                            // We want to store a random index between 0-4 from the Breads-array, inside "randomBread". 

            Description = randomProtein + " with " + randomCondiment + " on " + randomBread;        // We concatinate a string containing the full dish, and stores the result in the field "Description".

            decimal bucks = Randomizer.Next(2, 5);                                                  // We want to store a random number between 2-4 inside the variable "bucks". 
            decimal cents = Randomizer.Next(1, 98);                                                 // We want to store a random number between 1-98 inside the variable "cents". 
            decimal price = bucks + (cents * .01M);                                                 // First the cents get calculated, then we add the cents to the bucks. The result gets stored in the variable "price". 
            Price = price.ToString("c");                                                            // We want to convert the decimal-variable to string. We want the price to be displayed as the regional currency (kr). We want to store the result in the field named "Price".  

        }
    }
}
