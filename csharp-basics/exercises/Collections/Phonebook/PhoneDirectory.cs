using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, PhoneEntry> _data;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, PhoneEntry>();
        }

        private bool Find(string name)
        {
            return _data.ContainsKey(name);
        }

        public string GetNumber(string name)
        {
            var hasPosition = Find(name);

            return hasPosition ? _data[name]._number : null;
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }
            if (Find(name))
            {
                _data[name]._number = number;
            }
            else
            {
                _data.Add(name, new PhoneEntry { _name = name, _number = number });
            }
        }
    }
}