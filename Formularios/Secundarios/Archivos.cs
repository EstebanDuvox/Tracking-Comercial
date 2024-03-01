using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracking_Comercial.Filezilla;
using Tracking_Comercial.SQL;

namespace Tracking_Comercial.Formularios.Secundarios
{
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
            Prospecto p = new Prospecto();
            cbP.DataSource = p.listP();
            //Arch archivos = new Arch();
            //archivos.lista(cbP.Text);
        }
    }
}
