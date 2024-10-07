using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmDepartamento : Form
    {
        BLL.ServicioDpto ServicioDpto;
        int posicion=0;
        public FrmDepartamento()
        {
            InitializeComponent();
            ServicioDpto = new BLL.ServicioDpto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        void Guardar()
        {
            Departamento departamento = new Departamento(txtCodigo.Text ,txtNombre.Text);
            var mensaje=ServicioDpto.Agregar(departamento);
            CargarListaDpto();
            MessageBox.Show(mensaje);
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            CargarListaDpto();
            Primero();
        }
        void CargarListaDpto()
        {
            lstDptos.Items.Clear();
            foreach(var item in ServicioDpto.Consultar())
            {
                lstDptos.Items.Add(item.NombreDpto);

            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            Primero();
           
        }

        private void Primero()
        {
            if (lstDptos.Items.Count > 0)
            {
                posicion = 0;
                lstDptos.SelectedIndex = posicion;
            }
           
        }

        private void Ver(int indice)
        {
            var dpto= ServicioDpto.Consultar()[indice];
            txtCodigo.Text = dpto.CodigoDpto;
            txtNombre.Text = dpto.NombreDpto;
        }

        private void lstDptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ver(lstDptos.SelectedIndex);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            posicion = ServicioDpto.Consultar().Count - 1;
            lstDptos.SelectedIndex = posicion;

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion == 0) return;
            posicion = posicion - 1;
            //Ver(posicion);
            lstDptos.SelectedIndex= posicion;   
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion == ServicioDpto.Consultar().Count - 1) return;
            posicion++;
            //Ver(posicion);
            lstDptos.SelectedIndex = posicion;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            new FrmConsultar().ShowDialog();    
        }
    }
}
