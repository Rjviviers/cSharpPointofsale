using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRGtaak
{
    class food:ItemClass
    {
        private double basePrice;
        private string foodtype;

        public food()
        {

        }
        public food(string prodName, string prodDesc, int quantity, double basePrice, string foodtype) : base( prodName,  prodDesc,  quantity)
        {
            this.basePrice = basePrice;
            this.foodtype = foodtype;

        }
        public string FoodType
        {
            get { return foodtype; }
            set { foodtype = value; }
        }

        public double BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }
        public override double CalculatePrice()
        {
            return Tax() * this.Quantity;
        }
        public override double Tax()
        {
            return this.basePrice * 1.14;
        }

            public override double CalcTax()
        {
            return this.basePrice * 0.14;
        }
    
        public override string ToString()
        {
            return string.Format("{0} : {1} - {2} : {3:c} ", foodtype, ProdName, ProdDesc, CalculatePrice());
        }
    }
}
