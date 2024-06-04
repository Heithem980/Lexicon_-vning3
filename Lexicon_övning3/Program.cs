using Lexicon_övning3.Animal_Classes;
using Lexicon_övning3.Interface;

namespace Lexicon_övning3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3.1 Inkapsling

            try
            {
                /*
                Person person = new Person()
                {
                    FName = "Daniel",
                    LName = "Andersson",
                    Age = 30,
                    Height = 180.5f,
                    Weight = 75.3
                };

                */

                PersonHandler handler = new PersonHandler();



                Person person = handler.CreatePerson(44, "John", "Cena", 180, 80);

                Person person2 = handler.CreatePerson(100, "David", "Andersson", 186, 50);

                handler.SetFName(person, "Randy");


                Console.WriteLine($"First Name: {person.FName}, Last Name: {person.LName}, Age: {person.Age} Height: {person.Height} cm, Weight: {person.Weight} kg");


            }
            catch (Exception ex)
            {

                Console.WriteLine($"One or more inputs are wrong! {ex}");
            }




            // 3.2 Polymorfism 

            List<UserError> list = new List<UserError>();


            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();

            list.Add(numericInputError);
            list.Add(textInputError);

            foreach (UserError error in list)
            {
                string errorMessage = error.UEMessage();
                Console.WriteLine(errorMessage);
            }




            // 3.4 Mer Polymorfism


            List<Animal> animals = new List<Animal>();

            Bird bird = new Bird("Derek", 2, 1, "male", 20);

            Wolf Wolf = new Wolf("roger", 9, 30, "male", 5);

            Dog dog = new Dog("snoopy", 13, 25, "male", "Bulldog");

            Wolfman wolfman = new Wolfman("Leonard", 47, 110, "male", 3);

            Flamingo flamingo = new Flamingo("flam", 11, 1, "Female", 60, 50);

            animals.Add(bird);
            animals.Add(Wolf);
            animals.Add(dog);
            animals.Add(wolfman);
            animals.Add(flamingo);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();

                if (animal is IPerson person) { person.Talk(); }
            }




            // 9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?

            //    S: Eftersom häst har inget arv från Hundar.


            // 10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?

            //     S: Animal.


            // 13. F: Förklara vad det är som händer.

            //     S: När Stats() metoden anropas på objektet i listan "Animal", används polymorfism för att
            //     anropa den specifika versionen av Stats(). 

            // 17. F: Varför inte?

            //     S: Metoden finns inte på bas klassen 'Animal'.  


            foreach (Animal animal in animals)
            {
                if (animal is Dog dogy)
                {
                    Console.WriteLine(dogy.Stats());
                    Console.WriteLine(dogy.Sit());
                }
            }
        }
    }
}
