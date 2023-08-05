using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Models;
namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuberBreakfastController : Controller
    {
        [HttpPost()]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            var Breakfast = new Breakfast(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDatetime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet
            );
            // 
            var respons = new BreakfastRespons(
                Breakfast.Id,
                Breakfast.Name,
                Breakfast.Description,
                Breakfast.StartDateTime,
                Breakfast.EndDateTime,
                Breakfast.LastModifiedDateTime,
                Breakfast.Savory,
                Breakfast.Sweet
            );
            return CreatedAtAction(
                respons);
        }
        [HttpGet("{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            return Ok(id);
        }
        [HttpPut("{id:guid}")]
        public IActionResult UpsertBreakfast(Guid iid,UpsertBreakfastRequest request)
        {
            return Ok(request);
        }
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok(id);
        }
    }
}

