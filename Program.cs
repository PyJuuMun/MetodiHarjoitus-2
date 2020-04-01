using System;
using System.Collections.Generic;

namespace MetodiHarjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person Class objectit luotu, sisältää nimet ja iät
            Person person1 = new Person();
            person1.Name = "Mari";
            person1.Age = 16;
            person1.Hobbies.Add("jalkapallo");
            person1.Hobbies.Add("tennis");
            person1.Hobbies.Add("uinti");

            Person person2 = new Person();
            person2.Name = "Tommi";
            person2.Age = 22;
            person2.Hobbies.Add("miniatyyri-mallit");
            
            Person person3 = new Person();
            person3.Name = "Anna";
            person3.Age = 28;
            person3.Hobbies.Add("miniatyyri-mallit");
            person3.Hobbies.Add("drone-lentäminen");

            //'personX.Friend = X;' kirjoitettu tähän niin että objecti 3 on luoto ennen kuin niitä yhdistetään edellä olevalla koodilla
            person2.Friend = person3;
            person3.Friend = person2;

            person3.Greet();
            //person1.FormanGreet();
            person3.AgeIfElse18();

            Console.WriteLine(person1.Comparison());
        }
    }
}
