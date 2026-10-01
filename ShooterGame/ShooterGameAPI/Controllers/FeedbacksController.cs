using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShooterGameAPI.Module;
using ShooterGameAPI.Data;

namespace ShooterGameAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class FeedbacksController : ControllerBase
    {
        public readonly GameDbContext db;

        public FeedbacksController(GameDbContext _db)
        {
            db = _db;
        }

        [HttpPost]
        public async Task<ActionResult<Feedbacks>> AddFeedbacks(Feedbacks feedback)
        {
            if(feedback== null)
            {
                return BadRequest();
            }
            if(string.IsNullOrWhiteSpace(feedback.Feedback))
            {
                return BadRequest();
            }
            if(!db.loginRegisters.Any(u => u.Name == feedback.Name))
            {
                return NotFound();
            }
            if(feedback.Feedback.Length > 500)
            {
                return BadRequest();
            }
            if(db.feedbacks.Any(u => u.Name == feedback.Name && u.Feedback == feedback.Feedback))
            {
                return Conflict();
            }
            db.feedbacks.Add(feedback);
            await db.SaveChangesAsync();            
            return Ok();
        }
    }
}
