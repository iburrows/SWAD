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
        public string AgeRecommendation { get; set; }
        public ObservableCollection<InventoryVM> Items { get; set; }

        public InventoryVM(string description, BitmapImage image, string recommendation)
        {
            Description = description;
            Image = image;
            AgeRecommendation = recommendation;
        }

        public void AddItem(InventoryVM item)
        {
            if (Items == null)
            {
                Items = new ObservableCollection<InventoryVM>();
            }
                Items.Add(item);
            
        }

    }
}
