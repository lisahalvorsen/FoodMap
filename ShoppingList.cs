using System.Security.Cryptography;

namespace FoodMap;

public static class ShoppingList
{
    private static readonly List<string> GroceryList = [];

    public static void AddItemToGroceryList()
    {
        Console.WriteLine("Skriv inn her 👇. For å gå tilbake, skriv 'x'.");

        while (true)
        {
            var item = Console.ReadLine();
            AddItem(item);

            if (item == "x")
            {
                return;
            }
        }
    }

    public static void RemoveItemFromGroceryList()
    {
        Console.WriteLine("Hva vil du fjerne fra lista? For å gå tilbake, skriv 'x'.");

        while (true)
        {
            var itemToRemove = Console.ReadLine();
            RemoveItem(itemToRemove);
            Console.WriteLine($"{itemToRemove} er ikke lenger på handelista di.");

            if (itemToRemove == "x")
            {
                break;
            }
        }
    }

    private static void AddItem(string item)
    {
        GroceryList.Add(item);
    }

    private static void RemoveItem(string item)
    {
        GroceryList.Remove(item);
    }

    public static void PrintShoppingList()
    {
        if (GroceryList.Count == 0)
        {
            Console.WriteLine("Handelista di er tom 🛒");
        }
        else
        {
            Console.WriteLine($"Handleliste: ");
            foreach (var item in GroceryList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}