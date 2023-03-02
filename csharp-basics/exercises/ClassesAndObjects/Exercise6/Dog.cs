namespace Exercise6
{
    internal class Dog
    {
        public string _name;
        private string _sex;
        private Dog _mother;
        private Dog _father;

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
            _mother = null;
            _father = null;
        }

        public void SetParents(Dog mother, Dog father)
        {
            _mother = mother;
            _father = father;
        }

        public void SetParents(Dog mother)
        {
            _mother = mother;
            _father = null;
        }

        public string GetFathersName()
        {
            return _father == null ? "Unknown" : _father._name;
        }

        public bool HasSameMother(Dog otherDog)
        {
            return _mother == otherDog._mother;
        }
    }
}
