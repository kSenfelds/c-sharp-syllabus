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
            if (_data.ContainsKey(name))
            {
                return true;
            }
            return false;
        }

        public string GetNumber(string name)
        {
            var position = Find(name);
            if (position == false)
            {
                return null;
            }
            else
            {
                return _data[name]._number;
            }
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