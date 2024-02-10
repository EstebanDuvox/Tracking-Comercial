using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracking_Comercial.SQL;

namespace Tracking_Comercial.Formularios.Secundarios
{
    public partial class mod_U : Form
    {
        public mod_U()
        {
            InitializeComponent();
            Usuario u = new Usuario();
            cbU.DataSource = u.listU();
        }

    }
}
