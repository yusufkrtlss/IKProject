using AutoMapper;
using IKProject.BusinessLayer.Abstract;
using IKProject.EntityLayer.Concrete;
using IKProject.EntityLayer.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProject.API.Controllers
{
    public class StaffController : BaseApiController
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;

        public StaffController(IStaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetAllStaffs()
        {
            var staffEntities = _staffService.TGetList();
            var staffDTOs = _mapper.Map<List<StaffDto>>(staffEntities);

            return Ok(staffDTOs);
        }

        [HttpPost]
        public IActionResult AddStaff([FromBody] StaffDto staffDTO)
        {
            if (staffDTO == null)
            {
                return BadRequest("Staff data is null.");
            }

            // Map only the desired properties to the Staff entity
            var staffEntity = new Staff
            {
                DepartmentId = staffDTO.Department.Id,
                GenderId = staffDTO.Gender.Id,
                //Comments = new Comment
                //{
                //    Description = staffDTO.
                //},
                StaffMeetings = null // Set Meetings to null if you want it to be null
            };

            // You should add appropriate validation and error handling here.
            // Typically, you would call your business layer to add the staff.

            // Add staffEntity to your business logic/service layer

            var createdStaffDTO = _mapper.Map<StaffDto>(staffEntity);

            return CreatedAtAction("GetAllStaffs", createdStaffDTO);
        }
    }
}
