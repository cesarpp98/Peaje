using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeajeApp.GUI
{
    public class vehiculo
    {
        public int id { get; set; }
        public string via { get; set; }
        public string mpago { get; set; }
        public string placa { get; set; }
        public string categoria { get; set; }
        public string tarifa { get; set; }
        public string pago { get; set; }
        string ruta = @"E:\DatosPeaje\vehiculo.txt";
        
        public bool registrar()
        {
            string datos = this.id + ";" + this.via + ";" + this.mpago + ";" + this.placa + ";" + categoria + ";" + this.tarifa + ";" + this.pago + ";\n";
            
            if (Existe(this.id) == false)
            {
                
                if (File.Exists(ruta))
                {
                    StreamWriter writer = File.AppendText(ruta);
                    writer.WriteLine(datos);
                    writer.Close();

                }
                else
                {
                    StreamWriter writer = File.CreateText(ruta);
                    writer.WriteLine(datos);
                    writer.Close();
                }
            }
            else
            {
                throw new Exception("El vehiculo ya esta registrado");
            }

            return true;
        }

        public bool Existe(int Codigo)
        {
            string input = "";
            if (File.Exists(ruta) == false)
            {
                File.CreateText(ruta).Close();
            }
            using (StreamReader reader = File.OpenText(ruta))
            {
                while ((input = reader.ReadLine()) != null)
                {
                    string[] valores = input.Split(';');
                    int codigoencontrado;

                    if (int.TryParse(valores[0],out codigoencontrado))
                    {
                        if (Codigo == codigoencontrado)
                        {
                            return true;
                        }
                    }
                }

              }
            return false;
        }

        public List<vehiculo> Obtener()
        {
            string ruta = @"E:\DatosPeaje\vehiculo.txt";
            List<vehiculo> vehiculos = new List<vehiculo>();
            string input = "";
            if (File.Exists(ruta) == false)
            {
                File.CreateText(ruta).Close();
            }
            using (StreamReader reader = File.OpenText(ruta))
            {
                while ((input = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(input) == false)
                    {

                        string[] valores = input.Split(';');
                        vehiculo elvehiculo = new vehiculo();
                        elvehiculo.id = Convert.ToInt32(valores[0]);
                        elvehiculo.via = valores[1];
                        elvehiculo.mpago = valores[2];
                        elvehiculo.placa = valores[3];
                        elvehiculo.categoria = valores[4];
                        elvehiculo.tarifa = valores[5];
                        elvehiculo.pago = valores[6];
                        vehiculos.Add(elvehiculo);
                    }
                }
            }
            return vehiculos;
        }

      

    }
}
