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
    public class InventoryVM : ViewModelBase
    {
        public string Description { get; set; }
        public string AgeRestriction { get; set; }
        public BitmapImage Image { get; set; }
        public ObservableCollection<InventoryVM> Items { get; set; }

        public InventoryVM(string description, string ageRestriction, BitmapImage image)
        {
            this.Description = description;
            this.AgeRestriction = ageRestriction;
            this.Image = image;
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
