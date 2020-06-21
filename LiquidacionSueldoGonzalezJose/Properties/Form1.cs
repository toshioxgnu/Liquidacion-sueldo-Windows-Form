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
using System.Xml.Serialization;

namespace LiquidacionSueldoGonzalezJose.Properties
{
    public partial class formasalud : Form
    {
        public formasalud()
        {
            DataTable tabla_salud = new DataTable();
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jgonz\\source\\repos\\LiquidacionSueldoGonzalezJose\\LiquidacionSueldoGonzalezJose\\Database1.mdf;Integrated Security=True");
            conn.Open();
            string query = "select * from TBSALUD_DETALLE";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(tabla_salud);
            dataGridView1.DataSource = tabla_salud;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.ToString();
            DataTable datos = new DataTable();
            nombre = txtnombre.Text.ToString();
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jgonz\\source\\repos\\LiquidacionSueldoGonzalezJose\\LiquidacionSueldoGonzalezJose\\Database1.mdf;Integrated Security=True");
            conn.Open();
            string query = "insert into TBSALUD_DETALLE (ID_SALUD, NOMBRE) values ( 2,'" + nombre + "') ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            datos.Clear();
            adapter.Fill(datos);
        }
    }
}
