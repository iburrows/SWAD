using CodingDojo03.Commands;

using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo03.ViewModel
{
    class MainViewModel : BaseViewModel
    {

        private List<StockEntry> stock;
        public ObservableCollection<StockEntryViewModel> items = new ObservableCollection<StockEntryViewModel>();
        private CodingDojo4DataLib.Converter.Currencies selectedCurrency;
        private CodingDojo03.ViewModel.StockEntryViewModel selectedVMItem;

        private RelayCommand addBtnClickedCommand;
        private RelayCommand deleteBtnClickedCommand;
        private RelayCommand editBtnClickedCommand;
        

        //public ObservableCollection<StockEntryViewModel> Items { get; set; }
       
        //COMMANDS START-----------------------
        public RelayCommand AddBtnClickedCommand
        {
            get { return addBtnClickedCommand; }
            set { addBtnClickedCommand = value; }
        }

        public RelayCommand DeleteBtnClickedCommand
        {
            get { return deleteBtnClickedCommand; }
            set { deleteBtnClickedCommand = value; }
        }

        public RelayCommand EditBtnClickedCommand
        {
            get { return editBtnClickedCommand; }
            set { editBtnClickedCommand = value; }
        }
        //COMMANDS END*****************************

        //CURRENCY START-----------------------
        public Array Currencies
        {
            get { return Enum.GetValues(typeof(Currencies)); }
        }
        public Currencies SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                selectedCurrency = value;
                OnChange("SelectedCurrency");
                StartConversion();
            }
        }


        private void StartConversion()
        {
            foreach (var item in Items)
            {
                item.CalculateSalesPriceFromEuro(SelectedCurrency);
            }
        }
        //CURRENCY END*****************************

        public ObservableCollection<StockEntryViewModel> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }

        public StockEntryViewModel SelectedItem
        {
            get { return selectedVMItem;}
            set
            {
                selectedVMItem = value;
                OnChange("SelectedItem");
            }
        }

        public MainViewModel()
        {
            AddBtnClickedCommand = new RelayCommand(new Action(AddButtonClicked), new Func<bool>(CanExecute));
            DeleteBtnClickedCommand = new RelayCommand(new Action(DeleteButtonClicked), new Func<bool>(CanExecute));
            EditBtnClickedCommand = new RelayCommand(new Action(EditButtonClicked), new Func<bool>(CanExecute));

            selectedVMItem = new StockEntryViewModel();

            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;
            foreach (var item in manager.CurrentStock.OnStock)
            {
                Items.Add(new StockEntryViewModel(item)); //filling the viewmodel data structure
            }
        }

        private bool CanExecute()
        {
            return true;
        }

        //add button logic
        private void AddButtonClicked()
        {
            Items.Add(selectedVMItem);
        }
        //delete button logic
        private void DeleteButtonClicked()
        {
            Items.Remove(selectedVMItem);
        }
        //edit button logic
        private void EditButtonClicked()
        {
            
        }
    }
}
