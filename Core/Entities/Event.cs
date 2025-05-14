using System;

namespace Core.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public int HallId { get; set; }
        public string Description { get; set; }
        public List<EventOwner> EventOwner { get; set; }
        public virtual List<EventShow> EventShows { get; set; }
        public virtual Hall Hall { get; set; }

        public Event(int id, int hallId, string description)
        {
            Id = id;
            HallId = hallId;
            Description = description;
        }
        public Event() { }
    }
}