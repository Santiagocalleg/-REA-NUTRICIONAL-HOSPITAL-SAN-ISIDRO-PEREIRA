namespace ÁREA_NUTRICIONAL_HOSPITAL_SAN_ISIDRO_PEREIRA
{
    public partial class frmInicio : Form
    {
        string Usuario = "adm";
        string Contraseña = "1234";
        public frmInicio()
        {
            InitializeComponent();
        }


        private void bttnIngresar_Click(object sender, EventArgs e)
        {
            if(txtBxUsuario.Text !=Usuario || txtBxContraseña.Text !=Contraseña)
            {
                if(txtBxUsuario.Text !=Usuario)
                {
                    MessageBox.Show("Usuario Incorrecto");
                    txtBxUsuario.Clear();
                    txtBxUsuario.Focus();
                    return;
                }
                if(txtBxContraseña.Text !=Contraseña)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    txtBxContraseña.Clear();
                    txtBxContraseña.Focus();
                    return;
                }
           
            }
            else
            {
                txtBxUsuario.Clear();
                txtBxContraseña.Clear();
                frmOpciones Form = new frmOpciones();
                this.Hide();
                Form.ShowDialog();
                
            }
            
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