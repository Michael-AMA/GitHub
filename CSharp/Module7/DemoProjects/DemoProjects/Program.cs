using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateArrayList();
            CreateHashtable();
            //CreateGenericList();
            //CreateGenericDictionary();
        }

        #region Collections

        static void CreateArrayList()
        {
            // Create a new ArrayList collection.
            ArrayList beverages = new ArrayList();


            // Create some items to add to the collection.
            Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Robusta", "Indonesia");

            // Items are impiticty cast to the object type when you add them.
            beverages.Add(coffee1);
            beverages.Add(coffee2);
            beverages.Add(coffee3);


            // Retrieve items from the collection.
            // Items must be explicityly cast back to their original type.
            Coffee firstCoffee = (Coffee)beverages[0];
            Coffee secondCoffee = (Coffee)beverages[1];

            OutputCollection(beverages);
        }

        static void OutputCollection(ArrayList beverages)
        {
            // Iterating Over a List Collection
            foreach (Coffee coffee in beverages)
            {
                Console.WriteLine("Bean type: {0}", coffee.Bean);
                Console.WriteLine("Country of origin: {0}", coffee.CountryOfOrigin);
                Console.WriteLine("Strength (1-5): {0}", coffee.Strength);
            }
        }

        static void CreateHashtable()
        {
            // Create a new Hashtable collection.
            Hashtable ingredients = new Hashtable();


            // Add some key/value pairs to the collection
            ingredients.Add("Cafe au Lait", "Coffee, Milk");
            ingredients.Add("Cafe Mocha", "Coffee, Milk, Chocolate");
            ingredients.Add("Cappuccino", "Coffee, Milk, Foam");
            ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            ingredients.Add("Macchiato", "Coffee, Milk, Foam");


            OutPutHashtable(ingredients);
        }

        static void OutPutHashtable(Hashtable hTable)
        {
            // Check whether a key exists.
            if(hTable.ContainsKey("Cofe Mocha"))
            {
                // Retrieve the value associated with a key.
                Console.WriteLine("The ingredients of a Cafe Mocha are: {0}", hTable["Cafe Mocha"]);
            }
            

            // Iterating Over a Dictionary Collection
            foreach(string key in hTable.Keys)
            {
                // For each key in turn, retrieve the value associated with the 
                Console.WriteLine("The ingredients of a {0} are {1}", key, hTable[key]);
            }
        }

        #endregion

        #region GenericCollections

        #endregion


    }
}
