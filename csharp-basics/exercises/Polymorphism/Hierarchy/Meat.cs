namespace Hierarchy
{
    internal class Meat : Food
    {
        public Meat(int quantity) : base(quantity)
        {

        }

        public override string ToString()
        {
            return $"{GetType().Name} {Quantity}";
        }
    }
}