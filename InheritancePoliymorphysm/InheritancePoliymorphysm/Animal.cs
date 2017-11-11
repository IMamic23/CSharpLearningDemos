using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePoliymorphysm
{
    class Animal // sealed => no inheritance
    {
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIdInfo = new AnimalIDInfo();

        public void SetAnimalIdInfo(int idNum, string owner)
        {
            animalIdInfo.IDNum = idNum;
            animalIdInfo.Owner = owner;
        }

        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIdInfo.IDNum} and is owned by {animalIdInfo.Owner}");
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal()
            : this("No Name", "No Sound")
        {

        }

        public Animal(string name)
            : this(name, "No Sound")
        {

        }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                    return true;

                return false;
            }
        }
    }
}
