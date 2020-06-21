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
    public partial class formPrevision : Form
    {
        DataTable tabla_prevision = new DataTable();
        public formPrevision()
        {
            
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jgonz\\source\\repos\\LiquidacionSueldoGonzalezJose\\LiquidacionSueldoGonzalezJose\\Database1.mdf;Integrated Security=True");
            conn.Open();
            string query = "select * from TBPREVISION";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(tabla_prevision);
            conn.Close();
            dataGridView1.DataSource = tabla_prevision;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            float comision;
            string nombre;
            comision = float.Parse(txtcomision.Text);
            DataTable datos = new DataTable();
            nombre = txtnombre.Text.ToString();
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jgonz\\source\\repos\\LiquidacionSueldoGonzalezJose\\LiquidacionSueldoGonzalezJose\\Database1.mdf;Integrated Security=True");
            conn.Open();
            string query = "insert into TBPREVISION (NOMBRE, COMISION) values ( '"+nombre+"',"+ comision +" ) ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            datos.Clear();
            adapter.Fill(datos);

            string query2 = "select * from TBPREVISION";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            adapter.Fill(tabla_prevision);
            dataGridView1.DataSource = tabla_prevision;
            conn.Close();
            
        }
    }
}
