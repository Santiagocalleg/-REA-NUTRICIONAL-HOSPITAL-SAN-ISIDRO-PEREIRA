using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ÁREA_NUTRICIONAL_HOSPITAL_SAN_ISIDRO_PEREIRA
{
    class Conexion
    {
        SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=(localdb)\\Servidor; Initial Catalog=nutricion;integrated security = true");
                cnx.Open();
                MessageBox.Show("Conectado correctamente", "Éxito al conectar", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message, "Error inesperado", MessageBoxButtons.OK);

            }

        }
    }

}