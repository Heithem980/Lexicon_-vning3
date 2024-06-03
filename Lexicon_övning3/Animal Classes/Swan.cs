namespace Lexicon_övning3.Animal_Classes
{
    internal class Swan : Bird
    {

        private string _color;
        public Swan(string name, int age, double weight, string gender, int wingLength, string color) : base(name, age, weight, gender, wingLength)
        {
            _color = color;
        }



        public override void DoSound()
        {
            base.DoSound();
        }
    }
}
