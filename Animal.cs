using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name {get;set;}
        public Species species {get;set;}
        public Genus genus {get;set;}
        public int height {get;set;}
        public int weight {get;set;}
        public DateTime birthDate {get;set;}
        public virtual string sleep()
        {
            return "Animal is sleeping now.";
        }
        public virtual string eat()
        {
            return "Animal is eating now.";
        }
        public virtual string play()
        {
            return "Animal is playing now.";
        }
        public virtual string speak()
        {
            return "Animal is speaking.";
        }
    }
}