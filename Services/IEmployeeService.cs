namespace EmployeeApi;

public interface IEmployeeService
{
    Task<List<Employee>> GetAllAsync();
    Task<Employee> GetByIdAsync(int id);
    Task<Employee> AddAsync(Employee employee);
    Task DeleteAsync(int id);
}