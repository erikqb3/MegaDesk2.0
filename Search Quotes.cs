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
    public partial class Search_Quotes : Form
    {
        private Form _mainMenu; //_name is private variable

        //List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
        //    .Cast<DesktopMaterial>()
        //    .ToList();

        public Search_Quotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            List<string> desktopMaterials = Enum.GetNames(typeof(DesktopMaterial)).ToList();
            desktopMaterials.Insert(0, "All Materials");
            materialComboBox.DataSource = desktopMaterials;

            loadGrid();
        }

        

        private void Search_Quotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        // Search by material
        private void materialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // call loadGrid() WHERE d.deskProperties.material == material
            if (materialComboBox.Text == "All Materials")
                loadGrid();
            else
            {
                loadGrid(materialComboBox.Text);
            }

        }

        private void loadGrid()
        {
            var quotesFile = @"quoteList.json";

            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    // load existing quotes
                    string quotes = reader.ReadToEnd();
                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                    searchQuotesDataGrid.DataSource = deskQuotes.Select(d => new
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
        // Filter by materials
        private void loadGrid(string desktopMaterial)
        {
            var quotesFile = @"quoteList.json";

            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    // load existing quotes
                    string quotes = reader.ReadToEnd();
                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                    DesktopMaterial desktopMaterialEnum = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), desktopMaterial);

                    searchQuotesDataGrid.DataSource = deskQuotes.Select(d => new
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
                        .Where(q => q.SurfaceMaterial == desktopMaterialEnum)
                        .ToList();

                }
            }
        }

        // We don't need these. Delete when possible.
        private void Search_Quotes_Load(object sender, EventArgs e)
        {

        }

        private void Search_Quotes_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        // end
    }

}
