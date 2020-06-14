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
                for(int i=0; i<registro.Rows.Count; i++)
                {
                    txtnombre.Text = registro.Rows[i]["NOMBRE"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Rut Incorrecto porfavor reingrese");
            }

        }
    }
}
