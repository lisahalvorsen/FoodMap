using Microsoft.VisualBasic.CompilerServices;

namespace FoodMap;

public static class App
{
    public static void Run()
    {
        PrintMenu();
    }

    private static void PrintMenu()
    {
        Console.WriteLine("Heisann 🤓 Hva vil du gjøre i dag?");

        while (true)
        {
            Console.WriteLine("1. Legg til en vare");
            Console.WriteLine("2. Slett en vare");
            Console.WriteLine("3. Se handlelista");
            Console.WriteLine("4. Lukk programmet");

            var choice = Console.ReadLine();
         
            switch (choice)
            {
                case "1":
                    ShoppingList.AddItemToGroceryList();
                    break;
                case "2":
                    ShoppingList.RemoveItemFromGroceryList();
                    break;
                case "3":
                    ShoppingList.PrintShoppingList();
                    break;
                case "4":
                    Console.WriteLine("Adios amigo 🫡");
                    Environment.Exit(0);
                    break;
            }
        }
    }

    // public static string PromptUser(string message)
    // {
    //     Console.WriteLine(message);
    //     return Console.ReadLine();
    // }
}