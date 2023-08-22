using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.breakfast
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        ErrorOr<Breakfast> GetBreakfast(int Id);
        void DeleteBreakfast(int id);
        void UpsertBreakfast(Breakfast breakfast);
    }
}
