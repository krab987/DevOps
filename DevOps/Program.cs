namespace DevOps.Classes;
using DevOps.Enums;
using DevOps.Interfaces;
using System;
using System.Collections.Generic;

class Program
{
    private static List<Company> companies = new();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Lab1 Menu:");
            Console.WriteLine("1. Manage Companies");
            Console.WriteLine("2. Manage Workers");
            Console.WriteLine("3. Manage Tasks");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ManageCompanies();
                    break;
                case "2":
                    ManageWorkers();
                    break;
                case "3":
                    ManageTasks();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    _ = Console.ReadKey();
                    break;
            }
        }
    }

    private static void ManageCompanies()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Manage Companies:");
            Console.WriteLine("1. Create Company");
            Console.WriteLine("2. List Companies");
            Console.WriteLine("3. Hire Worker");
            Console.WriteLine("4. Fire Worker");
            Console.WriteLine("0. Back");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter company name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter company description: ");
                    var description = Console.ReadLine();
                    companies.Add(new Company { Name = name, Description = description });
                    Console.WriteLine("Company created. Press any key to continue...");
                    _ = Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine("Companies:");
                    for (int i = 0; i < companies.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {companies[i].Name} - {companies[i].Description}");
                    }
                    Console.WriteLine("Press any key to continue...");
                    _ = Console.ReadKey();
                    break;

                case "3":
                    if (!SelectCompany(out var selectedCompany)) break;
                    var worker = CreateWorker();
                    selectedCompany.HireWorker(worker);
                    Console.WriteLine("Worker hired. Press any key to continue...");
                    _ = Console.ReadKey();
                    break;

                case "4":
                    if (!SelectCompany(out selectedCompany)) break;
                    Console.Write("Enter worker ID to fire: ");
                    if (Guid.TryParse(Console.ReadLine(), out var id) && selectedCompany.FireWorkerAt(id))
                    {
                        Console.WriteLine("Worker fired. Press any key to continue...");
                    }
                    else
                    {
                        Console.WriteLine("Worker not found. Press any key to continue...");
                    }
                    _ = Console.ReadKey();
                    break;

                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    _ = Console.ReadKey();
                    break;
            }
        }
    }

    private static void ManageWorkers()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Manage Workers:");
            Console.WriteLine("1. Add Worker to Company");
            Console.WriteLine("2. List Workers in Company");
            Console.WriteLine("0. Back");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    if (!SelectCompany(out var selectedCompany)) break;
                    var worker = CreateWorker();
                    selectedCompany.HireWorker(worker);
                    Console.WriteLine("Worker added to the company. Press any key to continue...");
                    _ = Console.ReadKey();
                    break;

                case "2":
                    if (!SelectCompany(out selectedCompany)) break;
                    Console.WriteLine("Workers:");
                    foreach (var w in selectedCompany.Workers)
                    {
                        Console.WriteLine($"ID: {w.Id}, Name: {w.FirstName} {w.LastName}, Position: {w.Position}");
                    }
                    Console.WriteLine("Press any key to continue...");
                    _ = Console.ReadKey();
                    break;

                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    _ = Console.ReadKey();
                    break;
            }
        }
    }

    private static void ManageTasks()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Manage Tasks:");
            Console.WriteLine("1. Assign Task to Worker");
            Console.WriteLine("2. List Tasks for Worker");
            Console.WriteLine("0. Back");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    if (!SelectCompany(out var selectedCompany)) break;
                    if (!SelectWorker(selectedCompany, out var worker)) break;

                    Console.Write("Enter Task Title: ");
                    var title = Console.ReadLine();
                    Console.Write("Enter Task Description: ");
                    var description = Console.ReadLine();
                    Console.WriteLine("Select Task Status:");
                    foreach (var status in Enum.GetValues(typeof(Status)))
                    {
                        Console.WriteLine($"{(int)status}. {status}");
                    }
                    var taskStatus = (Status)int.Parse(Console.ReadLine() ?? "0");
                    var task = new Task(0, title, description, taskStatus);
                    worker.AddTask(task);
                    Console.WriteLine("Task assigned to worker. Press any key to continue...");
                    _ = Console.ReadKey();
                    break;

                case "2":
                    if (!SelectCompany(out selectedCompany)) break;
                    if (!SelectWorker(selectedCompany, out worker)) break;

                    Console.WriteLine("Tasks:");
                    foreach (var tasks in worker.Tasks)
                    {
                        Console.WriteLine($"ID: {tasks.Id}, Title: {tasks.Title}, Status: {tasks.StatusTask}");
                    }
                    Console.WriteLine("Press any key to continue...");
                    _ = Console.ReadKey();
                    break;

                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    _ = Console.ReadKey();
                    break;
            }
        }
    }

    private static bool SelectCompany(out Company selectedCompany)
    {
        Console.WriteLine("Select a company:");
        for (int i = 0; i < companies.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {companies[i].Name}");
        }

        Console.Write("Enter the number of the company: ");
        if (int.TryParse(Console.ReadLine(), out var companyIndex) && companyIndex > 0 && companyIndex <= companies.Count)
        {
            selectedCompany = companies[companyIndex - 1];
            return true;
        }

        Console.WriteLine("Invalid selection. Press any key to continue...");
        _ = Console.ReadKey();
        selectedCompany = null;
        return false;
    }

    private static bool SelectWorker(Company company, out IWorker selectedWorker)
    {
        var workers = company.Workers;
        Console.WriteLine("Select a worker:");
        for (int i = 0; i < workers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {workers[i].FirstName} {workers[i].LastName}");
        }

        Console.Write("Enter the number of the worker: ");
        if (int.TryParse(Console.ReadLine(), out var workerIndex) && workerIndex > 0 && workerIndex <= workers.Count)
        {
            selectedWorker = workers[workerIndex - 1];
            return true;
        }

        Console.WriteLine("Invalid selection. Press any key to continue...");
        _ = Console.ReadKey();
        selectedWorker = null;
        return false;
    }
    private static Worker CreateWorker()
    {
        Console.Write("Enter first name: ");
        var firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        var lastName = Console.ReadLine();
        Console.Write("Enter age: ");
        var age = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter position: ");
        var position = Console.ReadLine();
        Console.Write("Enter salary: ");
        var salary = int.Parse(Console.ReadLine() ?? "0");

        return new Worker
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            Position = position,
            Salary = salary
        };
    }
}
