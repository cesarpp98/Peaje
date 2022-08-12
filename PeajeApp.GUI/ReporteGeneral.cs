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
    public partial class ReporteGeneral : Form
    {
        public ReporteGeneral()
        {
            InitializeComponent();
        }

        public string PlacaBuscada{ get; set; }
        public ReporteGeneral (string placabuscada)
        {
            this.PlacaBuscada = placabuscada;
            InitializeComponent();

        }
       

        private void ReporteGeneral_Load(object sender, EventArgs e)
        {
            vehiculo elvehiculo = new vehiculo();
            dataGridView1.DataSource = elvehiculo.Obtener();
        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                string strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["placa"].Value);
                string Valor2 = Convert.ToString(Row.Cells["id"].Value);

                if (Valor == this.txtbusca.Text)
                {
                    dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Cyan;
                }
                
                if (Valor2 == this.txtbusca.Text)
                {
                    dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Cyan;
                  
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            
        }
    }
}

  


