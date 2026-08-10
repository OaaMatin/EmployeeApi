namespace EmployeeApi;

public class EmployeeService : IEmployeeService
{
    private List<Employee> _employees;

    public EmployeeService()
    {
        _employees = new List<Employee>
        {
            new Employee(1, "Ali", 25, 20000000),
            new Employee(2, "Sara", 28, 24000000),
            new Employee(3, "Reza", 22, 22000000)
        };
    }

    public async Task<List<Employee>> GetAllAsync()
    {
        return _employees;
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        var employee = _employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            throw new EmployeeNotFoundException($"User with id {id} not found.");
        }
        return employee;
    }

    public async Task<Employee> AddAsync(Employee employee)
    {
        _employees.Add(employee);
        return employee;
    }

    public void Delete(int id)
    {
        _employees.RemoveAll(e => e.Id == id);
    }
}