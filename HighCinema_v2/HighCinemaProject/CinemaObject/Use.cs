using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaObject
{
    public partial class Use
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Note { get; set; }
        public int? CustomerId { get; set; }
        public int? RoomId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}
