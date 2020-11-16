using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRGtaak
{
    class drink:ItemClass
    {
        private double baseprice;
        private string drinktype;
        public drink()
        {

        }
        public drink(string prodName, string prodDesc, int quantity, double baseprice, string drinktype) : base(prodName, prodDesc, quantity)
        {
            this.baseprice = baseprice;
            this.drinktype = drinktype;
        }
        public string DrinkType
        {
            get { return drinktype; }
            set { drinktype = value; }
        }

        public double Baseprice
        {
            get { return baseprice; }
            set { baseprice = value; }
        }
        public override double CalculatePrice()
        {
            return Tax() * this.Quantity;
        }
        public override double Tax()
        {
            return this.baseprice * 1.14;
        }
        public override double CalcTax()
        {
            return this.baseprice * 0.14;
        }
        public override string ToString()
        {
            return string.Format("{0} : {1} - {2} : {3:c} ", drinktype, ProdName, ProdDesc , CalculatePrice());
        }
    }
}
