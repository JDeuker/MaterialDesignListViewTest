using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MaterialDesignListViewTest
{
    class MainWindowViewModel
    {
        private ObservableCollection<DataViewModel> Data { get; set; }

        public ICollectionView DataView { get; private set; }

        public MainWindowViewModel()
        {
            this.Data = new ObservableCollection<DataViewModel>();
            this.DataView = CollectionViewSource.GetDefaultView(this.Data);
            this.DataView.SortDescriptions.Clear();
            this.DataView.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Descending));
            this.DataView.GroupDescriptions.Clear();
            this.DataView.GroupDescriptions.Add(new PropertyGroupDescription("GroupName"));

            InitTestData();
        }

        private void InitTestData()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    this.Data.Add(new DataViewModel($"Name{j}", $"Group{i}"));
                }
            }
        }
    }
}
