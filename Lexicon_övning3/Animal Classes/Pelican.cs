namespace Lexicon_övning3.Animal_Classes
{
    internal class Pelican : Bird
    {
        private double _billLength;
        public Pelican(string name, int age, double weight, string gender, int wingLength, double billLength) : base(name, age, weight, gender, wingLength)
        {
            _billLength = billLength;
        }



        public override string Stats()
        {
            return base.Stats() + $" BillLength: {_billLength}";
        }
    }
}
