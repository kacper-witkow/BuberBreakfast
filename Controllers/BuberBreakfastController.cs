using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Models;
using BuberBreakfast.Services;

namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuberBreakfastController : Controller
    {
        BreakfastService _service;
        public BuberBreakfastController(BreakfastService service)
        {
            _service = service;
        }
        [HttpPost("/breakfasts")]
        public IActionResult CreateBreakfast([FromBody] Breakfast _breakfast)
        {
            return Ok();
        }
        [HttpGet("/breakfasts/{id}")]
        public IActionResult GetBreakfast(string id)
        {
            var breakfast=_service.GetBreakfast(id);
            if (breakfast==null)
                return NotFound();
            return Ok(breakfast);
        }
        [HttpPost("/breakfasts/upsert/{id}")]
        public IActionResult UpsertBreakfast(string id, [FromBody] Breakfast _breakfast)
        {
            var OldBreakfast = _service.GetBreakfast(id);
            _service.DeleteBreakfast(id);
            var NewBreakfast = new Breakfast()
            {
                Id = id,
                Name = _breakfast.Name,
                Description = _breakfast.Description,
            };
            _service.CreateBreakfast(NewBreakfast);
            return Ok();
        }
        [HttpDelete("/breakfasts/delete/{id:int}")]
        public IActionResult DeleteBreakfast(string id)
        {
             _service.DeleteBreakfast(id);
            return Ok();
        }
       
    }
}

