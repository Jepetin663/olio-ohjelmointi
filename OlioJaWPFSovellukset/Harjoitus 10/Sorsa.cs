using Harjoitus10;
using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Sorsa : Eläin, ICanSwim, ICanFly
    {
        public int SwimSpeed { get; set; }
        public float WingSize { get; set; }

        public Sorsa(string _name, float _wingSize, int _speed)
        {
            Name = _name;
            WingSize = _wingSize;
            SwimSpeed = _speed;
        }

        public void Fly()
        {
            Console.WriteLine("{0} lentää, siipien koko on {1}", Name, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("kwaak");
        }

        public void Swim()
        {
            Console.WriteLine("{0} ui nopeudella {1}", Name, SwimSpeed);
        }
    }
}