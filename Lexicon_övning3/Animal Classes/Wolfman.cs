using Lexicon_övning3.Interface;

namespace Lexicon_övning3.Animal_Classes
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight, string gender, int packSize) : base(name, age, weight, gender, packSize)
        {
        }

        public void Talk()
        {
            Console.WriteLine("I am a wolfman!");
        }
    }
}
