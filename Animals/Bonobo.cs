using System;

namespace Zoolandia.Animals
{
    public class Pan: Animal
    {
        public bool omnivore = true;
        public bool canClimb = true;
        public string brainSize = "large";
        public string domain = "forest";
        
        
    }
    public class paniscus: Pan
    {
        public bool canSwim = false;
        public bool canFly = false;
        public bool canWalk = true;
        public int age = 0;
        public int numOfLimbs = 4;
        public string commonName = "Bonobo";
        public string scientificName = "Pan paniscus";
        public override string eat()
        {
            string parentMessage = base.eat();
            return $"Jeremy is eating a platter full of creepy crawlies. Times are hard.";
        }
        public override string sleep()
        {
            string parentMessage = base.sleep();
            return $"{parentMessage} Do not disturb.";
        }
        public override string play()
        {
            string parentMessage = base.play();
            return $"{parentMessage} They look like a human.";
        }
        public override string speak()
        {
            string parentMessage = base.speak();
            return $"{parentMessage} Ooh ooh AHH AHH!";
        }
        public void Pan_paniscus()
        {
            this.name = "Jeremy";
        }
        public void Pan_paniscus(string args)
        {
            string name = args;
        }
        public void Pan_paniscus(int args)
        {
            this.age = args;
        }
        public void Pan_paniscus(string[] args)
        {
            this.age = Convert.ToInt16(args[0]);
            this.name = args[1];
        }
        public void Pan_paniscus(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}

