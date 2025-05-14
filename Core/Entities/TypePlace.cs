using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TypePlace
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int HallId { get; set; }
        public virtual Hall Hall { get; set; }
        public virtual List<TicketLevel> TicketLevels { get; set; }
        public TypePlace(int id, int level, string name, int hallId)
        {
            Id = id;
            Level = level;
            Name = name;
            HallId = hallId;
        }
        public TypePlace() { }
    }
}
