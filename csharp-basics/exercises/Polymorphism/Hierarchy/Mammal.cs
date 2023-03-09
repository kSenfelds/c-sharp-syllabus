namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string name, string animalType, double animalWeight, string livingRegion)
            : base(name, animalType, animalWeight)
        {
            _livingRegion = livingRegion;
        }

        public override string ToString()
        {
            var result = base.ToString();
            return $"{result} {_livingRegion}";
        }
    }
}