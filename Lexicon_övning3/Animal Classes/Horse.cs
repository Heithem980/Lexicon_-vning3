﻿namespace Lexicon_övning3.Animal_Classes
{
    internal class Horse : Animal
    {

        private int _Speed;

        public Horse(string name, int age, double weight, string gender, int speed) : base(name, age, weight, gender)
        {
            _Speed = speed;
        }

        public override string Stats()
        {
            return base.Stats() + $"Speed: {_Speed}";
        }

        public override void DoSound()
        {
            Console.WriteLine("Mehehehhh");
        }
    }
}

