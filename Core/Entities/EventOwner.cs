using System;

namespace Core.Entities
{
    public class EventOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address {  get; set; }
        public List<Event> Events { get; set; }
        public EventOwner(int id, string name, string phone, string address)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
        }
        public EventOwner() { }
    }
}