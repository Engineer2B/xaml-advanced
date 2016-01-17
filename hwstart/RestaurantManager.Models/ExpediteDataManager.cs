using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            OrderItems = base.Repository.Orders;
        }

        private List<Order> orderItems;

        public List<Order> OrderItems
        {
            get { return this.orderItems; }
            private set
            {
                if (this.orderItems == value) return;
                this.orderItems = value;
                OnPropertyChanged();

            }
        }
    }
}
