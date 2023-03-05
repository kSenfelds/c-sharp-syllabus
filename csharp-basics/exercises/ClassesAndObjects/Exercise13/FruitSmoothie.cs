namespace Exercise13
{
    internal class FruitSmoothie
    {
        private string[] _ingredients;
        private decimal _cost;

        public FruitSmoothie(string[] ingredients)
        {
            _ingredients = ingredients;
        }

        private decimal GetCost()
        {
            for (int i = 0; i < _ingredients.Length; i++)
            {
                switch (_ingredients[i])
                {
                    case "Strawberries": _cost += 1.50m; break;
                    case "Banana": _cost += 0.50m; break;
                    case "Mango": _cost += 2.50m; break;
                    case "Blueberries": _cost += 1.00m; break;
                    case "Raspberries": _cost += 1.00m; break;
                    case "Apple": _cost += 1.75m; break;
                    case "Pineapple": _cost += 3.50m; break;
                }
            }
            return _cost;
        }

        public decimal GetPrice()
        {
            GetCost();
            decimal res = _cost += (_cost * 1.5m);
            return Math.Round(res, 2);
        }

        public string GetName()
        {
            string result = string.Empty;
            Array.Sort(_ingredients);
            if (_ingredients.Length == 1)
            {
                if (_ingredients[0].EndsWith("berries"))
                {
                    return _ingredients[0].Substring(0, (_ingredients[0].Length - 7)) + "berry" + " Smoothie";
                }
                return _ingredients[0] + " Smoothie";
            }
            else
            {
                for (int i = 0; i < _ingredients.Length; i++)
                {
                    if (_ingredients[i].EndsWith("berries"))
                    {
                        result += _ingredients[i].Substring(0, (_ingredients[i].Length - 7)) + "berry" + " ";
                    }
                }
                return result + "Fusion";
            }
        }
    }
}
