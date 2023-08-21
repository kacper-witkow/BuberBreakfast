using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using BuberBreakfast.Database;
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

        public Breakfast DeleteBreakfast(int id)
        {
            throw new NotImplementedException();
        }

        public Breakfast GetBreakfast(int Id)
        {
            var breakfast=_database.GetBreakfast(Id);
            return new Breakfast(breakfast.Id, breakfast.Name, breakfast.Description, breakfast.StartDateTime, breakfast.EndDateTime, breakfast.LastModifiedDateTime, breakfast.Savory, breakfast.Sweet);
        }

        public Breakfast UpdateBreakfast(int id, UpsertBreakfastRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
