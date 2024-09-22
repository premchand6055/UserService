using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Services;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly EmployeeServiceClient _employeeServiceClient;

        public UsersController(EmployeeServiceClient employeeServiceClient)
        {
            _employeeServiceClient = employeeServiceClient;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserWithEmployeeDetails(int id)
        {
            // Fetch user details (dummy data for now)
            var user = new { UserId = id, Username = "john.doe", IsActive = true };

            // Fetch employee details from EmployeeService
            var employeeDetails = await _employeeServiceClient.GetEmployeeDetails(id);

            if (employeeDetails == null)
            {
                return NotFound("Employee not found.");
            }

            return Ok(new { user, employeeDetails });
        }
    }
}
