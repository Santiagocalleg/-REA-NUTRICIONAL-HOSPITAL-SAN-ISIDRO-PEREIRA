using System.Data.SqlClient;

namespace ÁREA_NUTRICIONAL_HOSPITAL_SAN_ISIDRO_PEREIRA
{
    public partial class frmInicio : Form
    {
       
        public frmInicio()
        {
            InitializeComponent();
        }


        SqlConnection cone = new SqlConnection("Data Source=(localdb)\\Servidor; Initial Catalog=nutricion");


        private void bttnIngresar_Click(object sender, EventArgs e)
        {
            cone.Open();


            try
            {
                SqlCommand conn = new SqlCommand("SELECT password FROM usuarios WHERE usuario = @usuario AND estado = @estado", cone);
                conn.Parameters.AddWithValue("usuario", txtBxUsuario.Text);
                conn.Parameters.AddWithValue("estado", 1);
                SqlDataReader response = conn.ExecuteReader();

                if (response.Read())
                {
                    if (txtBxContraseña.Text.Equals(response["password"]))
                    {
                        frmOpciones view = new frmOpciones();
                        view.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrectos");
                    }

                }
                else
                {
                    MessageBox.Show("Usuario incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos");
            }
            // Cerrar conexión a base de datos
            cone.Close();
        }

        private void pctrBxcerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void lnkLblOlvidoContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contactese con soporte técnico");
        }


    }
}