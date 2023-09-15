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
        public IActionResult GetAllComments()
        {
            var commentEntities = _commentService.TGetList();
            return Ok(commentEntities);
        }
        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var values = _commentService.TGetByID(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            _commentService.TAdd(comment);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.TGetByID(id);
            _commentService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateComment")]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentService.TUpdate(comment);
            return Ok();
        }
    }
}
