using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRGtaak
{
    public partial class Standard : Form
    {
        #region Declairation of Objects and lists
        public static string setvalue = "";
        List<drink> drinkList = new List<drink>();
        List<food> foodList = new List<food>();
        List<otherClass> otherlist = new List<otherClass>();
        List<ItemClass> dis = new List<ItemClass>();
        BindingSource drinkS = new BindingSource();
        BindingSource foodS = new BindingSource();
        BindingSource otherS = new BindingSource();
        BindingSource cart = new BindingSource();
        double total = 0,tax = 0 ;

        #endregion

        #region Population of listboxes
        public Standard()
        {
            InitializeComponent();
            populateListItems();
            cart.DataSource = dis;
            lstCart.DataSource = cart;
        }

        public void populateListItems()
        {
           
            List<string> rawData = new List<string>();
            string[] splitter;
            FileHandler fa = new FileHandler();
            rawData = fa.ReadData("data.txt");
            foreach (var item in rawData)
            {
                splitter = item.Split(',');
                if (splitter[1] == "Drink")
                {
                    drinkList.Add(new drink(splitter[2],splitter[4] ,Convert.ToInt32(splitter[6]), Convert.ToDouble(splitter[5]), splitter[3]));
                }
                else if (splitter[1] == "Food")
                {
                    foodList.Add(new food(splitter[2], splitter[4], Convert.ToInt32(splitter[6]), Convert.ToDouble(splitter[5]), splitter[3]));
                }
                else if (splitter[1] == "Other")
                {
                    otherlist.Add(new otherClass(splitter[2], splitter[4], Convert.ToInt32(splitter[6]), Convert.ToDouble(splitter[5]), splitter[3]));
                }
                else
                {

                }
            }

            drinkS.DataSource = drinkList;
            foodS.DataSource = foodList;
            otherS.DataSource = otherlist;
            lstDrink.DataSource = drinkS ;
            lstFood.DataSource = foodS;
            lstOther.DataSource = otherS;
            



        }
        #endregion

        #region depricated code
        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Standard_Load(object sender, EventArgs e)
        {
           
        }

        private void ckOther_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckFood_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckDrink_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckAll_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Textbox Value changes
        private void lstFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDesc.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtType.DataBindings.Clear();
            txtmax.DataBindings.Clear();
            txtDesc.DataBindings.Add("Text", foodS, "ProdDesc");
            txtName.DataBindings.Add("Text", foodS, "ProdName");
            txtPrice.DataBindings.Add("Text", foodS, "BasePrice");
            txtmax.DataBindings.Add("Text", foodS, "Quantity");
            txtType.DataBindings.Add("Text", foodS, "FoodType");
            nmQuantity.Value = 1;
        }

        private void lstDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDesc.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtType.DataBindings.Clear();
            txtmax.DataBindings.Clear();
            txtDesc.DataBindings.Add("Text", drinkS, "ProdDesc");
            txtName.DataBindings.Add("Text", drinkS, "ProdName");
            txtPrice.DataBindings.Add("Text", drinkS, "BasePrice");
            txtmax.DataBindings.Add("Text", drinkS, "Quantity");
            txtType.DataBindings.Add("Text", drinkS, "DrinkType");
            nmQuantity.Value = 1;
        }

        private void lstOther_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDesc.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtType.DataBindings.Clear();
            txtmax.DataBindings.Clear();
            txtDesc.DataBindings.Add("Text", otherS, "ProdDesc");
            txtName.DataBindings.Add("Text", otherS, "ProdName");
            txtPrice.DataBindings.Add("Text", otherS, "BasePrice");
            txtmax.DataBindings.Add("Text", otherS, "Quantity");
            txtType.DataBindings.Add("Text", otherS, "Type");
            nmQuantity.Value = 1;
        }
        #endregion

        #region Cart Services 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "" && txtmax.Text == "" && txtName.Text == "" && txtPrice.Text == null && txtType.Text == "")
            {
                MessageBox.Show("please select an item");
            }
            else
            {


                if (tball.SelectedTab == tball.TabPages["tabDrink"])
                {
                    drink newitem = new drink(txtName.Text, txtDesc.Text, Convert.ToInt32(nmQuantity.Value), double.Parse(txtPrice.Text), txtType.Text);
                    dis.Add(newitem);
                    total += newitem.CalculatePrice();
                    txtTot.Text = total.ToString("c");
                    tax += newitem.CalcTax();
                    txtTax.Text = tax.ToString("c");
                    cart.ResetBindings(false);
                }
                else if (tball.SelectedTab == tball.TabPages["tabFood"])
                {
                    food newitem = new food(txtName.Text, txtDesc.Text, Convert.ToInt32(nmQuantity.Value), double.Parse(txtPrice.Text), txtType.Text);
                    dis.Add(newitem);
                    total += newitem.CalculatePrice();
                    txtTot.Text = total.ToString("c");
                    tax += newitem.CalcTax();
                    txtTax.Text = tax.ToString("c");
                    cart.ResetBindings(false);
                }
                else if (tball.SelectedTab == tball.TabPages["tabOther"])
                {
                    otherClass newitem = new otherClass(txtName.Text, txtDesc.Text, Convert.ToInt32(nmQuantity.Value), double.Parse(txtPrice.Text), txtType.Text);
                    dis.Add(newitem);
                    total += newitem.CalculatePrice();
                    txtTot.Text = total.ToString("c");
                    tax += newitem.CalcTax();
                    txtTax.Text = tax.ToString("c");
                    cart.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("cant add item");
                }
                
                //lstCart.Items.Clear();
                

            }
        }
        #endregion

        //Validation of Quantity
        private void nmQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nmQuantity.Value) > int.Parse(txtmax.Text))
            {
                MessageBox.Show("cant be more than max stock quantity");
                nmQuantity.Value = 1;
            }
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            var name = DateTime.Now.ToString();
            string newname =  name.Replace('/','-');
            string final = newname.Replace(':', '-');
            final = final + ".txt";
            FileHandler fa = new FileHandler();
            fa.WriteData(dis, final, false);
            setvalue = txtTot.Text;
            Slip s = new Slip();
            s.Show();
            this.Hide();
        }

        
    }
}
