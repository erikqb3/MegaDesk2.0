using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk2._0
{
    public enum DesktopMaterial
    {
        Oak,
        Laminated,
        Pine,
        Rosewood,
        Veneer

    }
    public enum RushDays
    {
        [Description("14")] RushOption14,
        [Description("3")] RushOption3,
        [Description("5")] RushOption5,
        [Description("7")] RushOption7
    }
    public class Desk
    {
        //CONSTANTS
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;
        public const short MIN_DESK_DRAWERS = 0;
        public const short MAX_DESK_DRAWERS = 7;



        public int width { get; set; }
        public int depth { get; set; }
        public int drawerCount { get; set; }
        //public string material { get; set; } //Make it public DesktopMaterial material {get;set;}
        public DesktopMaterial material { get; set; }
        public RushDays rushDays { get; set; }



        //public string DesktopMaterial DesktopMaterial { get;set }

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

                foreach (string price in prices)
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

                rushCost.Text = rushOrderPrices[dayIndex, sizeIndex].ToString("C");
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
    }
}
