namespace Lexicon_övning3.Animal_Classes
{
    internal class Flamingo : Bird
    {
        private double _legLength;
        public Flamingo(string name, int age, double weight, string gender, int wingLength, double legLength) : base(name, age, weight, gender, wingLength)
        {
            _legLength = legLength;
        }


        public override string Stats()
        {
            return base.Stats() + $" Leglength: {_legLength}";
        }


    }
}
