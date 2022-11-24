using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaObject
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public int IdMovie { get; set; }
        public string TicketType { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public virtual Movie IdMovieNavigation { get; set; }
    }
}
