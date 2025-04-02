List <string>shoppingCartValues = new List<string>();

Console.WriteLine("Shopping Cart Menu");
Console.WriteLine("1. Add Item");
Console.WriteLine("2. Remove Item");
Console.WriteLine("3. View Cart");
Console.WriteLine("4. Clear Cart");
Console.WriteLine("5. Exit");

while (true)
{
    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter item to add: ");
            string newItem = Console.ReadLine()?.Trim();
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                if (!shoppingCartValues.Contains(newItem, StringComparer.OrdinalIgnoreCase))
                {
                    shoppingCartValues.Add(newItem);
                    Console.WriteLine($"'{newItem}' added.");
                }
                else
                {
                    Console.WriteLine("Item already exists.");
                }
            }
            else
            {
                Console.WriteLine("Item cannot be empty.");
            }
            break;
        case 2:
            Console.Write("Enter item to remove: ");
            string itemToRemove = Console.ReadLine();
            shoppingCartValues.Remove(itemToRemove);
            break;
        case 3:
            Console.WriteLine("Items in the cart:");
            var sortedList = shoppingCartValues.OrderBy(x => x).ToList();
            foreach (var item in sortedList)
                Console.WriteLine($"- {item}");
            break;
        case 4:
            shoppingCartValues.Clear();
            Console.WriteLine("Cart cleared.");
            break;
        case 5:
            Console.WriteLine("Exiting...");
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}       

