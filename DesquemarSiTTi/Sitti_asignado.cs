using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesquemarSiTTi
{
    public partial class Sitti_asignado : Form
    {
        public Sitti_asignado()
        {
            InitializeComponent();
        }

        public static DateTime fechasol;
        public static DateTime fechaC;
        public static DateTime fecha_asigno;

        private void Sitti_asignado_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;

            nositti.Text = Form1.id_ms_ticket;
            fechasolicita.Text = Form1.fecha_solicita;
            fechaquema.Text = Form1.fecha_asigC;
            descripcion.Text = Form1.descripcion;
            nick.Text = Form1.nick;
            asigno.Text = Form1.fecha_asigno;

            fechasol = DateTime.Parse(fechasolicita.Text);
            fechaC = DateTime.Parse(fechaquema.Text);
            fecha_asigno = DateTime.Parse(asigno.Text);

            int diff = DateTime.Compare(fecha_asigno, fechaC);

            if (diff > 0)
            {
                label4.Text = "Quemado";
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.Text = "En tiempo";
                label4.ForeColor = Color.Green;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion2 = new SqlConnection(Form1.nsql))
            {
                try
                {
                    DateTime NuevaFechaAsigno = fechaC.AddMinutes(-10);
                    DateTime NuevaFechaSolicita = fechaC.AddMinutes(-30);

                    String NuevaFechaSolicita_insertar = NuevaFechaSolicita.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                    String NuevafechaAsigno_insertar = NuevaFechaAsigno.ToString("yyyy-MM-ddTHH:mm:ss.fff");

                    String insert = "UPDATE ms_ticket SET fecha_solicita = '" + NuevaFechaSolicita_insertar + "', fecha_asigno='" + NuevafechaAsigno_insertar + "' where id_ms_ticket='" + nositti.Text + "'";
                    conexion2.Open();

                    Console.WriteLine(insert);
                    SqlCommand comm2 = new SqlCommand(insert, conexion2);
                    comm2.ExecuteReader();

                    MessageBox.Show("Fecha actualizada", "Sitti actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar fecha.\n\nMensaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
