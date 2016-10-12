using System.Collections.Generic;
using Zoolandia.Habitats;

namespace Zoolandia.ZoologicalParks
{
    public class Zoo
    {
        private string _name = "Zoolandia";
        public List<Habitat> habitats = new List<Habitat>();
        public string slogan()
        {
            return "Come explore your inner animal at " + _name;
        }
    }
}