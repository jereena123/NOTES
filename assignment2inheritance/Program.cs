using assignment2inheritance;
using System;


internal class Program
{
    static Person[] details = new Person[100];
    static int detailsCount = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nPerson Details");
            Console.WriteLine("1. Add person details");
            Console.WriteLine("2. Display person details");
            Console.WriteLine("3. Search person details");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddDetails();
                    break;
                case "2":
                    DisplayPerson();
                    break;
                case "3":
                    SearchPerson();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid Choice, please try again");
                    break;
            }
        }
    }

    private static void AddDetails()
    {
        Console.WriteLine("\nAdd Data");
        if (detailsCount >= details.Length)
        {
            Console.WriteLine("Storage is full. Not possible to add data");
            return;
        }

        Console.WriteLine("\nSelect Person type:");
        Console.WriteLine("1. Student");
        Console.WriteLine("2. Employee");
        Console.Write("Enter your choice: ");
        string Choice = Console.ReadLine();

        Console.Write("Enter the name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the age: ");
        int age = GetValidIntegerInput();

        if (Choice == "1")
        {
            Console.Write("Enter Student RollNo: ");
            int roll = GetValidIntegerInput();
            Console.Write("Enter Student Marks: ");
            double marks = GetValidDoubleInput();

            details[detailsCount] = new Student(name, age, roll, marks);
        }
        else if (Choice == "2")
        {
            Console.Write("Enter Employee Base Pay: ");
            decimal bp = (decimal)GetValidDoubleInput();
            Console.Write("Enter Employee HR: ");
            decimal hr = (decimal)GetValidDoubleInput();
            Console.Write("Enter Employee Salary: ");
            decimal sal = (decimal)GetValidDoubleInput();

            details[detailsCount] = new Employee(name, age, bp, hr, sal);
        }
        else
        {
            Console.WriteLine("Invalid Person type. Please try again.");
            return;
        }

        detailsCount++;
        Console.WriteLine("Details added successfully.");
    }

    private static int GetValidIntegerInput()
    {
        int validInput;
        while (!int.TryParse(Console.ReadLine(), out validInput))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }
        return validInput;
    }

    private static double GetValidDoubleInput()
    {
        double validInput;
        while (!double.TryParse(Console.ReadLine(), out validInput))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }
        return validInput;
    }

    private static void DisplayPerson()
    {
        Console.WriteLine("\nDisplaying Person Details:");
        for (int i = 0; i < detailsCount; i++)
        {
            Console.WriteLine();
            details[i].DisplayDetails();
        }
    }

    private static void SearchPerson()
    {
        Console.Write("\nEnter the name to search: ");
        string name = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < detailsCount; i++)
        {
            if (details[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                details[i].DisplayDetails();
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Person not found.");
        }
    }
}
