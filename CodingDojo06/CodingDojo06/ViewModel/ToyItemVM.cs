using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CodingDojo06.ViewModel
{
    public class ToyItemVM : ViewModelBase
    {
        public string Description { get; set; }
        public int NoOfParts { get; set; }
        public string AgeRecom { get; set; }
        public BitmapImage Image { get; set; }
        public ToyItemVM(string description, int noOfParts, string ageRecom, BitmapImage image)
        {
            Description = description;
            NoOfParts = noOfParts;
            AgeRecom = ageRecom;
            Image = image;
        }

    }
}
