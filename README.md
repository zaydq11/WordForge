# WordForge

Adding New Rooms and Exits

To customize WordForge, you can add new rooms or exits to create your own unique map layout.



Step 1: Open the SetupWorld Method

Locate the Game class in your project.

Find the SetupWorld method in the Game class. This is where all rooms and connections are defined.


In SetupWorld, you’ll see code like this:

Room room1 = new Room("Entrance Hall", "You are in a grand hall with doors to the north and south.");

Room room2 = new Room("Library", "Rows of ancient books line the walls.");

Room room3 = new Room("Garden", "A peaceful garden with a fountain.");


Each line creates a new room with a name and description. The variable room1 is the Entrance Hall, room2 is the Library, and so on.


Step 2: Add a New Room


To add a new room, use the same pattern:

Room room4 = new Room("Kitchen", "A cozy kitchen with a smell of fresh bread.");

Room name: "Kitchen"

Description: "A cozy kitchen with a smell of fresh bread."


This line creates a room but doesn’t connect it to any other rooms yet.



Step 3: Set Exits for Rooms

Next, set the directions that connect rooms, which defines how players move between them. For example, to connect the Kitchen to the Entrance Hall and make it accessible:

room1.SetExit("east", room4); // Adds an east exit from Entrance Hall to Kitchen.

room4.SetExit("west", room1); // Adds a west exit from Kitchen back to Entrance Hall.

These lines allow the player to travel east from the Entrance Hall to the Kitchen and west from the Kitchen back to the Entrance Hall.
