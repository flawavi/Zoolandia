using System;

namespace Zoolandia.Animals
{
    public class Animal: IAnimal
    {
        private string _name {get;set;}
        private string _food {get;set;}
        public int GestationDays {get;set;}
        public string CoatColor {get;set;}
        public bool IsDomesticated {get;set;}
        public Species species {get;set;}
        
        public int height {get;set;}
        public int weight {get;set;}
        public DateTime birthDate {get;set;}
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
        public string food
        {
            get
            {
                return _food;
            }
            set
            {
                if (value != "")
                {
                    _food = value;
                }
            }
        }
        public string GetRange(string name)
        {
            return $"My name is {name}";
        }
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