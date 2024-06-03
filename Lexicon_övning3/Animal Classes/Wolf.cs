namespace Lexicon_övning3.Animal_Classes
{
    internal class Wolf : Animal
    {

        private int _packSize;

        public Wolf(string name, int age, double weight, string gender, int packSize) : base(name, age, weight, gender)
        {
            _packSize = packSize;
        }

        public override string Stats()
        {
            return base.Stats() + $"Packsize: {_packSize}";
        }

        public override void DoSound()
        {
            Console.WriteLine("Howl");
        }
    }
}
