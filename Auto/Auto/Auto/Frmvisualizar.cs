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
    public partial class Frmvisualizar : Form
    {
        List<Auto> lista;
        public Frmvisualizar()
        {
            InitializeComponent();
        }

        private void Frmvisualizar_Load(object sender, EventArgs e)
        {
            lista= Datospublicos.listaauto;
            cbMarca.SelectedIndex = 0;
            cargardatos();

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarca.SelectedIndex == 0)
            {
                lista = Datospublicos.listaauto;

            }
            else
            {
                lista = (from c in Datospublicos.listaauto
                         where c.Marca == cbMarca.Text
                         select c).ToList();

            }
          
            cargardatos();

        }
        void cargardatos()
        {
            gridautos.DataSource = null;
            gridautos.DataSource = lista;
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            int fila = gridautos.CurrentRow.Index;
            Datospublicos.listaauto.RemoveAt(fila);
            lista = Datospublicos.listaauto;
            cbMarca.SelectedIndex = 0;
            cargardatos();
            MessageBox.Show("Auto Eliminado Correctamente");

        }
    }
}
