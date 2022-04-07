using Business.Base.IServices;
using Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace stock_tracking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService _commentService)
        {
            commentService = _commentService;
        }
        [HttpGet(nameof(GetCommentById) + "/{commentId}")]
        public IActionResult GetCommentById(int commentId)
        {
            try
            {
                commentService.GetById(commentId);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            try
            {
                var data = commentService.GetAll();
                return Ok(data);

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost(nameof(AddComment))]
        public IActionResult AddComment(CommentDto model)
        {
            try
            {
                if (model != null)
                {
                    commentService.Add(model);
                    return Ok();
                }
                else
                    return BadRequest();
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut(nameof(UpdateComment))]
        public IActionResult UpdateComment(CommentDto model)
        {
            try
            {
                if (model != null)
                {
                    commentService.Update(model);
                    return Ok(model);
                }
                else
                    return BadRequest();

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete(nameof(DeleteComment) + "/{commentId}")]
        public IActionResult DeleteComment(int commentId)
        {
            try
            {
                var model = commentService.GetById(commentId);
                if (model != null)
                {
                    commentService.Delete(model);
                    return Ok(model);
                }
                else
                    return BadRequest();

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
