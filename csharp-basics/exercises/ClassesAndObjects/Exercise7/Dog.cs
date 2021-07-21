using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private string _mother;
        private string _father;

        public Dog(string name, string sex, string mother = "Unknown", string father = "Unknown")
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Mother
        {
            get { return _mother; }
        }

        public string FathersName()
        {
            return _father;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            var result = otherDog.Mother == _mother ? true : false;
            return result;
        }
    }
}
