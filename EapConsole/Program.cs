// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");




// Keep the console window open in debug mode.
Console.WriteLine("Press any key to exit.");
Console.ReadKey();

//create a class to hold employee data 
public class Employee
{
    private long Id { get; set; }
    private string Name { get; set; }
    private string Department { get; set; }
    private string Email { get; set; }
    private string Phone { get; set; }
    
    public Employee(Employee emp)
    {
        Id = emp.Id;
        Name = emp.Name;
        Department = emp.Department;
        Email = emp.Email;
        Phone = emp.Phone;
    }

    
}