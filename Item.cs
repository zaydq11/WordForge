using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordForge
{
    public class Item // Defines the Item class, representing an item the player can interact with.
    {
        public string Name { get; set; } // The name of the item (e.g., "Key").
        public string Description { get; set; } // A brief description of the item.

        // Constructor that initializes the item with a name and description.
        public Item(string name, string description)
        {
            Name = name; // Set the item's name.
            Description = description; // Set the item's description.
        }

        // Prints the item's name and description to the console.
        public void Describe()
        {
            Console.WriteLine($"{Name}: {Description}"); // Print the item’s name and description.
        }
    }
}
