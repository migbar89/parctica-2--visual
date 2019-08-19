using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auto
{
    public partial class FrmAuto : Form
    {
        ErrorProvider error;
      
        public FrmAuto()
        {
            InitializeComponent();
        }

        bool validar()
        {
            if (cbMarca.SelectedIndex < 0)
            {
                error.SetError(cbMarca, "Seleccione una marca");
                return false;
            }
         

                if (cbEstado.SelectedIndex < 0)
                {
                    error.SetError(cbEstado, "Seleccione un estado ");
                    return false;
                }
            if (cbTrans.SelectedIndex < 0)
            {
                error.SetError(cbTrans, "Seleccione un tipo de transmision");
                return false;
            }
            if(ctKilo.Text.Trim().Length==0)
            {
                error.SetError(ctKilo, "Agregue un kilometraje");
                return false;
            }
            if (ctPrecio.Text.Trim().Length == 0)
            {
                error.SetError(ctPrecio, "Agregue un precio");
                return false;

            }
            if (rbSi.Checked == false && rbNo.Checked == false)
            {
                error.SetError(rbNo, "Debe seleccionar por lo menos una opcion");
                return false;

            }

            return true;
            
        }
        void limpiar()
        {

            cbEstado.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            cbTrans.SelectedIndex = -1;
            ctKilo.Clear();
            ctPrecio.Clear();
            rbSi.Checked = false;
            rbNo.Checked = false;

        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
                return;


            Auto a = new Auto();
            a.Marca = cbMarca.SelectedItem.ToString();
            a.Kilometraje = long.Parse(ctKilo.Text);
            a.Estado = cbEstado.SelectedItem.ToString();
            a.Precio = double.Parse(ctPrecio.Text);
            a.Transmision = cbTrans.SelectedItem.ToString();
            if (rbSi.Checked)
                a.Rines_lujo = true;
            if (rbNo.Checked)
                a.Rines_lujo = false;
            Datospublicos.listaauto.Add(a);
            MessageBox.Show("Los datos del auto han sido guardados satisfactoriamente...");

            limpiar();
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            Frmvisualizar visualizar = new Frmvisualizar();
            visualizar.ShowDialog();
         /*  string rines = (a.Rines_lujo) ? "Sí" : "No";
            MessageBox.Show("Marca: " + a.Marca + Environment.NewLine +
                            "Kilometraje: " + a.Kilometraje + Environment.NewLine +
                            "Estado: " + a.Estado + Environment.NewLine +
                            "Precio: " + a.Precio + Environment.NewLine +
                            "Transmisión: " + a.Transmision + Environment.NewLine +
                            "Rines de Lujo: " + rines);
                            */
        }

        private void ctKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;


        }

        private void FrmAuto_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            error.Clear();
        }
    }
}
