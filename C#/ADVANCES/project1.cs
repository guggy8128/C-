public interface IEmployee
{
    int Id { get; set; }
    string Name { get; set; }
    string Department { get; set; }
}
public class Employee : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}
public class SchoolHRManagementSystem
{
    public List<IEmployee> Employees { get; set; }

    public SchoolHRManagementSystem()
    {
        Employees = new List<IEmployee>();
    }

    public void AddEmployee(IEmployee employee)
    {
        Employees.Add(employee);
    }

    public void RemoveEmployee(int employeeId)
    {
        IEmployee employee = Employees.FirstOrDefault(e => e.Id == employeeId);
        if (employee != null)
        {
            Employees.Remove(employee);
        }
    }

    public IEmployee GetEmployee(int employeeId)
    {
        return Employees.FirstOrDefault(e => e.Id == employeeId);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        SchoolHRManagementSystem hrms = new SchoolHRManagementSystem();

        hrms.AddEmployee(new Employee { Id = 1, Name = "John Doe", Department = "Mathematics" });
        hrms.AddEmployee(new Employee { Id = 2, Name = "Jane Smith", Department = "Science" });

        Console.WriteLine("Employees:");
        foreach (var employee in hrms.Employees)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}");
        }

        Console.WriteLine("\nRemoving an employee...");
        hrms.RemoveEmployee(1);

        Console.WriteLine("\nEmployees after removal:");
        foreach (var employee in hrms.Employees)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}");
        }
    }
}