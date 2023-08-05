using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfast
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Models.Breakfast breakfast);
        BreakfastRespons GetBreakfast(Guid Id);
        BreakfastRespons UpdateBreakfast(Guid id, UpsertBreakfastRequest request);
        BreakfastRespons DeleteBreakfast(Guid id);
    }
}
