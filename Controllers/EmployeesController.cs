namespace EmployeeApi;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]

public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _service;

    public EmployeesController(IEmployeeService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Employee>>> GetAll()
    {
        var employees = await _service.GetAllAsync();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetById(int id)
    {
        try
        {
            var employee = await _service.GetByIdAsync(id);
            return Ok(employee);
        }
        catch(EmployeeNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<Employee>> Create(Employee employee)
    {
        var newEmployee = await _service.AddAsync(employee);
        return CreatedAtAction(nameof(GetById), new { id = newEmployee.Id }, newEmployee);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Employee>> Update(int id, Employee updatedEmployee)
    {
        try
        {
            var employee = await _service.UpdateAsync(id, updatedEmployee);
            return Ok(employee);
        }
        catch(EmployeeNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}