﻿using System;
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

            // Display quotes in the text box
            // allQuotesText = 
        }

        private void readJson(string jsonPath)
        {
            string existingJson;
            //list QuoteList qL = new QuoteList();
            List<DeskQuote> deskQuoteList = new List<DeskQuote>();
            // List <DeskQuote> deskQuoteList;

            if (File.Exists(jsonPath))
            {
                using (var reader = new StreamReader(jsonPath))
                {
                    existingJson = reader.ReadToEnd();
                    if (existingJson.Length > 0)
                    {
                        deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(existingJson);
                    }
                }
            }
            deskQuoteList.Add(quoteObject);

            var finalQuoteList = JsonConvert.SerializeObject(deskQuoteList, Formatting.Indented);
            File.WriteAllText(jsonPath, finalQuoteList);
        }

        private void View_All_Quotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
