using IKProject.BusinessLayer.Abstract;
using IKProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProject.API.Controllers
{
    public class MeetingController : BaseApiController
    {
        private readonly IMeetingService _meetingService;
        public MeetingController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }

        [HttpGet]
        public IActionResult GetAllMeetings()
        {
            var meetingEntities = _meetingService.TGetList();
            return Ok(meetingEntities);
        }
        [HttpGet("{id}")]
        public IActionResult GetMeeting(int id)
        {
            var values = _meetingService.TGetByID(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddMeeting(Meeting meeting)
        {
            _meetingService.TAdd(meeting);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMeeting(int id)
        {
            var values = _meetingService.TGetByID(id);
            _meetingService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateMeeting")]
        public IActionResult UpdateMeeting(Meeting meeting)
        {
            _meetingService.TUpdate(meeting);
            return Ok();
        }
    }
}
