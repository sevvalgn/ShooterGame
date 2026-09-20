using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShooterGameAPI.Module;
using ShooterGameAPI.Data;

namespace ShooterGameAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginRegisterController: ControllerBase
    {
        public readonly GameDbContext db;

        public LoginRegisterController(GameDbContext _db)
        {
            db = _db;
        }

        [HttpPost("login")]
        public ActionResult Login(LoginRegister user)
        {
            if(user == null)
            {
                return BadRequest();
            }
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Password))
            {
                return BadRequest();
            }

            var accountexist = db.loginRegisters.FirstOrDefault(a => a.Name == user.Name);
            if (accountexist == null)
            {
                return NotFound();
            }

            bool verify = BCrypt.Net.BCrypt.Verify(user.Password, accountexist.Password);
            if (!verify)
            {
                return Unauthorized();
            }
            return Ok();
        }

        [HttpPost("register")]
        public async Task<ActionResult<LoginRegister>> Register(LoginRegister user)
        {
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Password))
            {
                return BadRequest();
            }

            if (user == null)
            {
                return BadRequest();
            }

            var accountexist = db.loginRegisters.FirstOrDefault(a => a.Name == user.Name);
            if(accountexist !=null)
            {
                return Conflict();
            }

            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            db.loginRegisters.Add(user);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
