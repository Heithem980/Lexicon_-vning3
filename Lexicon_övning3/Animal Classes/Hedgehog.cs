namespace Lexicon_övning3.Animal_Classes
{
    internal class Hedgehog : Animal
    {

        private int _NrOfSpikes;

        public Hedgehog(string name, int age, double weight, string gender, int nrOfSpikes) : base(name, age, weight, gender)
        {
            _NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("snuffle");
        }
    }
}

