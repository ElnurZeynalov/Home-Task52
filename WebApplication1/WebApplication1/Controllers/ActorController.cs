using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using WebApplication1.DAL;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private AppDbContext _context { get;}
        public ActorController(AppDbContext context)
        {
            _context = context ;
        }
        [HttpGet("")]
        public IActionResult All()
        {
            return Ok(_context.Actors);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Actor actor = _context.Actors.Where(a=>a.Id == id).SingleOrDefault();
            if (actor == null) return StatusCode(404);
            return Ok(actor);
        }
        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            if (actor == null) return BadRequest();
            _context.Actors.Add(actor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
