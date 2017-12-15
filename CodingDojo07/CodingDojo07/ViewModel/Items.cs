using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CodingDojo07.ViewModel
{
    public class Items : ViewModelBase
    {
        public string Description { get; set; }
        //public string AgeRestriction { get; set; }
        public BitmapImage Image { get; set; }

        public Items(string description, BitmapImage image)
        {
            this.Description = description;
            //this.AgeRestriction = ageRestriction;
            this.Image = image;
        }
    }
}
