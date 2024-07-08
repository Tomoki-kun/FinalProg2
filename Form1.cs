using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GestionVenta gestionSistema;
        string archivoSerializable = Application.StartupPath + "\\Datos.dat";


        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(archivoSerializable))
            {
                FileStream fs = new FileStream(archivoSerializable, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                try
                {
                    gestionSistema = (GestionVenta)bf.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al deserializar sistema " + ex.Message);
                }
                finally { fs.Close(); }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(archivoSerializable)) File.Delete(archivoSerializable);

            if (gestionSistema != null)
            {

                FileStream fs = new FileStream(archivoSerializable, FileMode.CreateNew, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();

                try
                {
                    bf.Serialize(fs, gestionSistema);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al serializar sistema " + ex.Message);
                }
                finally { fs.Close(); }
            }

        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            leerDialog.Filter = "Archivo CSV (*.csv) | *.csv";
            if (File.Exists(leerDialog.FileName))
                Leer(leerDialog.FileName);
            else
                MessageBox.Show("Nombre de archivo ingresado no existe");
        }

        public void Leer(string archivo)
        {
            if (File.Exists(archivo))
            {
                FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                        if (line.Length == 4)
                        {
                            if (line[3] == "P")
                                gestionSistema.lista.Add(new Premium(line[0], Convert.ToDouble(line[1]), Convert.ToDouble(line[2])));
                            if (line[3] == "C")
                                gestionSistema.lista.Add(new Clasico(Convert.ToDouble(line[1]), line[0]));
                        }
                    }
                    foreach (Producto prod in gestionSistema.lista)
                        lbProductos.Items.Add(prod.Descripcion());
                }
                catch { }
                finally { sr.Close(); fs.Close(); }
            }
        }

        private void btnExpPedidos_Click(object sender, EventArgs e)
        {

        }

        private void btnExpCliente_Click(object sender, EventArgs e)
        {

        }
    }
}