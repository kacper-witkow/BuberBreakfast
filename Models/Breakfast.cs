﻿namespace BuberBreakfast.Models
{
    public class Breakfast
    {
        public Guid Id { get;   }
        public string Name { get;   }
        public string Description { get;   }
        public DateTime StartDateTime { get;   }
        public DateTime EndDateTime { get;  }
        public DateTime LastModifiedDateTime { get;  }
        public List<string> Savory { get;   }
        public List<string> Sweet { get;   }

        public Breakfast(Guid id, string _Name, string _Description, DateTime _StartDateTime, DateTime _EndDateTime, DateTime _LastModifiedDatetime, List<string> _Savory,List<string> _Sweet)

        {
            Id = id;
            Name = _Name;
            Description = _Description;
            StartDateTime = _StartDateTime;
            EndDateTime = _EndDateTime;
            LastModifiedDateTime = _LastModifiedDatetime;
            Savory = _Savory;
            Sweet = _Sweet;
        }
    }
}