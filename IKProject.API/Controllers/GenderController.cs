using IKProject.BusinessLayer.Abstract;
using IKProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProject.API.Controllers
{
    public class GenderController : BaseApiController
    {
        private readonly IGenderService _genderService;

        public GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }
        [HttpGet]
        public IActionResult GetGenders()
        {
            var values = _genderService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetGender(int id)
        {
            var values = _genderService.TGetByID(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddGender(Gender gender)
        {
            _genderService.TAdd(gender);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGender(int id)
        {
            var values = _genderService.TGetByID(id);
            _genderService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateGender")]
        public IActionResult UpdateGender(Gender gender)
        {
            _genderService.TUpdate(gender);
            return Ok();
        }
    }
}
