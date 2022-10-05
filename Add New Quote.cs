using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1._0
{
    public partial class Add_Quote : Form
    {
        private Form _mainMenu; //_name is private variable

        public Add_Quote(Form mainMenu) //CONSTRUCTOR
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void Add_Quote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var mainMenu = (MainMenu)this.Tag;
            //mainMenu.Show();
            _mainMenu.Show();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public double calculateTotals()
        {

            double basePrice = double.Parse(baseCost.Text.Substring(1));
            double sizePrice = double.Parse(sizeCost.Text.Substring(1));
            double drawerPrice = double.Parse(drawerCost.Text.Substring(1));
            double materialPrice = double.Parse(materialCost.Text.Substring(1));
            double rushPrice = double.Parse(rushCost.Text.Substring (1));

            double sumPrice = basePrice + sizePrice + drawerPrice + materialPrice + rushPrice;
            double taxPrice = sumPrice * 0.06;
            double totalPrice = sumPrice + taxPrice;
            
            sumCost.Text = "$" + sumPrice.ToString() + ".00";
            taxCost.Text = "$" + (taxPrice).ToString() + "";
            totalCost.Text = "$" + (totalPrice).ToString() + "";

            return totalPrice;
        }


        private void phone_input_Click(object sender, EventArgs e)
        {
            email_input.Checked = false;
            contactData_label.Text = "Phone Number";
        }

        private void email_input_Click(object sender, EventArgs e)
        {
            phone_input.Checked = false;
            contactData_label.Text = "Email Address";
        }

        private void rushOrder_no_Click(object sender, EventArgs e)
        {
            days_input.Text = "14";
            rushOrder_yes.Checked = false;
        }

        private void rushOrder_yes_Click(object sender, EventArgs e)
        {
            days_input.Text = "";
            rushOrder_no.Checked = false;
            days_input.Text = "3";
        }

        private void drawerCount_input_ValueChanged(object sender, EventArgs e)
        {
            drawerCost.Text = "$" + (drawerCount_input.Value * 50).ToString() + ".00";
            calculateTotals();
        }

        public decimal calculateSize()
        {
            decimal width = width_input.Value;
            decimal depth = depth_input.Value;
            decimal size = width * depth;
            if (size > 1000)
            {
                sizeCost.Text = "$" + (size - 1000) + ".00";
            }
            else
            {
                sizeCost.Text = "$0.00";
            }

            return size;
        }

        private void width_input_ValueChanged(object sender, EventArgs e)
        {
            calculateSize();
            calculateRushCost();
            calculateTotals();

        }

        private void depth_input_ValueChanged(object sender, EventArgs e)
        {
            calculateSize();
            calculateRushCost();
            calculateTotals();
        }

                
        private void material_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = material_input.Text;

            switch (material)
            {
                case "Oak":
                    materialCost.Text = "$200.00";
                    break;
                case "Laminate":
                    materialCost.Text = "$100.00";
                    break;
                case "Pine":
                    materialCost.Text = "$50.00";
                    break;
                case "Rosewood":
                    materialCost.Text = "$300.00";
                    break;
                case "Veneer":
                    materialCost.Text = "$125.00";
                    break;
                default:
                    break;
            };
            calculateTotals();
        }

        public void calculateRushCost()
        {
            if (days_input.Text == "14")
            {
                rushCost.Text = "$0.00";
                rushOrder_yes.Checked = false;
                rushOrder_no.Checked = true;

            }
            else
            {
                decimal size = calculateSize();
                string rushTime = days_input.Text;
                int multiplier = 0;
                int addative = 0;
                int basePrice = 0;
                switch (rushTime)
                {
                    case "3":
                        basePrice = 60;
                        addative = 10;
                        break;
                    case "5":
                        basePrice = 40;
                        addative = 10;
                        break;
                    case "7":
                        basePrice = 30;
                        addative = 5;
                        break;
                }
                if (size < 1000)
                {
                    multiplier = 0;
                }
                else if ((size >= 1000) && (size <= 2000))
                {
                    multiplier = 1;
                }
                else if (size > 2000)
                {
                    multiplier = 2;
                }

                rushCost.Text = "$" + (basePrice + addative * multiplier).ToString() + ".00";
                rushOrder_yes.Checked = true;
                rushOrder_no.Checked = false;
            }
        }
        private void days_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateRushCost();
            calculateTotals();
        }

    }
}