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
    public partial class frmOpciones : Form
    {
        public frmOpciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCaracterizacion Form = new frmCaracterizacion();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmIMC Form = new frmIMC();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCalorias Form = new frmCalorias();
            Form.ShowDialog();
        }
    }
}
