using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaObject
{
    public partial class Category
    {
        public Category()
        {
            Rooms = new HashSet<Room>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? NumberOfSeat { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
