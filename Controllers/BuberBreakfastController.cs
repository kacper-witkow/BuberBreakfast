using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Models;
using BuberBreakfast.Services;

namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("/breakfasts")]
    public class BuberBreakfastController : Controller
    {
        BreakfastService _service;
        public BuberBreakfastController(BreakfastService service)
        {
            _service = service;
        }
        [HttpPost()]
        public IActionResult CreateBreakfast(Breakfast _breakfast)
        {
            _service.CreateBreakfast(_breakfast);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBreakfast(string id)
        {
            var breakfast=_service.GetBreakfast(id);
            if (breakfast==null)
                return NotFound();
            return Ok(breakfast);
        }
        [HttpPost("upsert/{id}")]
        public IActionResult UpsertBreakfast(string id, Breakfast _breakfast)
        {
            var OldBreakfast = _service.GetBreakfast(id);
            if (OldBreakfast == null)
                return NotFound();

            _service.DeleteBreakfast(id);

            var NewBreakfast = new Breakfast(id, _breakfast.Name, _breakfast.Description);
            _service.CreateBreakfast(NewBreakfast);
            return Ok();
        }
        [HttpDelete("delete/{id:int}")]
        public IActionResult DeleteBreakfast(string id)
        {
            var OldBreakfast = _service.GetBreakfast(id);
            if (OldBreakfast == null)
                return NotFound();

            _service.DeleteBreakfast(id);
            return Ok();
        }
       
    }
}

