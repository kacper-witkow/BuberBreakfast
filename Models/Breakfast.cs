using System.ComponentModel.DataAnnotations;

namespace BuberBreakfast.Models
{
    public class Breakfast
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
        public List<string>? Savory { get; set; }

        public Breakfast(string _Id, string _Name, string _Description, DateTime _StartDateTime, DateTime _EndDateTime, DateTime _LastModifiedDatetime, List<string> _Savory,List<string> _Sweet)
        {
            Id = _Id;
            Name = _Name;
            Description = _Description;
            StartDateTime = _StartDateTime;
            EndDateTime = _EndDateTime;
            LastModifiedDateTime = DateTime.Now;
            Savory = _Savory;
        }

        public Breakfast()
        {
        }
        public Breakfast(string Id)
        {
            this.Id = Id;
            LastModifiedDateTime = DateTime.Now;
        }
    }
}
