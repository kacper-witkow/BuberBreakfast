using BuberBreakfast.Models;

namespace BuberBreakfast.Database
{
    public interface Idatabase
    {
        void InstertBreakfast(DbBreakfast breakfast);
        void DeleteBreakfast(int Id);
        void GetBreakfast(int Id);
    }
}
