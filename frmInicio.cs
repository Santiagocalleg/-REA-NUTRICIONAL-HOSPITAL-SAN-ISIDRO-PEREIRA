namespace ÁREA_NUTRICIONAL_HOSPITAL_SAN_ISIDRO_PEREIRA
{
    public partial class frmInicio : Form
    {
        string Usuario = "Santiago.calleg";
        string Contraseña = "1234";
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBxUsuario.Text !=Usuario || textBox2.Text !=Contraseña)
            {
                if(txtBxUsuario.Text !=Usuario)
                {
                    MessageBox.Show("Usuario Incorrecto");
                    txtBxUsuario.Clear();
                    txtBxUsuario.Focus();
                    return;
                }
                if(textBox2.Text !=Contraseña)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    textBox2.Clear();
                    textBox2.Focus();
                    return;
                }
           
            }
            else
            {
                txtBxUsuario.Clear();
                textBox2.Clear();
                frmOpciones Form = new frmOpciones();
                this.Hide();
                Form.ShowDialog();
                
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
             Application.Exit();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contactese con soporte técnico");
        }

        
    }
}