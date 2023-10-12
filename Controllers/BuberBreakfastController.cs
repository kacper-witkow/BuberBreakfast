using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Models;

namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuberBreakfastController : Controller
    {
        private readonly BreakfastDb _context;

        public BuberBreakfastController(BreakfastDb _breakfastDb)
        {
            _context = _breakfastDb;
        }

        [HttpPost("/breakfasts")]
        public IActionResult CreateBreakfast([FromBody] Breakfast _breakfast)
        {

            _context.Add(_breakfast);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet("/breakfasts/{id}")]
        public IActionResult GetBreakfast(string id)
        {
            var breakfast = _context.Breakfasts.FirstOrDefault(b=>b.Id==id);
            if(breakfast==null)
                return NotFound();
            return Ok(breakfast);
        }
        [HttpPost("/breakfasts/upsert/{id}")]
        public IActionResult UpsertBreakfast(string id, [FromBody] Breakfast _breakfast)
        {
            var breakfast = _context.Breakfasts.FirstOrDefault(b => b.Id == id);
            breakfast = new Breakfast
            {
                Id = id,
            };

            return Ok();
        }
        [HttpDelete("/breakfasts/delete/{id:int}")]
        public IActionResult DeleteBreakfast(string id)
        {
            _context.Breakfasts.Remove(new Breakfast(id));
            _context.SaveChanges();
            return Ok();
        }
       
    }
}

