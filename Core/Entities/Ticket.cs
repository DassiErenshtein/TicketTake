using System;

namespace Core.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public virtual TicketLevel TicketLevel { get; set; }
        public int TicketLevelId { get; set; }
        public string PersonalDetails { get; set; }
        public int EventShowId { get; set; }
        public virtual EventShow EventShow { get; set; }
        public int PlaceInHallId { get; set; }
        public virtual PlaceInHall PlaceInHall { get; set; }
        public string PaymentDetails { get; set; }
        public Ticket(int id, string personalDetails, int eventShowId, int placeInHallId, string paymentDetails)
        {
            Id = id;
            PersonalDetails = personalDetails;
            EventShowId = eventShowId;
            PlaceInHallId = placeInHallId;
            PaymentDetails = paymentDetails;
        }
        public Ticket() { }
    }
}