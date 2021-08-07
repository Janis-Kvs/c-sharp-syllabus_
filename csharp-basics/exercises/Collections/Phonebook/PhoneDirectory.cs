using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, int> _phoneDictionary;

        public PhoneDirectory() 
        {
            _phoneDictionary = new SortedDictionary<string, int>();
        }

        public int? GetNumber(string name) 
        {
            foreach (var phone in _phoneDictionary)
            {
                if (_phoneDictionary.ContainsKey(name))
                {
                    return _phoneDictionary[name];
                }
            }

            return null;
        }

        public string ListNumbers()
        {
            string list = "";
            foreach (KeyValuePair<string, int> phone in _phoneDictionary)
            {
               list+= $"Name: {phone.Key}, Phone number: {phone.Value}\n";
            }

            return list;
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            int newnumber = Convert.ToInt32(number);
            _phoneDictionary.Add(name, newnumber);
        }
    }
}