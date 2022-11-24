using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaObject
{
    public partial class Movie
    {
        public Movie()
        {
            Bills = new HashSet<Bill>();
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string MainCharacters { get; set; }
        public int Duration { get; set; }
        public string Genres { get; set; }
        public int GenreId { get; set; }
        public int Rating { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
