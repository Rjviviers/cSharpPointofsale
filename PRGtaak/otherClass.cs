using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRGtaak
{
    class otherClass:ItemClass
    {
        private double baseprice;
        private string type;
        public otherClass() 
        {

        }
        public otherClass(string prodName, string prodDesc, int quantity,double baseprice, string type):base( prodName,  prodDesc,  quantity)
        {
            this.type = type;
            this.baseprice = baseprice;
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double BasePrice
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
            return string.Format("{0} : {1} - {2} : {3:c} ", type, ProdName, ProdDesc, CalculatePrice());
        }
    }
}
