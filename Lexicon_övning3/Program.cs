namespace Lexicon_övning3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            try
            {
                Person person = new Person("David", "Andersson")
                {


                    //Age = -30,
                    Height = 180.5f,
                    Weight = 75.3
                };
                person.Age = 22;

                Console.WriteLine($"First Name: {person.FName}, Last Name: {person.LName}, Age: {person.Age} Height: {person.Height}, Weight: {person.Weight}");


            }
            catch (Exception ex)
            {

                Console.WriteLine($"One or more inputs are wrong! {ex}");
            }




            PersonHandler pers = new PersonHandler();

            int age = 22;

            //PersonHandler.SetAge(pers, age);





        }
    }
}
