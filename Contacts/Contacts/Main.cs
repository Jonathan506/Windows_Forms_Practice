using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDialog();
        }

        #region PRIVATE METHODS
        private void OpenContactDetailsDialog()
        {
            ContactDetails contactDetails = new ContactDetails();
            contactDetails.ShowDialog();
        }
        #endregion
    }
}
