using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.Database;
namespace BuberBreakfast.Services.breakfast
{
    public class BreakfastService : IBreakfastService
    {
        BreakfastDatabase _database;

        BreakfastService(string ConnectionString)
        {
            _database = new BreakfastDatabase(ConnectionString);
        }
        public void CreateBreakfast(Breakfast breakfast)
        {
            _database.InstertBreakfast(new DbBreakfast(breakfast));
        }

        public BreakfastRespons DeleteBreakfast(Guid id)
        {
            throw new NotImplementedException();
        }

        public BreakfastRespons GetBreakfast(Guid Id)
        {
            throw new NotImplementedException();
        }

        public BreakfastRespons UpdateBreakfast(Guid id, UpsertBreakfastRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
