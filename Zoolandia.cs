using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name {get;set;}
        public int height {get;set;}
        public int weight {get;set;}
        public DateTime birthDate {get;set;}
        public static string sleep()
        {
            return "Animal is sleeping now.";
        }
        public virtual string eat()
        {
            return "Animal is eating now.";
        }
        public static string play()
        {
            return "Animal is playing now.";
        }
        public static string speak()
        {
            return "Animal is speaking.";
        }
    }
}