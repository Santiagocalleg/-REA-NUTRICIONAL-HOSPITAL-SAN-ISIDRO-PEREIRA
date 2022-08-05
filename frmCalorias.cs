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
    public partial class frmCalorias : Form
    {
        public frmCalorias()
        {
            InitializeComponent();
        }
        //hola bb
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el formulario activo
            frmOpciones frm = new frmOpciones();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Altura = 0.0;
            double Peso = 0.0;
            double Edad = 0.0;
            double Resultado = 0.0;

            Altura = Convert.ToDouble(textBox1.Text);
            Peso = Convert.ToDouble(textBox2.Text);
            Edad = Convert.ToDouble(textBox3.Text);
            
            if (radioButton1.Checked == true && radioButton4.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5)*1.2;
            }
            if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5) * 1.375;
            }
            if (radioButton1.Checked == true && radioButton5.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5) * 1.55;
            }
            if (radioButton1.Checked == true && radioButton6.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5) * 1.725;
            }
            if (radioButton1.Checked == true && radioButton7.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5) * 1.9;
            }
            if (radioButton2.Checked == true && radioButton4.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161)* 1.2;
            }
            if (radioButton2.Checked == true && radioButton3.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161) * 1.375;
            }
            if (radioButton2.Checked == true && radioButton5.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161) * 1.55;
            }
            if (radioButton2.Checked == true && radioButton6.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161) * 1.725;
            }
            if (radioButton2.Checked == true && radioButton7.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161) * 1.9;
            }

            listBox1.Items.Add(Resultado);


        }
    }
}
