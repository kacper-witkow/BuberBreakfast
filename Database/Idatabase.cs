using BuberBreakfast.Models;

namespace BuberBreakfast.Database
{
    public interface Idatabase
    {
        void InstertBreakfast(DbBreakfast breakfast);
        void DeleteBreakfast(int Id);
        Breakfast GetBreakfast(int Id);
    }
}
