using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÁREA_NUTRICIONAL_HOSPITAL_SAN_ISIDRO_PEREIRA
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void bttncalcular_Click(object sender, EventArgs e)
        {
            double imc, peso, altura;
            peso = double.Parse(txtBxPeso.Text);
            altura = double.Parse(txtBxEstatura.Text);
            imc = peso / (altura * altura);
            
            

            txtBxPeso.Clear();
            txtBxEstatura.Clear();
            lstBxNutricion.Items.Clear();
            lstBxIMC.Items.Clear();

            lstBxIMC.Items.Add(imc.ToString("N2"));
            if(imc < 16.00)
            {
                lstBxNutricion.Items.Add("Infrapeso, delgadez severa");
            }
            if(imc >= 16.00 && imc <= 16.99)
            {
                lstBxNutricion.Items.Add("Infrapeso, delgadez moderada");
            }
            if(imc >= 17.00 && imc <= 18.49)
            {
                lstBxNutricion.Items.Add("Infrapeso, delgadez aceptable");
            }
            if(imc >= 18.50 && imc <= 24.99)
            {
                lstBxNutricion.Items.Add("Peso normal");
            }
            if(imc >= 25.00 && imc <= 29.99)
            {
                lstBxNutricion.Items.Add("Sobrepeso");
            }
            if(imc >= 30.00 && imc <= 34.99)
            {
                lstBxNutricion.Items.Add("Obeso tipo I");
            }
            if (imc >= 35.00 && imc <= 40.00)
            {
                lstBxNutricion.Items.Add("Obeso tipo II");
            }
            if(imc > 40.00)
            {
                lstBxNutricion.Items.Add("Obeso tipo III");
            }
        }

        private void bttnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnregresar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el formulario activo
            frmOpciones frm = new frmOpciones(); 
            frm.Show();
        }
    }
}
