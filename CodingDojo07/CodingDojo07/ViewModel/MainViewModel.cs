using GalaSoft.MvvmLight;

namespace CodingDojo07.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentDetailView;

        public ViewModelBase CurrentDetailView
        {
            get { return currentDetailView;}
            set { currentDetailView = value; RaisePropertyChanged(); }
        }
        public MainViewModel()
        {

        }
    }
}