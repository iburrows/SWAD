using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo03.ViewModel
{
    class StockItem
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public double SalesPrice { get; set; }
        public double PurchasePrice { get; set; }
        public int OnStock { get; set; }

        public StockItem(string name, string group, double salesPrice, double purchasePrice, int onStock)
        {
            Name = name;
            Group = group;
            SalesPrice = salesPrice;
            PurchasePrice = purchasePrice;
            OnStock = onStock;
        }
    }
}
