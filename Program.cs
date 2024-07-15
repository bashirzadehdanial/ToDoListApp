using System;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();
            while (true)
            {
                Console.WriteLine("\nTo-Do List:");
                toDoList.DisplayItems();

                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add a new item");
                Console.WriteLine("2. Complete an item");
                Console.WriteLine("3. Exit");

                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter the description: ");
                        string description = Console.ReadLine();
                        toDoList.AddItem(description);
                        break;
                    case "2":
                        Console.Write("Enter the index of the item to complete: ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            toDoList.CompleteItem(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
