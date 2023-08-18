using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.breakfast
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        BreakfastRespons GetBreakfast(int Id);
        BreakfastRespons UpdateBreakfast(int id, UpsertBreakfastRequest request);
        BreakfastRespons DeleteBreakfast(int id);
    }
}
