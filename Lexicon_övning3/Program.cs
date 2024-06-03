﻿using Lexicon_övning3.Animal_Classes;

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

            animals.Add(bird);
            animals.Add(Wolf);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();
            }




        }
    }
}
