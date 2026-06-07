using Logify.DataLayer;
using Logify.Models;
using LogifyWin;
using Microsoft.AspNetCore.Mvc;

namespace Logify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("Search")]
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

        [HttpPost("Update")]
        public bool UpdateEmployee(Employee employee)
        {
            EmployeeRepository repo = new EmployeeRepository();

            bool updated = repo.UpdateEmployeeInfo(employee);

            return updated;
        }
    }
}