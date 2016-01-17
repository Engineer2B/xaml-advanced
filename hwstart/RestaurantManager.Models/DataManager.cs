using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    public abstract class DataManager : INotifyPropertyChanged
    {
        private RestaurantContext repository;

        protected RestaurantContext Repository
        {
            get { return repository; }
            private set
            {
                repository = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public DataManager()
        {
            LoadData();
        }

        private async void LoadData()
        {
            this.Repository = new RestaurantContext();
            await this.Repository.InitializeContextAsync();
            OnDataLoaded();
        }

        protected abstract void OnDataLoaded();

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
