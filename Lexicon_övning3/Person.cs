using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_övning3
{
    internal class Person
    {

        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;


        public int Age 
        {
            get { return age; } 
            set { 
                if (value > 0) {  age = value; }
                }
        
        }


        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else throw new ArgumentException("FName is required and must be between 2 - 10 characters!");

            }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }

        }


        public double Height
        {
            get { return height; }
            set { height = value; }

        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }

        }

        public Person (string fName,string lName) {
        
            
            FName = fName;
            LName = lName;
        
        }
    }
}
