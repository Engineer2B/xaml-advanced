using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        private List<MenuItem> currentlySelectedMenuItems; 

        private List<MenuItem> menuItems;
        
        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get { return this.currentlySelectedMenuItems; }
            set {
                if (this.currentlySelectedMenuItems == value) return;
                this.currentlySelectedMenuItems = value;
                this.OnPropertyChanged();
            }
        }

        public List<MenuItem> MenuItems
        {
            get { return this.menuItems; }
            set
            {
                if (this.menuItems == value) return;
                this.menuItems = value;
                this.OnPropertyChanged();
            }
        }
    }
}
