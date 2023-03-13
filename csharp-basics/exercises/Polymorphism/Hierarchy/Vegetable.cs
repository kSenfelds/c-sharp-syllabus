namespace Hierarchy
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity) : base(quantity)
        {

        }

        public override string ToString()
        {
            return $"{GetType().Name} {Quantity}";
        }
    }
}