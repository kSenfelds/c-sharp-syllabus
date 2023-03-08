using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> campaign;

        public Campaign()
        {
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a)
        {
            campaign.Add(a);
        }

        public int GetCost()
        {
            return campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            var result = "";
            campaign.ForEach(item => result += item.ToString());
            return "Advert Campaign" + result + "\nTotal Cost = " + GetCost();
        }
    }
}