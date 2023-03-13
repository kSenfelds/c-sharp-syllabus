namespace Hierarchy
{
    public abstract class Felime : Mammal
    {
        public Felime(string name, string animalType, double animalWeight, string livingRegion)
            : base(name, animalType, animalWeight, livingRegion)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}