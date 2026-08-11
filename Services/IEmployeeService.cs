namespace EmployeeApi;

public interface IEmployeeService
{
    Task<List<Employee>> GetAllAsync();
    Task<Employee> GetByIdAsync(int id);
    Task<Employee> AddAsync(Employee employee);
    Task<Manager> AddManagerAsync(Manager manager);
    Task<Developer> AddDeveloperAsync(Developer developer);
    Task<Employee> UpdateAsync(int id, Employee updatedEmployee);
    Task DeleteAsync(int id);
}