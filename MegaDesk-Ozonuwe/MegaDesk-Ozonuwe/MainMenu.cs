using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Ozonuwe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            // create Add Quote form
            var addQuote = new AddQuote();
            addQuote.Tag = this;

            // show Add Quote form
            addQuote.Show();

            // hide Main Menu
            this.Hide();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            // create View Quotes form
            var viewQuotes = new ViewAllQuotes();
            viewQuotes.Tag = this;

            // show View Quote form
            viewQuotes.Show();

            // hide Main Menu
            this.Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            // create Search Quotes form
            var searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;

            // show Search Quote form
            searchQuotes.Show();

            // hide Main Menu
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //EXIT Application
            Application.Exit();
        }
    }
}
