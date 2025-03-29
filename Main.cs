using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastreatorHomeMade
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Method

        private void OpendAddContactForm()
        {
            //field
            ContactDetails contactDetails = new ContactDetails();

            contactDetails.ShowDialog();
        }

        #endregion

        #region Winforms Events

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            OpendAddContactForm();
        }

        #endregion
    }
}
