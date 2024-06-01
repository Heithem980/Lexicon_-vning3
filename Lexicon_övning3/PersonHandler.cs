namespace Lexicon_övning3
{
    internal class PersonHandler
    {

        public void SetAge(Person pers, int age)
        {

            pers.Age = age;

        }

        public void SetFName(Person pers, string fName)
        {

            pers.FName = fName;

        }

        public void SetLName(Person pers, string lName)
        {

            pers.LName = lName;

        }

        public void SetHeight(Person pers, double height)
        {

            pers.Height = height;

        }

        public void SetWeight(Person pers, double weight)
        {

            pers.Weight = weight;

        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)

        {
            Person person = new Person();

            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

            return person;

        }
    }
}


//test