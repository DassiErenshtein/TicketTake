using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TicketLevel
    {
        public int Id { get; set; }
        public virtual TypePlace TypePlace { get; set; }
        public int TypePlaceId {  get; set; }
        public int Price { get; set; }
        public string Code { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public TicketLevel(int id, int price, string code, int typePlaceId)
        {
            Id = id;
            Price = price;
            Code = code;
            TypePlaceId = typePlaceId;
        }
        public TicketLevel() { }
    }
}
