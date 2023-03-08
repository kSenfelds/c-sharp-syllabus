using System;

namespace AdApp
{
    public class Poster : Advert
    {
        private string _dimensions;
        private int _numberOfCopies;
        private int _costPerCopy;

        public Poster(int fee, string size, int copies, int costPerCopy) : base(fee)
        {
            if (size == "Small" || size == "Medium" || size == "Large")
            {
                _dimensions = size;
            }
            else
            {
                throw new ArgumentException("Size must be Small Medium or Large");
            }
            _numberOfCopies = copies;
            _costPerCopy = costPerCopy;
        }

        public new int Cost()
        {
            var totalCost = base.Cost();
            totalCost += _costPerCopy * _numberOfCopies;
            switch (_dimensions)
            {
                case "Large": totalCost *= 3; break;
                case "Medium": totalCost *= 2; break;
                default: break;
            }
            SetFee(totalCost);
            return totalCost;
        }

        public override string ToString()
        {
            return "\nPosters : Fee=" + Cost();
        }
    }
}