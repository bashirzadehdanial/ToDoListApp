using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    public class ToDoList
    {
        private List<ToDoItem> items;

        public ToDoList()
        {
            items = new List<ToDoItem>();
        }

        public void AddItem(string description)
        {
            items.Add(new ToDoItem(description));
        }

        public void CompleteItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items[index].MarkAsCompleted();
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public void DisplayItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No items in the list.");
                return;
            }

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}. {items[i]}");
            }
        }
    }
}
