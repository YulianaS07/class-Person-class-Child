using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaPersonklasaChild
{
    public class Child : Person
    {
        public Person Mother { get; private set; }
        public Person Father { get; private set; }
        public Child(string familyName, string firstName, int age, Person mother = null, Person father = null) :
            base(familyName, firstName, age)
        {
            Mother = mother;
            Father = father;
            if (age > 15)
                throw new ArgumentException("Child’s age must be less than 15!");
        }

        public new void modifyFirstName(string _modifyFirstName) => base.FirstName = _modifyFirstName;
        public new void modifyAge(int _modifyAge)
        {
            if (_modifyAge > 15)
                throw new ArgumentException("Child’s age must be less than 15!");
            base.Age = _modifyAge;
        }

        public override string ToString()
        {
            string wynik = base.ToString();
            wynik += ($"\nmother: {(Mother == null ? "No data" : Mother.ToString())}");
            wynik += ($"\nfather: {(Father == null ? "No data" : Father.ToString())}");
            return wynik;
        }
    }
}
