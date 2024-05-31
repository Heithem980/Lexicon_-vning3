namespace Lexicon_övning3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            try
            {
                Person person = new Person()
                {
                    FName = "Daniel",
                    LName = "Andersson",
                    Age = 30,
                    Height = 180.5f,
                    Weight = 75.3
                };

                int age = 22;

                PersonHandler handler = new PersonHandler();
                handler.SetAge(person, age);


                Console.WriteLine($"First Name: {person.FName}, Last Name: {person.LName}, Age: {person.Age} Height: {person.Height}, Weight: {person.Weight}");


            }
            catch (Exception ex)
            {

                Console.WriteLine($"One or more inputs are wrong! {ex}");
            }






            //test





        }
    }
}
