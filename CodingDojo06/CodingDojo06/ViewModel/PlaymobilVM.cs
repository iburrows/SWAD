using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CodingDojo06.ViewModel
{
    public class PlaymobilVM:ViewModelBase
    {
        public string Description { get; set; }
        public BitmapImage Image{ get; set; }

        public PlaymobilVM(string description, BitmapImage image)
        {
            Description = description;
            Image = image;
        }
    }
}
