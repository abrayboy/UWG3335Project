using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team_Project.api.model
{
    [Serializable]
    public sealed class ApparelItem
    {

        public string Name { get; set; }

        public float Price { get; set; }

        public ApparelItem(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            var item = (ApparelItem)obj;

            return this.Name.Equals(item.Name) && this.Price.Equals(item.Price);
        }


    }
}