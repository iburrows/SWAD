using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo03.ViewModel
{
    class StockEntryViewModel : BaseViewModel
    {
        private StockEntry stockEntry;
        private double salesPriceInEuro;
        private double purchasePriceInEuro;

        public string Name
        {
            get { return stockEntry.SoftwarePackage.Name; }
            set
            {
                stockEntry.SoftwarePackage.Name = value;
                OnChange("Name");
            }
        }

        public string GroupName
        {
            get { return stockEntry.SoftwarePackage.Category.Name; }
            set
            {
                stockEntry.SoftwarePackage.Category.Name = value;
                OnChange("GroupName");
            }
        }

        public double PurchasePrice
        {
            get { return stockEntry.SoftwarePackage.PurchasePrice; }
            set
            {
                stockEntry.SoftwarePackage.PurchasePrice = value;
                OnChange("PurchasePrice");
            }
        }

        public int OnStock
        {
            get { return stockEntry.Amount; }
            set
            {
                stockEntry.Amount = value;
                OnChange("OnStock");
            }
        }

        public double SalesPrice
        {
            get { return stockEntry.SoftwarePackage.SalesPrice; }
            set
            {
                stockEntry.SoftwarePackage.SalesPrice = value;
                OnChange("SalesPrice");
            }
        }
        public StockEntryViewModel(StockEntry entry)
        {
            stockEntry = entry;
            salesPriceInEuro = entry.SoftwarePackage.SalesPrice;
            purchasePriceInEuro = entry.SoftwarePackage.PurchasePrice;
        }

        //empty constructor needed to create the empty row
        public StockEntryViewModel()
        {
            stockEntry = new StockEntry();
            stockEntry.Amount = 0;
            stockEntry.SoftwarePackage = new Software("New Software");
            stockEntry.SoftwarePackage.Name = "Enter Name";
            stockEntry.SoftwarePackage.PurchasePrice = 0;
            stockEntry.SoftwarePackage.SalesPrice = 0;
            stockEntry.SoftwarePackage.Category = new Group();
            stockEntry.SoftwarePackage.Category.Name = "Enter Name";
            
        }

        public void CalculateSalesPriceFromEuro(Currencies currency)
        {
            this.SalesPrice = CurrencyConverter.ConvertFromEuroTo(currency, salesPriceInEuro);
            this.PurchasePrice = CurrencyConverter.ConvertFromEuroTo(currency, purchasePriceInEuro);
        }

    }
}
