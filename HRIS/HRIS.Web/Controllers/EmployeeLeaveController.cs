using HRIS.Web.Models;
using HRIS.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Web.Controllers
{
    public class EmployeeLeaveController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeLeaveController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            EmployeeLeaveModel employeeLeaveModel = new();
            employeeLeaveModel.Id = Guid.NewGuid();

            return View(employeeLeaveModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeLeaveModel obj)
        {
            if (ModelState.IsValid)
            {
                obj.CreateEmployeeLeave(_unitOfWork);
                return RedirectToAction("Create");
            }

            return View(obj);
        }


        [HttpGet]
        public ActionResult GetAll()
        {
            EmployeeLeaveModel employeeLeaveModel = new();
            IEnumerable<EmployeeLeaveModel> objEmployeeLeaveList = employeeLeaveModel.GetAll(_unitOfWork);
            return Json(new { data = objEmployeeLeaveList });
        }
    }
}
