using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace CodingDojo07.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVm;

        public RelayCommand OverviewBtnClickedCommand { get; set; }
        public RelayCommand MyToysBtnClickedCommand { get; set; }

        public ViewModelBase CurrentVm
        {
            get { return currentVm; }
            set { currentVm = value; RaisePropertyChanged(); }
        }
        public MainViewModel()
        {
            OverviewBtnClickedCommand = new RelayCommand(()=> { CurrentVm = SimpleIoc.Default.GetInstance<OverviewVM>(); });
                
            MyToysBtnClickedCommand = new RelayCommand(() => { CurrentVm = SimpleIoc.Default.GetInstance<MyToysVM>(); });
        }
    }
}