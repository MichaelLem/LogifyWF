using Logify.BizLayer;
using Logify.DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace Logify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeEntryController : ControllerBase
    {
        [HttpPost("ClockIn")]
        public IActionResult ClockIn(int employeeId)
        {
            TimeEntryRepository repo = new TimeEntryRepository();

            int timeEntryId = repo.ClockIn(employeeId);

            if (timeEntryId == 0)
            {
                return BadRequest("Clock in failed.");
            }

            return Ok(timeEntryId);
        }

        //[HttpPost]
        //public ActionResult<DateTime> Break(int employeeId)
        //{
        //    Session session = new Session(employeeId);

        //    session.BreakTime();

        //    return Ok(session.timeBreak);
        //}

        //[HttpPost]
        //public ActionResult<DateTime> Return(int employeeId)
        //{
        //    Session session = new Session(employeeId);

        //    session.ReturnTime();

        //    return Ok(session.timeReturn);
        //}

        //[HttpPost]
        //public ActionResult<DateTime> End(int employeeId)
        //{
        //    Session session = new Session(employeeId);

        //    session.EndTime();

        //    return Ok(session.timeEnd);
        //}
    }
}