using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name {get;set;}
        public int height {get;set;}
        public int weight {get;set;}
        public DateTime birthDate {get;set;}
        public static void sleep()
        {
            Console.WriteLine("Animal is sleeping now.");
        }
        public static void eat()
        {
            Console.WriteLine("Animal is eating now.");
        }
        public static void play()
        {
            Console.WriteLine("Animal is playing now.");
        }
        public static void speak()
        {
            Console.WriteLine("Animal is speaking.");
        }
    }
}