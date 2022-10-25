using HRIS.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HRIS.Web.Controllers
{
    public class EmployeeProfileController : Controller
    {
        private readonly string _connectionString;
        private readonly IEmployeeProfile _employeeProfile;
        

        public EmployeeProfileController(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
            _employeeProfile = EmployeeProfile._employeeProfile;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetEmployeeProfileData()
        {
            var data = _employeeProfile.GetEmployeeProfileData(_connectionString);
            return Json(data);
        }
    }
}
