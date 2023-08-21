namespace BuberBreakfast.Models
{
    public class Breakfast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public List<string> Savory { get; set; }
        public List<string> Sweet { get; set; }

        public Breakfast(int _Id, string _Name, string _Description, DateTime _StartDateTime, DateTime _EndDateTime, DateTime _LastModifiedDatetime, List<string> _Savory,List<string> _Sweet)
        {
            Id = _Id;
            Name = _Name;
            Description = _Description;
            StartDateTime = _StartDateTime;
            EndDateTime = _EndDateTime;
            LastModifiedDateTime = _LastModifiedDatetime;
            Savory = _Savory;
            Sweet = _Sweet;
        }

        public Breakfast()
        {
        }
    }
}
