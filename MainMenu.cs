using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuote_btn_Click(object sender, EventArgs e)
        {
            //create and show Add Quote form
            var addQuote = new Add_Quote(this);
            addQuote.Show();

            //hide Main Menu
            this.Hide();

        }

        private void viewQuote_btn_Click(object sender, EventArgs e)
        {
            var viewQuotes = new View_All_Quotes(this);
            viewQuotes.Show();
            this.Hide();
        }

        private void searchQuote_btn_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
