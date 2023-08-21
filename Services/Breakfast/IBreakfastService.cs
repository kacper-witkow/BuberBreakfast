using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.breakfast
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        Breakfast GetBreakfast(int Id);
        Breakfast UpdateBreakfast(int id, UpsertBreakfastRequest request);
        Breakfast DeleteBreakfast(int id);
    }
}
