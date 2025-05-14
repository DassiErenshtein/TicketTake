using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Hall
    {
        public int Id { get; set; }
        public int NumLevels { get; set; }
        public string NameOwner { get; set; }
        public string NumberOwner { get; set; }
        public virtual List<PlaceInHall> Places { get; set; }
        public virtual List<TypePlace> Types { get; set; }


        public Hall(int id, int numLevels, List<TypePlace> types, string nameOwner, string numberOwner, List<PlaceInHall> places)
        {
            Id = id;
            NumLevels = numLevels;
            Types = types;
            NameOwner = nameOwner;
            NumberOwner = numberOwner;
            Places = places;
        }
        public Hall() { }
    }
}