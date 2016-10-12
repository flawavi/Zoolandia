using Zoolandia.Animals;
using System.Collections.Generic;

namespace Zoolandia.Habitats
{
    public class Habitat
    {   
        private string _name = "";
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != "")
                {
                    _name = value;
                }
            }
        }        
        public int temperatureRange {get;set;}
        public string soilType {get;set;}
        public string lightIntensity {get;set;}
        public int moistureLevel {get;set;}
        public string type {get;set;}//polar, temperate, subtropical and tropical.
        public int capacity {get;set;}
        public double height {get;set;}
        public double width {get;set;}
        public double depth {get;set;} 
        public int getHabitatVolume(int height, int depth, int width)
        {
            return height * depth * width;
        }
        public string rain(int inchesOfRain)
        {
            return "It rained" + inchesOfRain + "inches.";
        }
        public List<Animal> inhabitants = new List<Animal>();
    }
}