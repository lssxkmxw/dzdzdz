using System;
using System.Collections.Generic;
using System.Linq;

class TaskItem
{
    public string Description { get; set; }
    public bool IsDone { get; set; } = false;
}

class Program
{
    static List<TaskItem> tasks = new List<TaskItem>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== TO-DO LIST ===");
            ShowProgress();
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Показать все задачи");
            Console.WriteLine("3. Отметить задачу как выполненную");
            Console.WriteLine("4. Удалить задачу");
            Console.WriteLine("0. Выход");
            Console.Write("\nВыбор: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddTask(); break;
                case "2": ShowTasks(); break;
                case "3": MarkDone(); break;
                case "4": DeleteTask(); break;
                case "0": return;
                default: Console.WriteLine("Неверный ввод."); Pause(); break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Введите описание задачи: ");
        string desc = Console.ReadLine();
        tasks.Add(new TaskItem { Description = desc });
        Console.WriteLine("Задача добавлена!");
        Pause();
    }

    static void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                var status = tasks[i].IsDone ? "[✔]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i].Description}");
            }
        }
        Pause();
    }

    static void MarkDone()
    {
        ShowTasks();
        Console.Write("Введите номер выполненной задачи: ");
        if (int.TryParse(Console.ReadLine(), out int index) &&
            index >= 1 && index <= tasks.Count)
        {
            tasks[index - 1].IsDone = true;
            Console.WriteLine("Задача отмечена как выполненная.");
        }
        else
        {
            Console.WriteLine("Неверный номер.");
        }
        Pause();
    }

    static void DeleteTask()
    {
        ShowTasks();
        Console.Write("Введите номер задачи для удаления: ");
        if (int.TryParse(Console.ReadLine(), out int index) &&
            index >= 1 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Задача удалена.");
        }
        else
        {
            Console.WriteLine("Неверный номер.");
        }
        Pause();
    }

    static void ShowProgress()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Прогресс: 0% (0/0)");
            return;
        }

        int done = tasks.Count(t => t.IsDone);
        double percent = (double)done / tasks.Count * 100;
        Console.WriteLine($"Прогресс: {percent:F1}% ({done}/{tasks.Count})");
    }

    static void Pause()
    {
        Console.WriteLine("\nНажмите Enter для продолжения...");
        Console.ReadLine();
    }
}