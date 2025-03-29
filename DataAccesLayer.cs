using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreatorHomeMade
{
    internal class DataAccesLayer
    {
        private SqlConnection _conectionBBDD = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinformsContacts;Data Source=LaptopRuu");
    }
}
