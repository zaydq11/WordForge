using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordForge
{
    public class Player // Defines the Player class, representing the player in the game.
    {
        public Room CurrentRoom { get; set; } // The room where the player currently is.
        public List<Item> Inventory { get; set; } // The player's inventory, a list of items they are carrying.

        // Constructor that initializes the player in a starting room.
        public Player(Room startingRoom)
        {
            CurrentRoom = startingRoom; // Set the player's current room to the starting room.
            Inventory = new List<Item>(); // Initialize the inventory (player starts with no items).
        }

        // Moves the player to another room based on the direction they choose (e.g., "north").
        public void Move(string direction)
        {
            // Check if there's an exit in the given direction.
            if (CurrentRoom.Exits.ContainsKey(direction))
            {
                CurrentRoom = CurrentRoom.Exits[direction]; // Move to the room in that direction.
                Console.WriteLine("You move " + direction + "."); // Inform the player they moved.
            }
            else
            {
                Console.WriteLine("You can't go that way."); // Inform the player there's no exit in that direction.
            }
        }

        // Describes the room the player is currently in.
        public void Look()
        {
            CurrentRoom.Describe(); // Call the Describe method of the current room to show the details.
        }
    }
}
