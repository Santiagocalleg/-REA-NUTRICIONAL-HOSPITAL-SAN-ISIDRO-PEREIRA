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
    public partial class frmCaracterizacion : Form
    {
        List<ClsLista> MiLista = new List<ClsLista>();
        public frmCaracterizacion()
        {
            InitializeComponent();
            toolStripLabel2.Enabled = false;
            toolStripLabel3.Enabled = false;
        }
private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            if (ValidarNombre() == false)
            {
                return;
            }
            if (ValidarApellido() == false)
            {
                return;
            }
            if (ValidarTipoidentificacion() == false)
            {
                return;
            }
            if (ValidarNumeroidentificacion() == false)
            {
                return;
            }
            if (ValidarPaisorigen() == false)
            {
                return;
            }
            if (ValidarTiempopermanencia() == false)
            {
                return;
            }
            if (ValidarGenero() == false)
            {
                return;
            }
            if (ValidarFechanacimiento() == false)
            {
                return;
            }
            if (ValidarEdad() == false)
            {
                return;
            }
            if (ValidarEstadocivil() == false)
            {
                return;
            }
            if (ValidarNumerohijos() == false)
            {
                return;
            }
            if (ValidarDireccion() == false)
            {
                return;
            }
            if (ValidarBarrio() == false)
            {
                return;
            }
            if (ValidarTelefonocontacto() == false)
            {
                return;
            }
            if (ValidarOcupacion() == false)
            {
                return;
            }
            if (ValidarNivelescolaridad() == false)
            {
                return;
            }
            if (ValidarEps() == false)
            {
                return;
            }
            if (ValidarRegimen() == false)
            {
                return;
            }
            if (ValidarEmail() == false)
            {
                return;
            }
            if (ValidarContactoEmer() == false)
            {
                return;
            }
            if (ValidarAntecedentes() == false)
            {
                return;
            }
            if (ValidarConvenio() == false)
            {
                return;
            }

            //Creamos el objeto de la clase lista
            ClsLista miCaracterizacion = new ClsLista();
            miCaracterizacion.Nombrescompletos = textBox1.Text;
            miCaracterizacion.Apellidoscompletos = textBox2.Text;
            miCaracterizacion.Tipoidentificacion = comboBox1.SelectedItem.ToString();
            miCaracterizacion.Numeroidentificacion = textBox3.Text;
            miCaracterizacion.Paisorigen = comboBox8.Text;
            miCaracterizacion.Tiempopermanencia = int.Parse(textBox5.Text);
            miCaracterizacion.Genero = comboBox2.SelectedItem.ToString();
            miCaracterizacion.Fechanacimiento = dateTimePicker1.Text;
            miCaracterizacion.Edad = int.Parse(textBox7.Text);
            miCaracterizacion.Estadocivil = comboBox3.SelectedItem.ToString();
            miCaracterizacion.Numerohijos = int.Parse(textBox8.Text);
            miCaracterizacion.Direccionresidencia = textBox9.Text;
            miCaracterizacion.Barrioresidencia = textBox10.Text;
            miCaracterizacion.Telefonocontacto = int.Parse(textBox11.Text);
            miCaracterizacion.Ocupacion = comboBox7.Text;
            miCaracterizacion.Nivelescolaridad = comboBox4.SelectedItem.ToString();
            miCaracterizacion.Eps = textBox13.Text;
            miCaracterizacion.Regimen = comboBox5.SelectedItem.ToString();
            miCaracterizacion.Email = textBox14.Text;
            miCaracterizacion.Contactoemergencia = int.Parse(textBox15.Text);
            miCaracterizacion.Antecedentesmedicos = label21.Text;
            miCaracterizacion.Convenio = comboBox6.SelectedItem.ToString();

            MiLista.Add(miCaracterizacion);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MiLista;
            LimpiarControles();
            textBox1.Focus();
            toolStripLabel2.Enabled = true;

        }
        //Metodo para limpiar los controles
        private void LimpiarControles()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox8.SelectedIndex = 0;
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            comboBox7.SelectedIndex = 0;
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            checkedListBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
        }
        //Validar Convenio
        private bool ValidarConvenio()
        {
            if (string.IsNullOrEmpty(comboBox6.Text))
            {
                errorProvider1.SetError(comboBox6, "Debe seleccionar un convenio");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox6, "");
                return true;
            }
        }

        //Validar Antecedentes médicos
        private bool ValidarAntecedentes()
        {
            if (string.IsNullOrEmpty(checkedListBox1.Text))
            {
                errorProvider1.SetError(checkedListBox1, "Debe ingresar los antecedentes médicos");
                return false;
            }
            else
            {
                errorProvider1.SetError(checkedListBox1, "");
                return true;
            }
        }

        private bool ValidarContactoEmer()
        {
            int Telcontactoemer;
            if (!int.TryParse(textBox15.Text, out Telcontactoemer) || textBox15.Text == "")
            {
                errorProvider1.SetError(textBox15, "Debe ingresar un valor numerico para el teléfono de contacto de emergencia");
                textBox15.Clear();
                textBox15.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox15, "");
                return true;
            }
        }

        //Validar Email
        private bool ValidarEmail()
        {
            if (string.IsNullOrEmpty(textBox14.Text))
            {
                errorProvider1.SetError(textBox14, "Debe ingresar el Email");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox14, "");
                return true;
            }
        }

        //Validar Régimen
        private bool ValidarRegimen()
        {
            if (string.IsNullOrEmpty(comboBox5.Text))
            {
                errorProvider1.SetError(comboBox5, "Debe seleccionar un régimen");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox5, "");
                return true;
            }
        }

        //Validar La EPS
        private bool ValidarEps()
        {
            if (string.IsNullOrEmpty(textBox13.Text))
            {
                errorProvider1.SetError(textBox13, "Debe ingresar la EPS");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox13, "");
                return true;
            }
        }

        //Validar el nivel de escolaridad
        private bool ValidarNivelescolaridad()
        {
            if (string.IsNullOrEmpty(comboBox4.Text))
            {
                errorProvider1.SetError(comboBox4, "Debe seleccionar un nivel de escolaridad");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox4, "");
                return true;
            }
        }

        //Validar la Ocupación
        private bool ValidarOcupacion()
        {
            if (string.IsNullOrEmpty(comboBox7.Text))
            {
                errorProvider1.SetError(comboBox7, "Debe ingresar la ocupación");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox7, "");
                return true;
            }
        }

        //Validar Teléfono de contacto
        private bool ValidarTelefonocontacto()
        {
            int Telcontacto;
            if (!int.TryParse(textBox11.Text, out Telcontacto) || textBox11.Text == "")
            {
                errorProvider1.SetError(textBox11, "Debe ingresar un valor numerico para el teléfono de contacto");
                textBox11.Clear();
                textBox11.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox11, "");
                return true;
            }
        }

        //Validar Barrio
        private bool ValidarBarrio()
        {
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                errorProvider1.SetError(textBox10, "Debe ingresar el barrio de residencia");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox10, "");
                return true;
            }
        }

        //Validar Dirección de Residencia
        private bool ValidarDireccion()
        {
            if (string.IsNullOrEmpty(textBox9.Text))
            {
                errorProvider1.SetError(textBox9, "Debe ingresar la dirección de residencia");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox9, "");
                return true;
            }
        }

        //Validar Numero de Hijos
        private bool ValidarNumerohijos()
        {
            int Hijos;
            if (!int.TryParse(textBox8.Text, out Hijos) || textBox8.Text == "")
            {
                errorProvider1.SetError(textBox8, "Debe ingresar un valor numerico para el numero de hijos");
                textBox8.Clear();
                textBox8.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox8, "");
                return true;
            }
        }

        //Validar Estado Civil
        private bool ValidarEstadocivil()
        {
            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                errorProvider1.SetError(comboBox3, "Debe seleccionar un tipo de Estado Civil");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox3, "");
                return true;
            }
        }

        //Validar Edad
        private bool ValidarEdad()
        {
            int Edad;
            if (!int.TryParse(textBox7.Text, out Edad) || textBox7.Text == "")
            {
                errorProvider1.SetError(textBox7, "Debe ingresar un valor numerico para la edad");
                textBox7.Clear();
                textBox7.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox7, "");
                return true;
            }
        }

        //Validar Fecha de Nacimiento
        private bool ValidarFechanacimiento()
        {
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                errorProvider1.SetError(dateTimePicker1, "Debe ingresar la fecha de Nacimiento");
                return false;
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, "");
                return true;
            }
        }

        //Validar Género
        private bool ValidarGenero()
        {
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                errorProvider1.SetError(comboBox2, "Debe seleccionar un tipo de Género");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox2, "");
                return true;
            }
        }

        //Validar Tiempo de Permanencia 
        private bool ValidarTiempopermanencia()
        {
            int Tiempoper;
            if(!int.TryParse(textBox5.Text, out Tiempoper)||textBox5.Text=="")
            {
                errorProvider1.SetError(textBox5, "Debe ingresar un valor numerico para el tiempo de permanencia");
                textBox5.Clear();
                textBox5.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
                return true;
            }
        }

        //Validar País de Origen
        private bool ValidarPaisorigen()
        {
            if (string.IsNullOrEmpty(comboBox8.Text))
            {
                errorProvider1.SetError(comboBox8, "Debe ingresar el País de Origen");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox8, "");
                return true;
            }
        }

        //Validar Numero de Identificación
        private bool ValidarNumeroidentificacion()
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Debe ingresar el Numero de identificación");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
                return true;
            }
        }

        //Validar Tipo de Identificación
        private bool ValidarTipoidentificacion()
        {
            if(string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "Debe seleccionar un tipo de identificación");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
                return true;
            }
        }

        //Validar Apellido
        private bool ValidarApellido()
        {
            if(string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Debe ingresar un Apellido");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
                return true;
            }
        }

        // Validar el Nombre
        private bool ValidarNombre()
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Debe ingresar un Nombre");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                return true;
            }
        }



        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (ValidarNombre()==false)
            {
                return;
            }
            ClsLista miCaracterizacion = GetCaracterizacion(textBox1.Text);
            if (miCaracterizacion == null)
            {
                errorProvider1.SetError(textBox1, "El nombre no se encuentra registrado en la lista");
                LimpiarControles();
                textBox1.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                textBox1.Text = miCaracterizacion.Nombrescompletos;
                textBox2.Text = miCaracterizacion.Apellidoscompletos;
                textBox3.Text = miCaracterizacion.Numeroidentificacion;
                comboBox8.Text = miCaracterizacion.Paisorigen;
                textBox5.Text = miCaracterizacion.Tiempopermanencia.ToString();
                dateTimePicker1.Text = miCaracterizacion.Fechanacimiento;
                textBox7.Text = miCaracterizacion.Edad.ToString();
                textBox8.Text = miCaracterizacion.Numerohijos.ToString();
                textBox9.Text = miCaracterizacion.Direccionresidencia;
                textBox10.Text = miCaracterizacion.Barrioresidencia;
                textBox11.Text = miCaracterizacion.Telefonocontacto.ToString();
                comboBox7.Text = miCaracterizacion.Ocupacion;
                textBox13.Text = miCaracterizacion.Eps;
                textBox14.Text = miCaracterizacion.Email;
                textBox15.Text = miCaracterizacion.Contactoemergencia.ToString();
                checkedListBox1.Text = miCaracterizacion.Antecedentesmedicos;
                comboBox1.SelectedItem = miCaracterizacion.Tipoidentificacion;
                comboBox2.SelectedItem = miCaracterizacion.Genero;
                comboBox3.SelectedItem = miCaracterizacion.Estadocivil;
                comboBox4.SelectedItem = miCaracterizacion.Nivelescolaridad;
                comboBox5.SelectedItem = miCaracterizacion.Regimen;
                comboBox6.SelectedItem = miCaracterizacion.Convenio;
                toolStripLabel3.Enabled = true;
            }

        }
        //Consultar Nombre
        private ClsLista GetCaracterizacion(string nombre)
        {
            return MiLista.Find(nombrec => nombrec.Nombrescompletos.Contains(nombre));
        }


        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Debe consultar la persona a eliminar");
                LimpiarControles();
                textBox1.Focus();
                toolStripLabel3.Enabled = false;
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                DialogResult Respuesta = MessageBox.Show("¿Está seguro de eleminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (ClsLista miCaracterizacion in MiLista)
                    {
                        if (miCaracterizacion.Nombrescompletos == textBox1.Text)
                        {
                            MiLista.Remove(miCaracterizacion);
                            break;
                        }
                    }
                    LimpiarControles();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = MiLista;
                }
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el formulario activo
            frmOpciones frm = new frmOpciones();
            frm.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
