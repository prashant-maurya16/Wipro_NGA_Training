using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string designation, double salary)
    {
        Id = id;
        Name = name;
        Designation = designation;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Designation: {Designation}, Salary: {Salary:C}";
    }
}

class Program
{
    static void Main()
    {
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>
        {
            { 1, new Employee(1, "Alice", "Manager", 75000) },
            { 2, new Employee(2, "Bob", "Developer", 60000) },
            { 3, new Employee(3, "Charlie", "HR", 50000) }
        };

        while (true)
        {
            Console.WriteLine("\n1. Remove Employee");
            Console.WriteLine("2. Update Employee Salary");
            Console.WriteLine("3. Display Employees");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice)) continue;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Employee ID to remove: ");
                    int removeId;
                    if (int.TryParse(Console.ReadLine(), out removeId) && employees.ContainsKey(removeId))
                    {
                        employees.Remove(removeId);
                        Console.WriteLine("Employee removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Employee not found.");
                    }
                    break;

                case 2:
                    Console.Write("Enter Employee ID to update salary: ");
                    int updateId;
                    if (int.TryParse(Console.ReadLine(), out updateId) && employees.ContainsKey(updateId))
                    {
                        Console.Write("Enter new salary: ");
                        double newSalary;
                        if (double.TryParse(Console.ReadLine(), out newSalary))
                        {
                            employees[updateId].Salary = newSalary;
                            Console.WriteLine("Salary updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid salary input.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Employee not found.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nEmployee List:");
                    foreach (var emp in employees.Values)
                    {
                        Console.WriteLine(emp);
                    }
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;

            }
        }
        Console.ReadLine();
    }
}
