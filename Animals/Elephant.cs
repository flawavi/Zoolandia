using System;

namespace Zoolandia.Animals
{
    public class Loxodonta: Animal
    {
        public bool canFly = false;
        public bool canSwim = true;
        public bool canWalk = true;
        public bool canClimb = false;
        public string domain = "desert";
        public string brainSize = "large";
    }
    public class adaurora: Loxodonta
    {
        public string color = "grey";
        public string fightingStyle = "drunken warrior";
        public int age = 85;
        public string domain = "Africa";
        public string commonName = "African Elephant";
        public string scientificName = "Loxodonta adaurora";
        public override string eat()
        {
            string parentMessage = base.eat();
            return $"{parentMessage} Mmmm, peanuts.";
        }
        public override string sleep()
        {
            string parentMessage = base.sleep();
            return $"{parentMessage} I had this crazy dream that I was pink.";
        }
        public override string play()
        {
            string parentMessage = base.play();
            return $"{parentMessage} I bet I can chug this beer faster than you.";
        }
        public override string speak()
        {
            string parentMessage = base.speak();
            return $"{parentMessage} *Classic elephant trunk noise*";
        }
    }

}