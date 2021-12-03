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
    public partial class Form1 : Form
    {
        //0.01
        private String versiontext = "0.013";
        private String version = "4e452fdc97dcb2d71864b9f702a55d49";
        public static String conexionsqllast = "server=148.223.153.37,5314; database=InfEq;User ID=eordazs;Password=Corpame*2013; integrated security = false ; MultipleActiveResultSets=True";


        public static String servidor = "148.223.153.43\\MSSQLSERVER1";
        public static String nombre_bd = "bd_SiTTi";
        public static String userbd = "sa";
        public static String passbd = "At3n4";
        public static string nsql = "server=" + servidor + "; database=" + nombre_bd + " ;User ID=" + userbd + ";Password=" + passbd + "; integrated security = false ; MultipleActiveResultSets=True";

        public static int nsitti;

        public static String id_ms_ticket;
        public static String fecha_solicita;
        public static String status;
        public static String descripcion;
        public static String nick;
        public static String fecha_asigno;
        public static String fecha_asigC;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion2 = new SqlConnection(conexionsqllast))
                {
                    conexion2.Open();
                    String sql2 = "SELECT (SELECT valor FROM Configuracion WHERE nombre='Desquemar_Version') as version,valor FROM Configuracion WHERE nombre='Desquemar_hash'";
                    SqlCommand comm2 = new SqlCommand(sql2, conexion2);
                    SqlDataReader nwReader2 = comm2.ExecuteReader();
                    if (nwReader2.Read())
                    {
                        if (nwReader2["valor"].ToString() != version)
                        {
                            MessageBox.Show("No se puede inciar sesion porque hay una nueva version.\n\nNueva Version: " + nwReader2["version"].ToString() + "\nVersion actual: " + versiontext + "\n\nEl programa se cerrara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puedo verificar la version del programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en validar la version del programa\n\nMensaje: " + ex.Message, "Información del Equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            nositti.Select(0, 1);
            nositti.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nositti.Text))
            {
                MessageBox.Show("Debes ingresar un numero de sitti valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conexion = new SqlConnection(nsql))
                {
                    nsitti = Convert.ToInt32(nositti.Text);
                    conexion.Open();
                    String consulta = "SELECT t.id_ms_ticket, t.fecha_solicita, t.descripcion, t.status, t.fecha_asigC, u.nick, t.fecha_asigno FROM ms_ticket t LEFT JOIN cg_usuario u ON t.id_asigno=u.id_usuario where id_ms_ticket='" + nsitti + "'";
                    SqlCommand comm = new SqlCommand(consulta, conexion);
                    SqlDataReader nwReader = comm.ExecuteReader();
                    while (nwReader.Read())
                    {
                        id_ms_ticket = nwReader["id_ms_ticket"].ToString();
                        fecha_solicita = nwReader["fecha_solicita"].ToString();
                        status = nwReader["status"].ToString();
                        descripcion = nwReader["descripcion"].ToString();
                        nick = nwReader["nick"].ToString();
                        fecha_asigno = nwReader["fecha_asigno"].ToString();
                        fecha_asigC = nwReader["fecha_asigC"].ToString();

                        if (String.IsNullOrEmpty(nwReader["fecha_asigno"].ToString()))
                        {
                            sitti Sittiform = new sitti();
                            Sittiform.ShowDialog();
                            return;
                        }
                        else
                        {
                            //if (!nwReader["status"].ToString().Equals("A") && !nwReader["status"].ToString().Equals("P"))
                            Sitti_asignado sittiasignado = new Sitti_asignado();
                            sittiasignado.ShowDialog();
                            return;
                        }
                    }
                    MessageBox.Show("Este sitti no existe.", "Sitti Asignado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al revisar numero de sitti.\n\nMensaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nositti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
