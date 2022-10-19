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
    public partial class View_All_Quotes : Form
    {
        private Form _mainMenu; //_name is private variable
        public View_All_Quotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            loadGrid();
        }

        private void loadGrid()
        {
            var quotesFile = @"quoteList.json";

            if(File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    // load existing quotes
                    string quotes = reader.ReadToEnd();
                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    
                    allQuotesDataGrid.DataSource = deskQuotes.Select(d => new
                    {
                        Date = d.startDate,
                        Customer = d.customerName,
                        Depth = d.deskProperties.depth,
                        Width = d.deskProperties.width,
                        Drawers = d.deskProperties.drawerCount,
                        SurfaceMaterial = d.deskProperties.material,
                        DeliveryType = d.deskProperties.rushDays,
                        QuoteAmount = d.quoteTotalPrice.ToString("c")
                    }
                    )
                        .ToList();

                }
            }
        }

        private void View_All_Quotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
