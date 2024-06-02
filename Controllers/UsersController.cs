using BookingSystem.DataContext;
using BookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Controllers;

      [Route("api/[controller]")]
      [ApiController]

    public class UsersController : ControllerBase

    {
    private readonly UserContext _context;
    public UsersController(UserContext context)
    {
        _context = context;

    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers() 
    {
        return await _context.Users.ToListAsync();   
    }

    [HttpGet("{UserId}")]

    public async Task<ActionResult<User>> GetUser(int UserId)
    {
        var user= await _context.Users.FindAsync(UserId);
        
        if (user == null)
        {
            return NotFound();
        }
        return user;
    }

    /* [HttpPost]
     public async Task<ActionResult<User>> PostUser(User user)
     {

     }
    */


}

