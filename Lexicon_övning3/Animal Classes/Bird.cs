namespace Lexicon_övning3.Animal_Classes
{
    internal class Bird : Animal
    {

        private int _wingLength;

        public Bird(string name, int age, double weight, string gender, int wingLength) : base(name, age, weight, gender)
        {
            _wingLength = wingLength;
        }

        public override string Stats()
        {
            return base.Stats() + $" Winglength: {_wingLength}";
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp");
        }
    }
}


// 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
//     attribut, i vilken klass bör vi lägga det?


//     S: I "Bird" klassen.