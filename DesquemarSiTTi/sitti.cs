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
    public partial class sitti : Form
    {
        public sitti()
        {
            InitializeComponent();
        }


        public static DateTime fechasol;
        public static DateTime fechaC;

        private void sitti_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;

            nositti.Text = Form1.id_ms_ticket;
            fechasolicita.Text = Form1.fecha_solicita;
            fechaquema.Text = Form1.fecha_asigC;
            descripcion.Text = Form1.descripcion;

            fechasol = DateTime.Parse(fechasolicita.Text);
            fechaC = DateTime.Parse(fechaquema.Text);

            int diff = DateTime.Compare(fechaC, DateTime.Now);

            if(diff < 0)
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
                    DateTime NuevaSol = DateTime.Now.AddMinutes(-15);
                    DateTime NuevaSol_C = DateTime.Now.AddMinutes(15);

                    String nuevafechaC = NuevaSol_C.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                    String nuevafechaSol = NuevaSol.ToString("yyyy-MM-ddTHH:mm:ss.fff");

                    String insert = "UPDATE ms_ticket SET fecha_solicita = '"+ nuevafechaSol + "', fecha_asigC='"+ nuevafechaC + "' where id_ms_ticket='" + nositti.Text + "'";
                    conexion2.Open();
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
