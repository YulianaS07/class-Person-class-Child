using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaPersonklasaChild
{
    public class Person
    {
        protected string familyName;
        public string FamilyName
        {
            get => familyName;
            set
            {
                familyName = value.Trim();
                char[] _familyName = familyName.ToCharArray();
                for (int i = 0; i < _familyName.Length; i++)
                {
                    if (Char.IsLetter(_familyName[i]) == false && _familyName[i] != ' ')
                        throw new ArgumentException("Wrong name!");
                }
                _familyName[0] = Char.ToUpper(_familyName[0]);
                for (int i = 1; i < _familyName.Length; i++)
                {
                    _familyName[i] = Char.ToLower(_familyName[i]);
                }
                string tab = new string(_familyName);
                familyName = new string(_familyName);
                for (int i = 0; i < _familyName.Length; i++)
                {
                    if (_familyName[i] == ' ')
                    {
                        string[] tab1 = tab.Split("  ");
                        familyName = new string(tab1[0] + tab1[1]);
                        break;
                    }
                    else
                        continue;
                }
            }
        }

        public void modifyFamilyName(string _modifyFamilyName)
        {
            FamilyName = _modifyFamilyName;
        }

        protected string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value.Trim();
                char[] _firstName = firstName.ToCharArray();
                for (int i = 0; i < _firstName.Length; i++)
                {
                    if (Char.IsLetter(_firstName[i]) == false && _firstName[i] != ' ')
                        throw new ArgumentException("Wrong name!");
                }
                _firstName[0] = Char.ToUpper(_firstName[0]);
                for (int i = 1; i < _firstName.Length; i++)
                {
                    _firstName[i] = Char.ToLower(_firstName[i]);
                }
               firstName = new string(_firstName);
            }
        }

        public void modifyFirstName(string _modifyFirstName)
        {
            string[] t_modifyFirstName = _modifyFirstName.Trim().Split(" ");
            _modifyFirstName = new string(t_modifyFirstName[0] + t_modifyFirstName[1]);
            FirstName = _modifyFirstName;
        }


        protected int age;
        public int Age 
        {
            get => age; 
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age must be positive!");

                age = value;
            }
        }

        public void modifyAge(int _modifyAge)
        {
            Age = _modifyAge;
        }


        public Person(string familyName, string firstName, int age)
        {
            FamilyName = familyName;
            FirstName = firstName;
            Age = age;
        }

        public override string ToString()
        => $"{FirstName} {FamilyName} ({Age})";
    }
}
