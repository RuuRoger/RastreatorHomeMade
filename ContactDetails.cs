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
    public partial class ContactDetails : Form
    {
        //Global fields values
        private BussinesLogicalLayer _bussinesLogicalLayer;

        public ContactDetails()
        {
            InitializeComponent();
            _bussinesLogicalLayer = new BussinesLogicalLayer();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAcparAgregar_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            contact.FirstName = textBoxNombre.Text;
            contact.LastName = textBoxApellidos.Text;
            contact.Phone = textBoxTeleono.Text;
            contact.Email = textBoxEmail.Text;
        }
    }
}
