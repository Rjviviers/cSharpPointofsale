using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRGtaak
{
    abstract class ItemClass
    {
        private string prodDesc;
        private string prodName;
        private int quantity;
        public ItemClass()
        {

        }
        public ItemClass(string prodName, string prodDesc, int quantity)
        {
            this.prodName = prodName;
            this.prodDesc = prodDesc;
            this.quantity = quantity;

        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string ProdName
        {
            get { return prodName; }
            set { prodName = value; }
        }

        public string ProdDesc
        {
            get { return prodDesc; }
            set { prodDesc = value; }
        }
        abstract public double CalculatePrice();
        abstract public double Tax();

        abstract public double CalcTax();
    }
}
