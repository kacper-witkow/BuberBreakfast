using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Models;
using BuberBreakfast.Services.breakfast;

namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuberBreakfastController : Controller
    {
        private readonly IBreakfastService _breakfastService;

        public BuberBreakfastController(IBreakfastService breakfastService)
        {
            this._breakfastService = breakfastService;
        }

        [HttpPost()]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            var Breakfast = new Breakfast(
                request.Name,
                request.Description,
                request.StartDatetime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet
            );

            _breakfastService.CreateBreakfast(Breakfast);

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
                actionName: nameof(GetBreakfast),
                routeValues: new {id = Breakfast.Id},
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

