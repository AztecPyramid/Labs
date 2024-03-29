using System;
using System.Collections.Generic;
using System.Text;

namespace EditablePerson
{
    partial class Person
    {
        public Person()
        {
            this.currentState = null;
        }
        private string name;
        public string Name
        { get { return name; } set { name = value; } }
        private int age;
        public int Age
        { get { return age; } set { age = value; } }

        private PersonState currentState;

        public string Name
        {
            get { return currentState.Name; }
            set { this.currentState.Name = value; }
        }



        public override string ToString()
        {
            return String.Format("{0}, Aged {1} years", name, age);
        }
        public void Edit()
        {
            // Todo: Called when some one wishes to change the state of the Person
        }

        public void Commit()
        {
            // Todo: Called when any state changes are done..
        }
    }
}
