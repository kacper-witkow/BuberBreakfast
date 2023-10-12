using BuberBreakfast.Models;

namespace BuberBreakfast.Services
{
    public class BreakfastService
    {
        BreakfastDb _context;
        public BreakfastService(BreakfastDb breakfastDb)
        {
            _context = breakfastDb;
        }
        public Breakfast GetBreakfast(string id)
        {
            var breakfast = _context.Breakfasts.FirstOrDefault(b => b.Id == id);
            return breakfast;
        }
        public void CreateBreakfast(Breakfast breakfast)
        {
            _context.Add(breakfast);
            _context.SaveChanges();
        }
        public void DeleteBreakfast(string id)
        {
            _context.Breakfasts.Remove(new Breakfast(id));
            _context.SaveChanges();
        }
    }
}
