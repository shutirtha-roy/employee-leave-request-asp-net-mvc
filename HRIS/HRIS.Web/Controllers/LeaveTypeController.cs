using Autofac;
using HRIS.Web.Models;
using HRIS.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Web.Controllers
{
    public class LeaveTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILifetimeScope _scope;

        public LeaveTypeController(IUnitOfWork unitOfWork, ILifetimeScope scope)
        {
            _unitOfWork = unitOfWork;
            _scope = scope;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            LeaveTypeModel leaveTypeModel = _scope.Resolve<LeaveTypeModel>();
            return View(leaveTypeModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LeaveTypeModel obj)
        {
            if (ModelState.IsValid)
            {
                obj.ResolveDependency(_scope);
                obj.CreateLeaveType();
                return RedirectToAction("Create");
            }

            return View(obj);
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            LeaveTypeModel leaveTypeModel = new();
            leaveTypeModel.ResolveDependency(_scope);

            var objCoverTypeList = leaveTypeModel.GetAll();
            return Json(new { data = objCoverTypeList });  
        }

        [HttpGet]
        public ActionResult GetData()
        {
            LeaveTypeModel leaveTypeModel = new();
            leaveTypeModel.ResolveDependency(_scope);

            var data = leaveTypeModel.GetData();
            return Json(data);
        }
    }
}
