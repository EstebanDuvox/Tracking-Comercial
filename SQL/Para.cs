using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracking_Comercial.SQL
{
    internal class Para
    {
        private string _conexion;

        public string Conexion { 
            get
            { return _conexion; }
            set { _conexion = value; }
        }
    }
}
