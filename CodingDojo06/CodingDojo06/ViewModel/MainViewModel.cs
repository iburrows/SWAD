using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CodingDojo06.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private InventoryVM selectedInventory;
        private InventoryVM selectedItem;
        //public RelayCommand<InventoryVM> buyBtn;
        //public RelayCommand buyBtn;
        public RelayCommand<InventoryVM> buyBtn;

        public ObservableCollection<InventoryVM> Inventory { get; set; }
        public ObservableCollection<InventoryVM> Cart { get; set; }

        public InventoryVM SelectedInventory { get { return selectedInventory; } set { selectedInventory = value; RaisePropertyChanged(); }}
        public InventoryVM SelectedItem { get { return selectedItem; } set { selectedItem = value; RaisePropertyChanged(); } }

        public RelayCommand<InventoryVM> BuyBtn { get { return buyBtn; } set { buyBtn = value; RaisePropertyChanged(); } }
        //public RelayCommand BuyBtn { get { return buyBtn; } set { buyBtn = value; } }

        public MainViewModel()
        {


            Inventory = new ObservableCollection<InventoryVM>();
            Cart = new ObservableCollection<InventoryVM>();
            BuyBtn = new RelayCommand<InventoryVM>((p) =>
                {
                    Cart.Add(p);
                }
            );

            //BuyBtn = new RelayCommand(
            //    () =>
            //    {
            //        Cart.Add(new InventoryVM(selectedItem.Description, selectedItem.Image, selectedItem.AgeRecommendation));
            //    }
            //    //,
            //    //()=> 
            //    //{
            //    //    return selectedItem != null;
            //    //}
            //    );

            DemoDataGenerator();
            //CartDemoData();
        }

        private void CartDemoData()
        {
            Cart.Add(new InventoryVM("Batman", new BitmapImage(new Uri("pictures/lego/batman.jpg", UriKind.Relative)), "5+"));
            Cart.Add(new InventoryVM("Ninja", new BitmapImage(new Uri("pictures/lego/ninja.jpg", UriKind.Relative)), "3+"));
            Cart.Add(new InventoryVM("Car", new BitmapImage(new Uri("pictures/lego/car.jpg", UriKind.Relative)), "7+"));
        }   
        
        private void DemoDataGenerator()
        { 
            Inventory.Add(new InventoryVM("Lego", new BitmapImage(new Uri("pictures/lego/lego.jpg", UriKind.Relative)), "-"));
            Inventory.Add(new InventoryVM("Playmobil", new BitmapImage(new Uri("pictures/playmobil/playmobil.jpg", UriKind.Relative)), "-"));

            Inventory[0].AddItem(new InventoryVM("Batman", new BitmapImage(new Uri("pictures/lego/batman.jpg", UriKind.Relative)),"5+"));
            Inventory[0].AddItem(new InventoryVM("Car", new BitmapImage(new Uri("pictures/lego/car.jpg", UriKind.Relative)), "7+"));
            Inventory[0].AddItem(new InventoryVM("Ninja", new BitmapImage(new Uri("pictures/lego/ninja.jpg", UriKind.Relative)), "3+"));
            Inventory[0].AddItem(new InventoryVM("Policeman", new BitmapImage(new Uri("pictures/lego/police.jpg", UriKind.Relative)), "10+"));
            Inventory[0].AddItem(new InventoryVM("Shark", new BitmapImage(new Uri("pictures/lego/shark.jpg", UriKind.Relative)), "3-10"));

            Inventory[1].AddItem(new InventoryVM("Ark", new BitmapImage(new Uri("pictures/playmobil/ark.jpg", UriKind.Relative)), "5+"));
            Inventory[1].AddItem(new InventoryVM("Boat", new BitmapImage(new Uri("pictures/playmobil/boat.jpg", UriKind.Relative)), "7+"));
            Inventory[1].AddItem(new InventoryVM("Castle", new BitmapImage(new Uri("pictures/playmobil/castle.jpg", UriKind.Relative)), "3+"));
            Inventory[1].AddItem(new InventoryVM("Dragons", new BitmapImage(new Uri("pictures/playmobil/dragons.jpg", UriKind.Relative)), "8-10"));
            Inventory[1].AddItem(new InventoryVM("Farm", new BitmapImage(new Uri("pictures/playmobil/farm.jpg", UriKind.Relative)), "3-5"));


        }
    }
}