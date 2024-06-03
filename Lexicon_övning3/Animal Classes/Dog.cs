namespace Lexicon_övning3.Animal_Classes
{
    internal class Dog : Animal
    {

        private string _Breed;

        public Dog(string name, int age, double weight, string gender, string breed) : base(name, age, weight, gender)
        {
            _Breed = breed;
        }

        public override string Stats()
        {
            return base.Stats() + $"Breed: {_Breed}";
        }

        public override void DoSound()
        {
            Console.WriteLine("woof");
        }
    }
}

