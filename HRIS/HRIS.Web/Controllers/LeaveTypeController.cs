using HRIS.Web.Models;
using HRIS.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Web.Controllers
{
    public class LeaveTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LeaveTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            LeaveTypeModel leaveTypeModel = new();
            return View(leaveTypeModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LeaveTypeModel obj)
        {
            if (ModelState.IsValid)
            {
                obj.CreateLeaveType(_unitOfWork);
                return RedirectToAction("Create");
            }

            return View(obj);
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            LeaveTypeModel leaveTypeModel = new();
            IEnumerable<LeaveTypeModel> objCoverTypeList = leaveTypeModel.GetAll(_unitOfWork);
            return Json(new { data = objCoverTypeList });
        }

        [HttpGet]
        public ActionResult GetData()
        {
            LeaveTypeModel leaveTypeModel = new();
            var data = leaveTypeModel.GetData(_unitOfWork);
            return Json(data.ToList());
        }
    }
}
