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
            if(textBox1.Text !=Usuario || textBox2.Text !=Contraseña)
            {
                if(textBox1.Text !=Usuario)
                {
                    MessageBox.Show("Usuario Incorrecto");
                    textBox1.Clear();
                    textBox1.Focus();
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
                textBox1.Clear();
                textBox2.Clear();
                frmOpciones Form = new frmOpciones();
                Form.ShowDialog();
            }
        }
    }
}