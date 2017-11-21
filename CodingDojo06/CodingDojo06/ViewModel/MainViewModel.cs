using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CodingDojo06.ViewModel
{

    public class MainViewModel : ViewModelBase
    {

        public ObservableCollection<ToyItemVM> LegoItems { get; set; }
        public ObservableCollection<ToyItemVM> PlaymobilItems { get; set; }
        //public ObservableCollection<PlaymobilVM> Playmobil { get; set; }
        //public ObservableCollection<LegoVM> Lego { get; set; }
        public ObservableCollection<InventoryVM> Inventory { get; set; }

        public InventoryVM SelectedInventory { get; set; }
        

        public MainViewModel()
        {
            LegoItems = new ObservableCollection<ToyItemVM>();
            PlaymobilItems = new ObservableCollection<ToyItemVM>();

            Inventory = new ObservableCollection<InventoryVM>();
            //Playmobil = new ObservableCollection<PlaymobilVM>();
            //Lego = new ObservableCollection<LegoVM>();
            DemoDataGenerator();
        }

        private void DemoDataGenerator()
        {
            LegoItems.Add(new ToyItemVM("Batman", 5, "5+", new BitmapImage(new Uri("pictures/lego/batman.jpg", UriKind.Relative))));
            LegoItems.Add(new ToyItemVM("Car", 10, "7+", new BitmapImage(new Uri("pictures/lego/car.jpg", UriKind.Relative))));
            LegoItems.Add(new ToyItemVM("Ninja", 8, "3+", new BitmapImage(new Uri("pictures/lego/ninja.jpg", UriKind.Relative))));
            LegoItems.Add(new ToyItemVM("Police Man", 20, "10+", new BitmapImage(new Uri("pictures/lego/police.jpg", UriKind.Relative))));
            LegoItems.Add(new ToyItemVM("Shark", 1, "10+", new BitmapImage(new Uri("pictures/lego/shark.jpg", UriKind.Relative))));

           PlaymobilItems.Add(new ToyItemVM("Ark", 5, "5+", new BitmapImage(new Uri("pictures/playmobil/ark.jpg", UriKind.Relative))));
           PlaymobilItems.Add(new ToyItemVM("Boat", 10, "7+", new BitmapImage(new Uri("pictures/playmobil/boat.jpg", UriKind.Relative))));
           PlaymobilItems.Add(new ToyItemVM("Castle", 8, "3+", new BitmapImage(new Uri("pictures/playmobil/castle.jpg", UriKind.Relative))));
           PlaymobilItems.Add(new ToyItemVM("Dragons", 20, "10+", new BitmapImage(new Uri("pictures/playmobil/dragons.jpg", UriKind.Relative))));
           PlaymobilItems.Add(new ToyItemVM("Farm", 1, "10+", new BitmapImage(new Uri("pictures/playmobil/farm.jpg", UriKind.Relative))));

            Inventory.Add(new InventoryVM("Lego", new BitmapImage(new Uri("pictures/lego/lego.jpg", UriKind.Relative)), LegoItems));
            Inventory.Add(new InventoryVM("Playmobil", new BitmapImage(new Uri("pictures/playmobil/playmobil.jpg", UriKind.Relative)), PlaymobilItems));
        }
    }
}