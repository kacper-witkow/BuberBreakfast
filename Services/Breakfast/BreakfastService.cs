using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.Database;
using ErrorOr;
using BuberBreakfast.Services.error;

namespace BuberBreakfast.Services.breakfast
{
    public class BreakfastService : IBreakfastService
    {
        BreakfastDatabase _database;

        public BreakfastService(string ConnectionString)
        {
            _database = new BreakfastDatabase(ConnectionString);
        }
        public void CreateBreakfast(Breakfast breakfast)
        {
            _database.InstertBreakfast(new DbBreakfast(breakfast));
        }

        public void DeleteBreakfast(int id)
        {
            _database.DeleteBreakfast(id);
        }
        public ErrorOr<Breakfast> GetBreakfast(int Id)
        {
            var breakfast=_database.GetBreakfast(Id);
            if (breakfast.IsNull())
                return Errors.Breakfast.NotFound;
            return breakfast;
        }

        public void UpsertBreakfast(Breakfast request)
        {
            _database.UpsertDatabase(request);
        }
    }
}
