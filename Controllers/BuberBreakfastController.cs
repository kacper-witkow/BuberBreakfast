using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Models;
using BuberBreakfast.Services.breakfast;
using ErrorOr;

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
                1,
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
        [HttpGet("{id:int}")]
        public IActionResult GetBreakfast(int id)
        {
            ErrorOr<Breakfast> breakfast= _breakfastService.GetBreakfast(id);

            return Ok(breakfast);
        }
        [HttpPut("{id:int}")]
        public IActionResult UpsertBreakfast(int id,UpsertBreakfastRequest request)
        {
            var Breakfast = new Breakfast(
                id,
                request.Name,
                request.Description,
                request.StartDatetime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet
            );
            _breakfastService.UpsertBreakfast(Breakfast);
            return Ok(request);
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteBreakfast(int id)
        {
            _breakfastService.DeleteBreakfast(id);
            return Ok(id);
        }
    }
}

