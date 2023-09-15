
using IKProject.BusinessLayer.Abstract;
using IKProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProject.API.Controllers
{
    public class StaffController : BaseApiController
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }


        [HttpGet]
        public IActionResult GetAllStaffs()
        {
            var staffEntities = _staffService.TGetList();
            return Ok(staffEntities);
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _staffService.TGetByID(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TAdd(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetByID(id);
            _staffService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateStaff")]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }
    }
}
