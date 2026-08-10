namespace EmployeeApi;

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(int id, string name, int age, double salary, string programmingLanguage)
        : base(id, name, age, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }
}