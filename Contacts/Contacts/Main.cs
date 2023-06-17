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
        BusinessLogicLayer _BusinessLogicLayer;
        public Main()
        {
            InitializeComponent();
            _BusinessLogicLayer = new BusinessLogicLayer();
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
            contactDetails.ShowDialog(this);
        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }

        public void PopulateContacts() 
        {
            List<Contact> contacts = _BusinessLogicLayer.GetContacts();
            gridContacts.DataSource = contacts; 
        }

        private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Edit")
            {
                ContactDetails contactDetails = new ContactDetails();
                contactDetails.LoadContact(new Contact
                {
                    Id = int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FirstName = gridContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = gridContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone = gridContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address = gridContacts.Rows[e.RowIndex].Cells[4].Value.ToString(),

                });
                contactDetails.ShowDialog(this);
            }            
        }
    }
}
