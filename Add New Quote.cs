using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDesk1._0;
using Newtonsoft.Json;

namespace MegaDesk2._0
{
    public partial class Add_Quote : Form
    {
        private Form _mainMenu; //_name is private variable
        internal Desk desk_class = new Desk();
        internal DeskQuote deskQuote_class = new DeskQuote();

        public DateTime currentDate_value = DateTime.Now;
        public string jsonPath = @"quoteList.json";
        public string rushOrderJson = @"rushOrderPrices.txt";


        List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
            .Cast<DesktopMaterial>()
            .ToList();

        List<RushDays> rushDays = Enum.GetValues(typeof(RushDays))
            .Cast<RushDays>()
            .ToList();

        public Add_Quote(Form mainMenu) //CONSTRUCTOR
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            //CLIENT INFO
            contactData_input.Enabled = false;
            currentDate_label.Text = DateTime.Now.ToString("ddd, d-MMM-yyyy", CultureInfo.CreateSpecificCulture("en-US"));

            //DESK PROPERTIES
            width_input.Value = 24;
            depth_input.Value = 12;
            drawerCount_input.Value = 0;

            material_input.DataSource = materials;

            List<string> shippingDescriptions = new List<string>();
            foreach (RushDays delivery in rushDays)
            {
                var description = GetDescription(delivery);
                shippingDescriptions.Add(description);
            }
            days_input.DataSource = shippingDescriptions;

            //QUOTE
            baseCost.Text = "$200.00";
            this.calculateTotals();
            this.calculateFinishDate();
        }

        private void Add_Quote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var mainMenu = (MainMenu)this.Tag;
            //mainMenu.Show();
            _mainMenu.Show();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.enableContactInput();
        }
        private void material_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = material_input.Text;

            switch (material)
            {
                case "Oak":
                    materialCost.Text = "$200.00";
                    break;
                case "Laminated":
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
            this.enableContactInput();
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


            try
            {
                DeskQuote quote = this.establichQuoteDetails();
                bool isValid = checkValidation();


                if (isValid)
                {
                    saveQuote(quote);
                    this.Close();
                }
                else
                {
                    var invalidInfo = new InvalidInfo(this);
                    invalidInfo.Show();
                }
            }
            catch (InvalidCastException error)
            {
                if (error.Data == null)
                {
                    throw;
                }
                else
                {
                    throw;
                }
            }
            
        }
        private void width_input_ValueChanged(object sender, EventArgs e)
        {
            calculateSize();
            calculateRushCost();
            calculateTotals();

        }


        //DESK FUNCTION
        public void calculateFinishDate()
        {
            finishDate_value.Text = currentDate_value.AddDays(int.Parse(days_input.Text)).ToString("ddd, d-MMM-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
        }
        public void calculateRushCost()
        {
            int[,] rushOrderPrices = new int[3, 3];

            if (File.Exists(rushOrderJson))
            {
                string[] prices = File.ReadAllLines(rushOrderJson);
                int i = 0, j = 0;

                foreach( string price in prices)
                {
                    rushOrderPrices[i, j] = int.Parse(price);
                    if (j == 2)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }


            if (days_input.Text == "14")
            {
                rushCost.Text = "$0.00";
                rushOrder_yes.Checked = false;
                rushOrder_no.Checked = true;

            }
            else
            {
                int dayIndex = 0;
                int sizeIndex = 0;
                decimal size = calculateSize();
                string rushTime = days_input.Text;
                switch (rushTime)
                {
                    case "3":
                        dayIndex = 0;
                        break;
                    case "5":
                        dayIndex = 1;
                        break;
                    case "7":
                        dayIndex = 2;
                        break;
                }
                if (size < 1000)
                {
                    sizeIndex = 0;
                }
                else if ((size >= 1000) && (size <= 2000))
                {
                    sizeIndex = 1;
                }
                else if (size > 2000)
                {
                    sizeIndex = 2;
                }

                rushCost.Text = rushOrderPrices[dayIndex,sizeIndex].ToString("C");
                this.calculateFinishDate();

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
        private string GetDescription(Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute));
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }

        //DESKQUOTE FUNCTIONS
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
        public bool checkValidation()
        {
            if ((fullName_input.Text != "") && (contactData_input.Text != "") && ((phone_input.Checked == true) || (email_input.Checked = true))) {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void enableContactInput()
        {
            if (contactData_input.Enabled == false)
            {
                contactData_input.Enabled = true;
            }
        }
        private DeskQuote establichQuoteDetails()
        {
            DeskQuote dq = new DeskQuote();
            Desk deskProperties = new Desk();
            dq.customerName = fullName_input.Text;
            dq.quoteTotalPrice = decimal.Parse(totalCost.Text.Substring(1));
            dq.startDate = DateTime.Now.ToString("ddd, d-MMM-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            dq.finishDate = currentDate_value.AddDays(int.Parse(days_input.Text));
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
            deskProperties.material = (DesktopMaterial)material_input.SelectedValue; // turn back to enum //(DesktopMaterial)
            deskProperties.rushDays = (RushDays)days_input.SelectedIndex;

            dq.deskProperties = deskProperties;
            Console.WriteLine(dq);
            return dq;
        }
        private void saveQuote(DeskQuote quoteObject)
        {


            string existingJson;
            List<DeskQuote> deskQuoteList = new List<DeskQuote>();

            if (File.Exists(jsonPath))
            {
                using (var reader = new StreamReader(jsonPath))
                {
                    existingJson = reader.ReadToEnd();
                    deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(existingJson);
                }

            }
            deskQuoteList.Add(quoteObject);
            var finalQuoteList = JsonConvert.SerializeObject(deskQuoteList, Formatting.Indented);
            File.WriteAllText(jsonPath, finalQuoteList);



            //try
            //{
            //    using (var reader = new StreamReader(jsonPath))
            //    {
            //        existingJson = reader.ReadToEnd();
            //        deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(existingJson);
            //    }
            //    deskQuoteList.Add(quoteObject);
            //    var finalQuoteList = JsonConvert.SerializeObject(deskQuoteList, Formatting.Indented);
            //    File.WriteAllText(jsonPath, finalQuoteList);
            //}
            //catch (FileNotFoundException e)
            //{
            //    string jsonPath = @"quoteList.json";
            //    File.WriteAllText(jsonPath, "");
            //    using (var reader = new StreamReader(jsonPath))
            //    deskQuoteList.Add(quoteObject);
            //    var finalQuoteList = JsonConvert.SerializeObject(deskQuoteList, Formatting.Indented);
            //    File.WriteAllText(jsonPath, finalQuoteList);
            //}
            //catch (NullReferenceException e)
            //{
            //    string jsonPath = @"quoteList.json";
            //    File.WriteAllText(jsonPath, "");
            //    using (var reader = new StreamReader(jsonPath))
            //    deskQuoteList.Add(quoteObject);
            //    var finalQuoteList = JsonConvert.SerializeObject(deskQuoteList, Formatting.Indented);
            //    File.WriteAllText(jsonPath, finalQuoteList);
            //}








            //using (var writer = new StreamWriter(jsonPath))
            //{
            //    writer.Write(quoteObject);
            //}

            //qL.listOfQuotes = [existingJson_Object, quoteObject];



            //quoteCount.Text = existingJson_Object.quoteTotalPrice.ToString(); //WORKS
        }

    }
}