using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team_Project.api.model
{
    public class Cart
    {

        public IList<ApparelItem> ApparelItems { get; }

        public float Total
        {
            get
            {
                return ApparelItems.Sum(item => item.Price);
            }
        }

        public Cart()
        {
            this.ApparelItems = new List<ApparelItem>();
        }

        public void Add(ApparelItem apparelItem)
        {
            this.ApparelItems.Add(apparelItem);
        }

        public void Remove(ApparelItem apparelItem)
        {
            this.ApparelItems.Remove(apparelItem);
        }

        public ApparelItem Get(int index)
        {
            return this.ApparelItems[index];
        }

        public bool Contains(ApparelItem item)
        {
            return this.ApparelItems.Contains(item);
        }
    }
}