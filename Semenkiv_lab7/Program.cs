using System;

namespace Laba_7_V_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task("do work");
            Task task2 = new Task("do sleap");
            Task task3 = new Task("do laba 3");
            Task task4 = new Task("meet with manager");
            Task task5 = new Task("do relax");
            ListTasks listTasks = new ListTasks(task4, task3, task5);
            Console.WriteLine("-------------------------------ListTasks--------------------------");
            Console.WriteLine(listTasks);
            listTasks.AddElement(task1);
            listTasks.AddElement(task2);
            Console.WriteLine("-------------------------------ListTasks--------------------------");
            Console.WriteLine(listTasks);
            listTasks.UpdateStatusOnComplitedByIndex(3);
            Console.WriteLine("-------------------------------ListTasks--------------------------");
            Console.WriteLine(listTasks);
            listTasks.UpdateStatusOnComplitedByIndex(1);
            Console.WriteLine("-------------------------------ListTasks--------------------------");
            Console.WriteLine(listTasks);
            listTasks.RemoveElementByIndex(1);
            listTasks.RemoveElementByIndex(1);
            Console.WriteLine("-------------------------------ListTasks--------------------------");
            Console.WriteLine(listTasks);
        }
    }
}
