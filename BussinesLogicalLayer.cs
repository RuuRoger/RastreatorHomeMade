using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreatorHomeMade
{
    internal class BussinesLogicalLayer
    {
        private DataAccesLayer _dataAccesLayer;

        public BussinesLogicalLayer()
        {
            _dataAccesLayer = new DataAccesLayer();
        }

        public Contact SaveContact(Contact contact)
        {

        }
    }
}
