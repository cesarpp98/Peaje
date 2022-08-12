using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeajeApp.GUI
{
    public partial class ContadorDeVehiculos : Form
    {
        public ContadorDeVehiculos()
        {
            InitializeComponent();
        }

        private void ContadorDeVehiculos_Load(object sender, EventArgs e)
        {
           
        }


        private void btnbusca_Click(object sender, EventArgs e)
        {
            vehiculo contar = new vehiculo();
            string placabuscar = txtbuscar.Text.ToUpper();
            List<vehiculo> buscapl = contar.Obtener();

            int cantidad = 0;
            for (int j = 0; j < buscapl.Count; j++)
            {
                if (placabuscar.Contains(buscapl[j].placa))
                {
                    cantidad++;
                }

            }
            if (cantidad > 0)
            {
                MessageBox.Show("El Vehiculo con las placas:  " + placabuscar + ", esta registrado " + cantidad.ToString() + " veces.");
            }
            else
            {
                MessageBox.Show("El Vehiculo con las placas:  " + placabuscar + ", No esta resgistrado en la base de datos.");
            }
        }        
               
               
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
