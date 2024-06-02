namespace Lexicon_övning3.Animal_Classes
{
    internal class Bird : Animal
    {

        private int _wingLength;

        public Bird(string name, int age, double weight, string gender, int wingLength) : base(name, age, weight, gender)
        {
            _wingLength = wingLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp");
        }
    }
}
