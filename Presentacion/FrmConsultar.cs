using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmConsultar : Form
    {
        ServicioDpto ServicioDpto;
        public FrmConsultar()
        {
            InitializeComponent();
            ServicioDpto= new ServicioDpto();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            CargarGrillaDptos();
        }

        private void CargarGrillaDptos()
        {
            grillaDepartamentos.DataSource = ServicioDpto.Consultar();
        }
    }
}
