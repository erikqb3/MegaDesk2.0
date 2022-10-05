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
    public partial class View_All_Quotes : Form
    {
        private Form _mainMenu; //_name is private variable
        public View_All_Quotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void View_All_Quotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
