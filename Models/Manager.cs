namespace EmployeeApi;

public class Manager : Employee, IPayable
{
    public int TeamSize { get; set; }

    public Manager(int id, string name, int age, double salary, int teamSize)
        : base(id, name, age, salary)
    {
        TeamSize = teamSize;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Team Size: {TeamSize}");
    }

    public double CalculateBonus()
    {
        return TeamSize * 500000;
    }
}