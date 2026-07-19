using Logify.DataLayer;
using Logify.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public ActionResult<bool> Employee(Employee employee)
        {
            EmployeeRepository repo = new EmployeeRepository();

            bool created = repo.InsertNewEmployee(employee);

            return Ok(created);
        }

        [HttpGet]
        public ActionResult<Employee> Employee(string lastName, int roleId)
        {
            EmployeeRepository repo = new EmployeeRepository();

            Employee employee = repo.GetEmployeesByLastNameRoleId(lastName, roleId);

            if (employee == null)
            {
                return Ok(new Employee());
            }

            return Ok(employee);
        }

        [HttpPut]
        public ActionResult<bool> UpdateEmployee(Employee employee)
        {
            EmployeeRepository repo = new EmployeeRepository();

            bool updated = repo.UpdateEmployeeInfo(employee);

            return Ok(updated);
        }

        [HttpDelete]
        public ActionResult<bool> Employee(int employeeId)
        {
            EmployeeRepository repo = new EmployeeRepository();

            bool deleted = repo.DeleteEmployee(employeeId);

            return Ok(deleted);
        }
    }
}