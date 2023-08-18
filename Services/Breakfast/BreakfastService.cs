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

        public BreakfastRespons DeleteBreakfast(int id)
        {
            throw new NotImplementedException();
        }

        public BreakfastRespons GetBreakfast(int Id)
        {
            var breakfast=_database.GetBreakfast(Id);
            return new BreakfastRespons(breakfast.Id, breakfast.Name, breakfast.Description, breakfast.StartDateTime, breakfast.EndDateTime, breakfast.LastModifiedDateTime, breakfast.Savory, breakfast.Sweet);
        }

        public BreakfastRespons UpdateBreakfast(int id, UpsertBreakfastRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
