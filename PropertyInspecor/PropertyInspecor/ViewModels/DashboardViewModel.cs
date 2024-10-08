using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using PropertyInspecor.Models;
using PropertyInspecor.Views.Controls;

namespace PropertyInspecor.ViewModels
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
        public class Unit
        {
            public string Name { get; set; }
        }

        public class DashItem
        {
            public string Name { get; set; }
            public string Icon { get; set; }
            public string Status { get; set; }
        }

        readonly IList<Unit> source;
        Unit selectedUnit;
        private string selectedItem;
        public ObservableCollection<Unit> Units { get; private set; }
        public List<string> Items { get; private set; }
        public Unit SelectedUnit
        {
            get
            {
                return selectedUnit;
            }
            set
            {
                if (selectedUnit != value)
                {
                    selectedUnit = value;
                    OnPropertyChanged("SelectedUnit");
                }
            }
        }

        readonly IList<DashItem> sources;
        Unit selectedDashItem;
        private string selectedDashItems;
        public ObservableCollection<DashItem> DashItems { get; private set; }
        public List<string> Itemz { get; private set; }
        public Unit SelectedDashItem
        {
            get
            {
                return selectedDashItem;
            }
            set
            {
                if (selectedDashItem != value)
                {
                    selectedDashItem = value;
                    OnPropertyChanged("SelectedDashItem");
                }
            }
        }

        public string SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged("SelectedItem");
                }
            }
        }

        public DashboardViewModel()
		{
            source = new List<Unit>();
            CreateUnitCollection();
            sources = new List<DashItem>();
            CreateDashCollection();

            SelectedUnit = Units.Skip(3).FirstOrDefault();

            SelectedDashItem = Units.Skip(3).FirstOrDefault();

        }

        private void CreateUnitCollection()
        {
            for (int i = 0; i < 1; i++)
            {

                source.Add(new Unit { Name = "Menlyn Maine 37" });
                source.Add(new Unit { Name = "Menlyn Maine 125" });
                source.Add(new Unit { Name = "iQ Brooklyn 5403" });
            }

            Units = new ObservableCollection<Unit>(source);
        }

        void CreateDashCollection()
        {
            for (int i = 0; i < 1; i++)
            {

                sources.Add(new DashItem { Name = "Status" });
                sources.Add(new DashItem { Name = "Repairs" });
                sources.Add(new DashItem { Name = "Contact Owner"});
                sources.Add(new DashItem { Name = "TBD" });
            }

            DashItems = new ObservableCollection<DashItem>(sources);
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

