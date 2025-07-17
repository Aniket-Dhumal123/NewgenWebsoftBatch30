using FinalNewProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FinalNewProject.Controllers
{
    public class EmployeeAPIController : Controller
    {
        private string employeeendpointurl = "https://localhost:7072/api/Employee/";
        private string departmentendpointurl = "https://localhost:7072/api/Department/";
        private HttpClient client = new HttpClient();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            List<object> employeesWithDept= new List<object>();
            HttpResponseMessage response= await client.GetAsync(employeeendpointurl);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var data= JsonConvert.DeserializeObject<List<Employee>>(result);

                if (data != null)
                {

                }
            }
            return Json(employeesWithDept);
        }
    }
}
