namespace Lexicon_övning3.Animal_Classes
{
    internal class Worm : Animal
    {

        private bool _isPoisonous;

        public Worm(string name, int age, double weight, string gender, bool isPoionous) : base(name, age, weight, gender)
        {
            _isPoisonous = isPoionous;
        }

        public override void DoSound()
        {

        }
    }
}
