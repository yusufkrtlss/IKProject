using IKProject.BusinessLayer.Abstract;
using IKProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProject.API.Controllers
{
    public class DepartmentController : BaseApiController
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public IActionResult GetDepartments() 
        {
            var values = _departmentService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            _departmentService.TAdd(department);
            return Ok();
        }
    }
}
