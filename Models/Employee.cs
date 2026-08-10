namespace EmployeeApi;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee (int id, string name, int age, double salary)
    {
        Id = id;
        Name = name;
        Age = age;
        Salary = salary;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"{Id}: {Name}, {Age} yo, {Salary}$");
    }
}