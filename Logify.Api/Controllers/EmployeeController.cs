using Logify.DataLayer;
using Logify.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPut]
        public ActionResult<bool> UpdateEmployee([FromBody]Employee employee)
        {
            EmployeeRepository repo = new EmployeeRepository();

            bool updated = repo.UpdateEmployeeInfo(employee);

            return Ok(updated);
        }

        [HttpGet]
        public ActionResult<Employee> Search(string lastName, int roleId)
        {
            EmployeeRepository repo = new EmployeeRepository();

            Employee employee = repo.GetEmployeesByLastNameRoleId(lastName, roleId);

            if (employee == null)
            {
                return Ok(new Employee());
            }

            return Ok(employee);
        }

        [HttpPost]
        public ActionResult<bool> CreateEmployee(Employee employee)
        {
            EmployeeRepository repo = new EmployeeRepository();

            bool created = repo.InsertNewEmployee(employee);

            return Ok(created);
        }

        [HttpDelete]
        public ActionResult<bool> Delete(int employeeId)
        {
            EmployeeRepository repo = new EmployeeRepository();

            bool deleted = repo.DeleteEmployee(employeeId);

            return Ok(deleted);
        }
    }
}