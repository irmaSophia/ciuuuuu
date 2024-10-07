using BLL;
using ENTITY;
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
    public partial class FrmMunicipio : Form
    {
        ServicioMunicipio ServicioMunicipio;
        ServicioDpto servicioDpto;
        public FrmMunicipio()
        {
            InitializeComponent();
            ServicioMunicipio= new ServicioMunicipio(); 
            servicioDpto= new ServicioDpto();   
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        void Guardar()
        {
            var municipio = new Municipio();
            municipio.CodigoMunicipio= txtCodigo.Text;
            municipio.NombreMunicipio= txtNombre.Text;
            municipio.Departamento=servicioDpto.BuscarPorCodigo(cbDptos.SelectedValue.ToString());
            municipio.EsCapital=rbEsCapital.Checked;
            var mensaje=ServicioMunicipio.Agregar(municipio);
            MessageBox.Show(mensaje);
        }

        private void FrmMunicipio_Load(object sender, EventArgs e)
        {
            CargarComboDepartamentos();
        }

        private void CargarComboDepartamentos()
        {
            cbDptos.DataSource = servicioDpto.Consultar();
            cbDptos.DisplayMember = "NombreDpto";
            cbDptos.ValueMember = "CodigoDpto";
        }

        private void cbDptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Text = cbDptos.SelectedValue.ToString();
        }
    }
}
