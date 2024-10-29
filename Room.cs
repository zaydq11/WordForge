using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordForge
{
    public class Room // Defines the Room class, which represents a room in the game.
    {
        public string Name { get; set; } // The name of the room (e.g., "Entrance Hall").
        public string Description { get; set; } // A brief description of the room.
        public Dictionary<string, Room> Exits { get; set; } // A dictionary that holds the exits for the room (e.g., "north" leads to another Room).

        // Constructor that initializes the room with a name and description.
        public Room(string name, string description)
        {
            Name = name; // Set the room's name.
            Description = description; // Set the room's description.
            Exits = new Dictionary<string, Room>(); // Initialize the exits dictionary (no exits yet).
        }

        // Prints the room's name, description, and available exits to the console.
        public void Describe()
        {
            Console.WriteLine(Name); // Print the name of the room.
            Console.WriteLine(Description); // Print the description of the room.
            Console.WriteLine("Exits: " + string.Join(", ", Exits.Keys)); // List available exits (e.g., "north, south").
        }

        // Adds an exit to the room. Takes a direction (e.g., "north") and the room it leads to.
        public void SetExit(string direction, Room room)
        {
            Exits[direction] = room; // Add the direction and associated room to the Exits dictionary.
        }
    }
}
