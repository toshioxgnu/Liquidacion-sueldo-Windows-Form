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

namespace LiquidacionSueldoGonzalezJose
{
    public partial class Form1 : Form
    {
        const string empleador = "IP LEONES SA. ";
        int sueldoBase;
        int cargas;
        const int movilizacion = 25000; 
        const double fonasa = 0.07;
        const double prevision = 0.1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btngenera_Click(object sender, EventArgs e)
        {
            Utilidades Utils = new Utilidades();
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jgonz\\source\\repos\\LiquidacionSueldoGonzalezJose\\LiquidacionSueldoGonzalezJose\\Database1.mdf;Integrated Security=True");
            var rut = txtrut.Text.ToString();
            if (Utils.validaRut(rut))
            {
                DataTable registro = new DataTable();
                conn.Open();
                string query = "select * from LIQUIDACIONJoseGonzalez where RUT = '"+rut+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(registro);
                if(registro!= null)
                {
                    for (int i = 0; i < registro.Rows.Count; i++)
                    {
                        txtnombre.Text = registro.Rows[i]["NOMBRE"].ToString();
                        lbSueldoBase.Text = registro.Rows[i]["SUELDO_BASE"].ToString();
                        txtCargas.Text = registro.Rows[i]["CARGAS"].ToString();
                        lbanio.Text = registro.Rows[i]["ANIO"].ToString();
                        lbmes.Text = registro.Rows[i]["MES"].ToString().ToUpper();
                        sueldoBase = Convert.ToInt32(registro.Rows[i]["SUELDO_BASE"]);
                        cargas = Convert.ToInt32(registro.Rows[i]["CARGAS"]);
                    }

                    lbMovilizacion.Text = movilizacion.ToString();
                    lbAsignacionFamiliar.Text = (Utils.asignacionFamiliar(cargas) * cargas).ToString();
                    lbTotalRemuneracion.Text = ( sueldoBase + Convert.ToInt32(lbOtrosIngresos.Text) ).ToString();
                    lbTotalhaberes.Text = ( Convert.ToInt32(lbTotalRemuneracion.Text) + Convert.ToInt32(lbAsignacionFamiliar.Text) + movilizacion ).ToString();
                    var afp = sueldoBase * prevision;
                    var salud = sueldoBase * fonasa;
                    lbcotizacion.Text = afp.ToString();
                    lbSalud.Text = salud.ToString();
                    lbtotaldescuentos.Text = ( Convert.ToInt32(lbcotizacion.Text) + Convert.ToInt32(lbSalud.Text) + Convert.ToInt32(lbvoluntaria.Text)).ToString();
                    lbliquido.Text = ( Convert.ToInt32(lbTotalhaberes.Text) - Convert.ToInt32(lbtotaldescuentos.Text) ).ToString();
                    txtTotal.Text = (Convert.ToInt32(lbliquido.Text) - Convert.ToInt32(lbanticipos.Text)).ToString();
                    lbempleador.Text = empleador;
                    lbfecha.Text = "FECHA          :"+DateTime.Now.ToString() ;

                }else
                {
                    MessageBox.Show("RUT NO ENCONTRADO");
                }
                
            }
            else
            {
                MessageBox.Show("Rut Incorrecto porfavor reingrese");
            }

        }
    }
}
