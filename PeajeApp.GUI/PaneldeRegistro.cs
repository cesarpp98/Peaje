using System;
using System.Web;
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
    public partial class RegistrodeVehiculo : Form
    {
        public RegistrodeVehiculo()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            vehiculo vehiculo = new vehiculo();
            vehiculo.id = Convert.ToInt32(txtidrecibo.Text);
            vehiculo.via = cmbvia.SelectedItem + "";
            vehiculo.mpago = cmbmpago.SelectedItem + "";
            vehiculo.placa = txtplaca.Text;
            vehiculo.categoria = cmbcvehiculo.SelectedItem + "";
            vehiculo.tarifa = cmbtarifa.SelectedItem + "";
            vehiculo.pago = txtpago.Text;

            try
            {
                bool registrado = vehiculo.registrar();
                if (registrado == true)
                {
                    MessageBox.Show("REGISTRADO");
                    RegistrodeVehiculo VentanaRegistro = new RegistrodeVehiculo();
                    VentanaRegistro.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("ERROR AL REGISTRAR");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Refresh();
        }
       
       

        private void RegistrodeVehiculo_Load(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int a = rdn.Next(100, 999);
            int b = rdn.Next(100, 999);
            int c = rdn.Next(100, 999);
            txtidrecibo.Text = a.ToString() + b.ToString() + c.ToString();                
                       
        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
          
        }         

        private void cmbtarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbtarifa.SelectedItem.ToString() == "Basica")
            {
                txtpago.Text = "15.500";
            }

            if (cmbtarifa.SelectedItem.ToString() == "Mediana")
            {
                txtpago.Text = "20.500";
            }

            if (cmbtarifa.SelectedItem.ToString() == "Alta")
            {
                txtpago.Text = "25.500";
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            

        }

        private void cmbcvehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcvehiculo.SelectedItem.ToString() == "Pequeño")
            {
                cmbtarifa.SelectedItem = "Basica";
            }

            if (cmbcvehiculo.SelectedItem.ToString() == "Mediano")
            {
                cmbtarifa.SelectedItem = "Mediana";
            }

            if (cmbcvehiculo.SelectedItem.ToString() == "Grande")
            {
                cmbtarifa.SelectedItem = "Alta";
            }
        }

        private void txtidrecibo_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

