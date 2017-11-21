using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CodingDojo06.ViewModel
{
    public class InventoryVM:ViewModelBase
    {

        public string Description { get; set; }
        public BitmapImage Image{ get; set; }
        public ObservableCollection<ToyItemVM> LegoItems { get; set; }

        public InventoryVM(string description, BitmapImage image, ObservableCollection<ToyItemVM> legoItems)
        {
            Description = description;
            Image = image;
        }
    }
}
