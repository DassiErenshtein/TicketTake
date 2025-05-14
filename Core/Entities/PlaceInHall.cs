using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PlaceInHall
    {
        public int Id { get; set; }
        public int Line { get; set; }
        public int NumInLine { get; set; }

        public int HallId { get; set; }
        public virtual Hall Hall { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public PlaceInHall(int id, int line, int numInLine,int hallId)
        {
            Id = id;
            Line = line;
            NumInLine = numInLine;
            HallId = hallId;
        }

        public PlaceInHall() { }
    }
}
