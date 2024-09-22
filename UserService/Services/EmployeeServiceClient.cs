using UserService.Models;

namespace UserService.Services
{
    public class EmployeeServiceClient
    {
        private readonly HttpClient _httpClient;
        public EmployeeServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            var response = await _httpClient.GetAsync($"https://localhost:7232/api/employees/{employeeId}");
            response.EnsureSuccessStatusCode();

            // Deserialize the JSON response into Employee object
            var employee = await response.Content.ReadFromJsonAsync<Employee>();
            return employee; // Return the Employee object
        }
    }
}
