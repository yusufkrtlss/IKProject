using IKProject.BusinessLayer.Abstract;
using IKProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProject.API.Controllers
{
    public class CommentController : BaseApiController
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet]
        public IActionResult GetComments()
        {
            var values = _commentService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            _commentService.TAdd(comment);
            return Ok();
        }
    }
}
