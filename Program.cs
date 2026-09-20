// Week 4: Multi-Animal Entry System
using System;

// Print program header
Console.WriteLine("\n=== Noah's Ark Entry System ===");

// Used to cancel program while() loop
bool running = true;

// Declare and set to 0 animal summary stats
int animalTypes = 0;
int animalCount = 0;
double animalFood = 0;

// Run program
while (running)
{
    // Display program options list
    Console.WriteLine($"""
                    {Environment.NewLine}1. Add Animal
                    2. View Summary
                    3. Exit
                    """);
    // Request program function choice
    Console.Write("\nEnter choice: ");
    int choiceInput = Convert.ToInt32(Console.ReadLine());

    // Handle logic for 3 valid options + invalid option
    switch (choiceInput)
    {
        // 1. Add Animal
        case 1:
            // Request animal name
            Console.Write("\nEnter an animal name: ");
            string nameInput = Console.ReadLine();

            // Request animal count
            Console.Write("Enter Count: ");
            int countInput = Convert.ToInt32(Console.ReadLine());

            // Request food amount per animal
            Console.Write("Enter food per animal per day: ");
            double foodInput = Convert.ToDouble(Console.ReadLine());

            // Indicate successful input of animal
            Console.WriteLine($"\n{nameInput} added successfully!");

            // Update animal summary data
            animalCount = animalCount + countInput;
            animalFood = animalFood + foodInput * animalCount;
            animalTypes++;
            break;
        // 2. View summary
        case 2:
            // Print summary header
            Console.WriteLine("\n=== Voyage Summary ===");

            // Print summary data
            Console.WriteLine($"\nAnimal types entered: {animalTypes}");
            Console.WriteLine($"Total animals: {animalCount}");
            Console.WriteLine($"Daily food required: {animalFood}");
            Console.WriteLine($"40-day voyage food: {animalFood * 40}");
            break;
        // 3. Exit
        case 3:
            // Cancel while loop, closing program
            running = false;
            break;
        // Invalid input
        default:
            // Re-ask for valid input
            Console.WriteLine("\nInvalid input!");
            continue;
            break;
    }
}
