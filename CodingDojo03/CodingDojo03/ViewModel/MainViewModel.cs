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
        private CodingDojo4DataLib.StockEntry selectedItem;
        //private CodingDojo4DataLib.StockEntry selectedStock;

        //private AddCommand addBtnClickedCommand;
        private RelayCommand addBtnClickedCommand;
        private RelayCommand deleteBtnClickedCommand;
        private RelayCommand editBtnClickedCommand;
        //private DeleteCommand deleteBtnClickedCommand;

        //private StockItem newItem;

        //public AddCommand AddBtnClickedCommand
        //{
        //    get { return addBtnClickedCommand; }
        //    set { addBtnClickedCommand = value; }
        //}
        
        //Commands start-----------------------
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
        //Commands end*****************************

        //public DeleteCommand DeleteBtnClickedCommand
        //{
        //    get { return deleteBtnClickedCommand; }
        //    set
        //    {
        //        deleteBtnClickedCommand = value;
        //    }
        //}

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

        //public StockEntry SelectedStock
        //{
        //    get { return SelectedStock; }
        //    set {
        //        SelectedStock = value;
        //        OnChange("SelectedItem");
        //        DeleteButtonClicked();
        //    }
        //}

        private void StartConversion()
        {
            foreach (var item in Items)
            {
                item.CalculateSalesPriceFromEuro(SelectedCurrency);
            }
        }

        public ObservableCollection<StockEntryViewModel> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }
        public MainViewModel()
        {
            //AddBtnClickedCommand = new AddCommand(new Action(AddButtonClicked), new Func<bool>(CanExecute));
            AddBtnClickedCommand = new RelayCommand(new Action(AddButtonClicked), new Func<bool>(CanExecute));
            DeleteBtnClickedCommand = new RelayCommand(new Action(DeleteButtonClicked), new Func<bool>(CanExecute));
            EditBtnClickedCommand = new RelayCommand(new Action(EditButtonClicked), new Func<bool>(CanExecute));


            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;
            foreach (var item in manager.CurrentStock.OnStock)
            {
                Items.Add(new StockEntryViewModel(item)); //filling the viewmodel data structure

            }
        }

        private bool CanExecute()
        {
            //need to check this
            return true;
        }

        private void AddButtonClicked()
        {
                           
        }

        private void DeleteButtonClicked()
        {
            //this.stock.Remove(this.selectedStock);
        }

        private void EditButtonClicked()
        {

        }
    }
}
