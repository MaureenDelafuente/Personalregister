using System.Collections;

namespace PersonalRegister;

public class Program
{
    private static ArrayList _employees = new();

    public static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till Personalregistret!");

        var keepLooping = true;
        while (keepLooping)
        {
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Lägg till anställd");
            Console.WriteLine("2. Lista anställda");
            Console.WriteLine("3. Avsluta");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    ListEmployees();
                    break;
                case "3":
                    keepLooping = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }
    }
    private static void ListEmployees()
    {
        Console.WriteLine("Anställda:");
        foreach (Employee employee in _employees)
        {
            Console.WriteLine($"{employee.Name} ({employee.Salary} kr)");
        }
    }

    private static void AddEmployee()
    {
        Console.WriteLine("Namn på den nya anställda:");
        var name = Console.ReadLine();
        if (name == null)
        {
            Console.WriteLine("Ogiltigt namn, avbryter.");
            return;
        }

        Console.WriteLine("Lön för den nya anställda:");
        var salaryString = Console.ReadLine();
        if (salaryString == null)
        {
            Console.WriteLine("Ogiltig lön, avbryter.");
            return;
        }
        int salary;
        try
        {
            salary = int.Parse(salaryString);
        }
        catch (Exception)
        {
            Console.WriteLine("Ogiltig lön, avbryter.");
            return;
        }

        var employee = new Employee { Name = name, Salary = salary };
        _employees.Add(employee);
    }
}

public class Employee
{
    public required string Name { get; set; }
    public int Salary { get; set; }
}

/*1
Uppgift 1 Vilka klasser bör ingå i programmet?
PersonalRegister och Employee
Uppgift 2 Vilka attribut och metoder bör ingå i dessa klasser?
Attribut: PersonalRegister: Employees, ArrayList<Employee>, Employee:Name string, Salary  int.

Metoder: PersonalRegister: Main, CommandLoop, AddEmployee, ListEmployees.

Uppgift 3 Skriv programmet
*/