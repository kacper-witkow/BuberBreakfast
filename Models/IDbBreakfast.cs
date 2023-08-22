namespace BuberBreakfast.Models
{
    public class DbBreakfast
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
        public string LastModifiedDateTime { get; set; }
        public string Savory { get; set; }
        public string Sweet { get; set; }

        public DbBreakfast(Breakfast breakfast)
        { 
            Id = breakfast.Id.ToString();
            Name = breakfast.Name;
            Description = breakfast.Description;
            StartDateTime = breakfast.StartDateTime?.ToString("yyyy/MM/dd HH:mm");
            EndDateTime = breakfast.EndDateTime?.ToString("yyyy/MM/dd HH:mm");
            LastModifiedDateTime = breakfast.LastModifiedDateTime?.ToString("yyyy/MM/dd HH:mm");
            //Not sure about List casting olny with ToString()!!
            Savory = breakfast.Savory.ToString();
            Sweet = breakfast.Sweet.ToString();
        }
    }
}
