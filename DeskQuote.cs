using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2._0
{
    public class DeskQuote
    {
        public string customerName { get; set; }
        public decimal quoteTotalPrice { get; set; }
        public DateTime finishDate { get; set; }
        public string contactMethod { get; set; }
        public string contactInfo { get; set; }
        public Desk deskProperties { get;set; }

    }
}
