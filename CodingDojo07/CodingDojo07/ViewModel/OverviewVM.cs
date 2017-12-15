using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CodingDojo07.ViewModel
{
    public class OverviewVM : ViewModelBase
    {

        //private ObservableCollection<Items> items;
        public ObservableCollection<InventoryVM> Items { get; set; }

        private InventoryVM selectedInventory;

        public InventoryVM SelectedInventory
        {
            get { return selectedInventory; }
            set { selectedInventory = value; RaisePropertyChanged(); }
        }

        private InventoryVM selectedItem;

        public InventoryVM SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; RaisePropertyChanged(); }
        }

        public OverviewVM()
        {
            Items = new ObservableCollection<InventoryVM>();
            GenerateDate();
        }

        private void GenerateDate()
        {
            Items.Add(new InventoryVM("Lego", "-" ,new BitmapImage(new Uri("../Images/Lego/download.jpg", UriKind.Relative))));
            Items.Add(new InventoryVM("Playmobil", "-" ,new BitmapImage(new Uri("../Images/PlayMobil/playmobil.jpg", UriKind.Relative))));

            Items[0].AddItem(new InventoryVM("batman", "5+", new BitmapImage(new Uri("../Images/Lego/batman.jpg", UriKind.Relative))));
            Items[0].AddItem(new InventoryVM("car", "5+", new BitmapImage(new Uri("../Images/Lego/car.jpg", UriKind.Relative))));
            Items[0].AddItem(new InventoryVM("ninja", "10+", new BitmapImage(new Uri("../Images/Lego/ninja.jpg", UriKind.Relative))));
            Items[0].AddItem(new InventoryVM("police", "2+", new BitmapImage(new Uri("../Images/Lego/police.jpg", UriKind.Relative))));
            Items[0].AddItem(new InventoryVM("shark", "2+", new BitmapImage(new Uri("../Images/Lego/shark.jpg", UriKind.Relative))));

            Items[1].AddItem(new InventoryVM("ark", "2+", new BitmapImage(new Uri("../Images/PlayMobil/ark.jpg", UriKind.Relative))));
            Items[1].AddItem(new InventoryVM("boat", "5+", new BitmapImage(new Uri("../Images/PlayMobil/boat.jpg", UriKind.Relative))));
            Items[1].AddItem(new InventoryVM("castle", "3+", new BitmapImage(new Uri("../Images/PlayMobil/castle.jpg", UriKind.Relative))));
            Items[1].AddItem(new InventoryVM("dragons", "10", new BitmapImage(new Uri("../Images/PlayMobil/dragons.jpg", UriKind.Relative))));
            Items[1].AddItem(new InventoryVM("farm", "5", new BitmapImage(new Uri("../Images/PlayMobil/farm.jpg", UriKind.Relative))));
        }
    }
}
