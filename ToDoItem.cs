using System;

namespace ToDoListApp
{
    public class ToDoItem
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public ToDoItem(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"{Description} - {(IsCompleted ? "Completed" : "Pending")}";
        }
    }
}
