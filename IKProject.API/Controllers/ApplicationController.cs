using IKProject.API.Models;
using IKProject.BusinessLayer.Abstract;
using IKProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProject.API.Controllers
{
    public class ApplicationController : BaseApiController
    {
        private readonly IApplicationService _applicationService;

        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public IActionResult GetAllApplications()
        {
            var applications = _applicationService.TGetList();
            return Ok(applications);
        }

        [HttpGet("{id}")]
        public IActionResult GetApplication(int id)
        {
            var application = _applicationService.TGetByID(id);

            if (application == null)
            {
                return NotFound();
            }

            return Ok(application);
        }

        [HttpPost]
        public IActionResult AddApplication(Application application)
        {
            if (application == null)
            {
                return BadRequest();
            }

            _applicationService.TAdd(application);
            return Ok("Application successfully added.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteApplication(int id)
        {
            var application = _applicationService.TGetByID(id);

            if (application == null)
            {
                return NotFound();
            }

            _applicationService.TDelete(application);
            return Ok("Application successfully deleted.");
        }

        [HttpPut("UpdateApplication")]
        public IActionResult UpdateApplication(Application application)
        {
            if (application == null)
            {
                return BadRequest();
            }

            _applicationService.TUpdate(application);
            return Ok("Application successfully updated.");
        }


        [HttpPost("upload")]
    public IActionResult UploadPdf([FromBody] PdfUploadModel model)
{
    if (model == null || string.IsNullOrWhiteSpace(model.FileName) || model.PdfData == null)
    {
        return BadRequest("");
    }

    _applicationService.UploadPdfFile(model.FileName, model.PdfData);

    return Ok("PDF yüklendi");
    }
    }
}