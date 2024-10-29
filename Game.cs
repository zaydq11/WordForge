using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordForge
{
    class Game // Defines the Game class, which manages the main game loop and setup.
    {
        private Player player; // Stores the player object.
        private bool isPlaying; // Controls whether the game is still running.

        // Constructor that sets up the game.
        public Game()
        {
            isPlaying = true; // Initialize the game as running.
            SetupWorld(); // Call the method that sets up the rooms and game world.
        }

        // Starts the game loop.
        public void Start()
        {
            Console.WriteLine("Welcome to WordForge!"); // Print a welcome message to the player.
            player.Look(); // Show the player their starting room.

            // Main game loop that runs while the game is playing.
            while (isPlaying)
            {
                Console.Write("> "); // Show a prompt for the player's input.
                string command = Console.ReadLine().ToLower(); // Read the player's input and convert it to lowercase.
                HandleCommand(command); // Call the method that handles player commands.
            }
        }

        // Handles player commands such as "look," "go north," etc.
        private void HandleCommand(string command)
        {
            string[] parts = command.Split(' '); // Split the command by spaces (e.g., "go north" becomes ["go", "north"]).

            // If the player types "look," describe the current room.
            if (parts[0] == "look")
            {
                player.Look(); // Show the room description.
            }
            // If the player types "go" followed by a direction (e.g., "go north"), move the player.
            else if (parts[0] == "go")
            {
                if (parts.Length > 1) // Ensure the player typed a direction.
                    player.Move(parts[1]); // Move the player in the given direction (e.g., north).
                else
                    Console.WriteLine("Go where?"); // If no direction is given, ask the player to clarify.
            }
            // If the player types "quit," exit the game loop.
            else if (parts[0] == "quit")
            {
                isPlaying = false; // Stop the game loop.
                Console.WriteLine("Thanks for playing!"); // Print a goodbye message.
            }
            else
            {
                Console.WriteLine("Unknown command."); // Handle any unknown commands.
            }
        }

        // Sets up the game world by creating rooms and connecting them with exits.
        private void SetupWorld()
        {
            // Create some rooms with names and descriptions.
            Room room1 = new Room("Entrance Hall", "You are in a grand hall with doors to the north and south.");
            Room room2 = new Room("Library", "Rows of ancient books line the walls.");
            Room room3 = new Room("Garden", "A peaceful garden with a fountain.");

            // Define the exits between rooms.
            room1.SetExit("north", room2); // The entrance hall leads north to the library.
            room1.SetExit("south", room3); // The entrance hall leads south to the garden.
            room2.SetExit("south", room1); // The library leads south back to the entrance hall.
            room3.SetExit("north", room1); // The garden leads north back to the entrance hall.

            // Start the player in the entrance hall.
            player = new Player(room1);
        }
    }
}
