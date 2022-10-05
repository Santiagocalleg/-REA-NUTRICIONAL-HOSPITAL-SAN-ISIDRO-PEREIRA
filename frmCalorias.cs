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
        private void txbxedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
        private void txtBxaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtBxpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
        public frmCalorias()
        {
            InitializeComponent();
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

        private void bttnconsultar_Click(object sender, EventArgs e)
        {
            double Altura = 0.0;
            double Peso = 0.0;
            double Edad = 0.0;
            double Resultado = 0.0;

            Altura = Convert.ToDouble(txtBxaltura.Text);
            Peso = Convert.ToDouble(txtBxpeso.Text);
            Edad = Convert.ToDouble(txbxedad.Text);
            
            if (rdBttnhombre.Checked == true && rdBttnpoco.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5)*1.2;
            }
            if (rdBttnhombre.Checked == true && rdBttnligero.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5) * 1.375;
            }
            if (rdBttnhombre.Checked == true && rdBttnmoderado.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5) * 1.55;
            }
            if (rdBttnhombre.Checked == true && rdBttnfuerte.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5) * 1.725;
            }
            if (rdBttnhombre.Checked == true && rdBttnmuyfuerte.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5) * 1.9;
            }
            if (rdBttnmujer.Checked == true && rdBttnpoco.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161)* 1.2;
            }
            if (rdBttnmujer.Checked == true && rdBttnligero.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161) * 1.375;
            }
            if (rdBttnmujer.Checked == true && rdBttnmoderado.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161) * 1.55;
            }
            if (rdBttnmujer.Checked == true && rdBttnfuerte.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161) * 1.725;
            }
            if (rdBttnmujer.Checked == true && rdBttnmuyfuerte.Checked == true)
            {
                Resultado = ((10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161) * 1.9;
            }

            lstBxresultado.Items.Add("El consumo minimo de calorias debe ser: "+(Math.Round (Resultado)));


        }

               
    }
}
