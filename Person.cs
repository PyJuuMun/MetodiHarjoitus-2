using System;
using System.Collections.Generic;
using System.Text;

namespace MetodiHarjoitus_2
{
    public class Person
    {
        public string Name;
        public int Age;
        public Person Friend;
        public List<string> Hobbies = new List<string>();


        public Person()
        {

        }

        public void Greet()
        {
            Console.WriteLine("Terve, miten menee");
        }

        public void FormanGreet()
        {
            Console.WriteLine($"Hei, olen {Name} ja olen {Age} vuotta vanha.");
        }

        public bool AgeIfElse18()
        {
            if (Age >= 18)
            {
                FormanGreet();
                Console.WriteLine("Olen täysi-ikäinen.");
                return true;
            }

            else
            {
                FormanGreet();
                Console.WriteLine("Olen alaikäinen.");
                return false;
            }
        }

        public void GrowingOld(int years)
        {
            Age += years;
        }

        public string Comparison()
        {
            if (Friend == null)
            {
                
                return $"{Name}, olet yksinäinen.";
            }

            else if (Age > Friend.Age)
            {
                return $"{Name}, olet vanhempi kuin {Friend.Name}.";
            }

            else
            {
                return $"{Friend.Name} on vanhempi kuin sinä, {Name}.";
            }
            
        }
    }

}
