using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk2._0
{
    public partial class Add_Quote : Form
    {
        private Form _mainMenu; //_name is private variable
        //internal Desk deskProperties = new Desk();
        internal DeskQuote quoteProperites = new DeskQuote();

        public int quoteCountFromMain;
        

        
        public Add_Quote(Form mainMenu, int quoteCounter) //CONSTRUCTOR
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            this.quoteCountFromMain = quoteCounter;

            quoteCount.Text = "Quote Count = " + this.quoteCountFromMain.ToString();
        }

        private void Add_Quote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var mainMenu = (MainMenu)this.Tag;
            //mainMenu.Show();
            _mainMenu.Show();
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

                rushCost.Text = (basePrice + addative * multiplier).ToString("C");
                rushOrder_yes.Checked = true;
                rushOrder_no.Checked = false;
            }
        }
        public decimal calculateSize()
        {
            decimal width = width_input.Value;
            decimal depth = depth_input.Value;
            decimal size = width * depth;
            if (size > 1000)
            {
                sizeCost.Text = (size - 1000).ToString("C");
            }
            else
            {
                sizeCost.Text = "$0.00";
            }

            return size;
        }
        public double calculateTotals()
        {

            double basePrice = double.Parse(baseCost.Text.Substring(1));
            double sizePrice = double.Parse(sizeCost.Text.Substring(1));
            double drawerPrice = double.Parse(drawerCost.Text.Substring(1));
            double materialPrice = double.Parse(materialCost.Text.Substring(1));
            double rushPrice = double.Parse(rushCost.Text.Substring(1));

            double sumPrice = basePrice + sizePrice + drawerPrice + materialPrice + rushPrice;
            double taxPrice = sumPrice * 0.06;
            double totalPrice = sumPrice + taxPrice;

            sumCost.Text = sumPrice.ToString("C");
            taxCost.Text = (taxPrice).ToString("C");
            totalCost.Text = (totalPrice).ToString("C");

            return totalPrice;
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void createWriteJson(DeskQuote quoteObject, string jsonPath) {

            var jsonToWrite = JsonConvert.SerializeObject(quoteObject, Formatting.Indented);
            File.WriteAllText(jsonPath, quoteObject.ToString());
            using (StreamWriter file = File.CreateText(jsonPath)) ;
            using (var writer = new StreamWriter(jsonPath))
            {
                writer.Write(jsonToWrite);
            }
        }
        private void days_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateRushCost();
            calculateTotals();
        }
        private void depth_input_ValueChanged(object sender, EventArgs e)
        {
            calculateSize();
            calculateRushCost();
            calculateTotals();
        }
        private void drawerCount_input_ValueChanged(object sender, EventArgs e)
        {
            drawerCost.Text = (drawerCount_input.Value * 50).ToString("C");
            calculateTotals();
        }
        private void email_input_Click(object sender, EventArgs e)
        {
            phone_input.Checked = false;
            contactData_label.Text = "Email Address";
        }
        private DeskQuote establichQuoteDetails()
        {
            DeskQuote dq = new DeskQuote();
            Desk deskProperties = new Desk();
            dq.customerName = fullName_input.Text;
            dq.quoteTotalPrice = decimal.Parse(totalCost.Text.Substring(1));
            dq.finishDate = DateTime.Now;
            if (phone_input.Checked == true)
            {
                dq.contactMethod = "phone";
            }
            else if (email_input.Checked == true)
            {
                dq.contactMethod = "email";
            }
            dq.contactInfo = contactData_input.Text;
            deskProperties.width = int.Parse(width_input.Value.ToString());
            deskProperties.depth = int.Parse(depth_input.Value.ToString());
            deskProperties.drawerCount = int.Parse(drawerCount_input.Value.ToString());
            deskProperties.material = material_input.Text;
            deskProperties.expectancy = int.Parse(days_input.Text);

            dq.deskProperties = deskProperties;

            return dq;
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
        private void phone_input_Click(object sender, EventArgs e)
        {
            email_input.Checked = false;
            contactData_label.Text = "Phone Number";
        }
        private void readWriteToJson(DeskQuote quoteObject, string jsonPath)
        {
            string existingJson;
            QuoteList qL = new QuoteList();
            ;

            using (var reader = new StreamReader(jsonPath))
            {
                existingJson = reader.ReadToEnd();
            }
            var existingJson_Object = JsonConvert.DeserializeObject<DeskQuote>(existingJson);

            //using (var writer = new StreamWriter(jsonPath))
            //{
            //    writer.Write(quoteObject);
            //}

            //qL.listOfQuotes = [existingJson_Object, quoteObject];



            quoteCount.Text = existingJson_Object.quoteTotalPrice.ToString(); //WORKS
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
        private void save_btn_Click(object sender, EventArgs e)
        {
            //int quoteCount = new MainMenu().quoteCounter;

            this.quoteCountFromMain++;
            DeskQuote quote = this.establichQuoteDetails();
            saveQuote(quote);
            //this.Close();
        }
        private void saveQuote(DeskQuote quoteObject)
        {
            string jsonPath = @"../../Resources/quoteList1.json";
            

            try {
                readWriteToJson(quoteObject, jsonPath);
                Console.Write("readWrite");
            }
            catch {
                createWriteJson(quoteObject, jsonPath);
                Console.Write("createWrite");
            }
        }
        private void width_input_ValueChanged(object sender, EventArgs e)
        {
            calculateSize();
            calculateRushCost();
            calculateTotals();

        }

    }
}