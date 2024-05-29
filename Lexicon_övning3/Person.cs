using System;
using System.Collections.Generic;
using System.Linq;
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
            set { age = value; }
        
        }


        public string FName
        {
            get { return fName; }
            set { fName = value; }

        }

        public string LName
        {
            get { return lName; }
            set { fName = value; }

        }
    }
}
