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
        public ObservableCollection<Items> Items { get; set; }

        

        public OverviewVM()
        {
            Items = new ObservableCollection<Items>();
            GenerateDate();
        }

        private void GenerateDate()
        {
            Items.Add(new Items("Lego", new BitmapImage(new Uri("../Images/Lego/download.jpg", UriKind.Relative))));
            Items.Add(new Items("Playmobil", new BitmapImage(new Uri("../Images/PlayMobil/playmobil.jpg", UriKind.Relative))));
        }
    }
}
