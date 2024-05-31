namespace Lexicon_övning3
{
    internal class PersonHandler
    {

        public void SetAge(Person pers, int age)
        {

            pers.Age = age;

        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)

        {
            Person person = new Person();

            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

        }
    }
}


//test