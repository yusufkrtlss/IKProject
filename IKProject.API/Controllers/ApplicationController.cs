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
            var commentEntities = _applicationService.TGetList();
            return Ok(commentEntities);
        }
        [HttpGet("{id}")]
        public IActionResult GetApplication(int id)
        {
            var values = _applicationService.TGetByID(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCApplication(Application comment)
        {
            _applicationService.TAdd(comment);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteApplication(int id)
        {
            var values = _applicationService.TGetByID(id);
            _applicationService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateApplication")]
        public IActionResult UpdateComment(Application comment)
        {
            _applicationService.TUpdate(comment);
            return Ok();
        }
        [HttpPost("upload")]
        public IActionResult UploadPdf([FromBody] PdfUploadModel model)
        {
            if (model == null || model.FileName == null || model.PdfData == null)
                return BadRequest();

            _applicationService.UploadPdfFile(model.FileName, model.PdfData);

            return Ok("PDF başarıyla yüklendi ve veritabanına kaydedildi.");
        }
    }
}
