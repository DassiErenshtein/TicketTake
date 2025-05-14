using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class EventShow
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public EventShow(int id, int eventId, DateTime date, string title)
        {
            Id = id;
            EventId = eventId;
            Date = date;
            Notes = title;
        }

        public EventShow() { }
    }
}
