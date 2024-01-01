using System.Collections.Generic;
using System;
using System.Linq;

namespace Todo_list
{

    public static class Program
    {
        public static void Main()
        {
            List<string> todoList = new List<string>();

            while (true)
            {
                Console.WriteLine("Todo List:");
                DisplayTodoList(todoList);

                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the new todo: ");
                        string newTodo = Console.ReadLine();
                        todoList.Add(newTodo);
                        break;

                    case "2":
                        Console.Write("Enter the todo to remove: ");
                        string todoToRemove = Console.ReadLine();
                        todoList.Remove(todoToRemove);
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void DisplayTodoList(List<string> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No todos.");
            }
            else
            {
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
            }


        }
    }
}
