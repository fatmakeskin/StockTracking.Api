using Business.Services;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTracking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController:ControllerBase
    {
        private readonly CommentService<Comment> commentService;
        public CommentController(CommentService<Comment> _commentService)
        {
            commentService = _commentService;
        }
        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            return Ok();
        }
        
    }
}
