namespace Lexicon_övning3.Animal_Classes
{
    internal abstract class Animal
    {
        private string _name;
        private int _age;
        private double _weight;
        private string _gender;


        public abstract void DoSound();

        protected virtual string Stats()
        {
            return $"Name: {_name}, Weight: {_weight}, Age: {_age}";
        }


        public Animal(string name, int age, double weight, string gender)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _gender = gender;
        }


    }
}


//  14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?

//      S: I "Animal" klassen.