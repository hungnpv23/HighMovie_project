using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaObject
{
    public partial class Room
    {
        public int RoomId { get; set; }
        public bool? Status { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
