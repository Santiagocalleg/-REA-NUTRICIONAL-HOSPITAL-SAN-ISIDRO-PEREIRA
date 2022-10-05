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
            tlStrpLblConsultar.Enabled = false;
            tlStrpLbleliminar.Enabled = false;
        }
private void tlStrpLblRegistrar_Click(object sender, EventArgs e)
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
            miCaracterizacion.Nombrescompletos = txtBxNombre.Text;
            miCaracterizacion.Apellidoscompletos = txtBxApellido.Text;
            miCaracterizacion.Tipoidentificacion = cmbBxIdentificacion.SelectedItem.ToString();
            miCaracterizacion.Numeroidentificacion = txtBxNumeroIdentificacion.Text;
            miCaracterizacion.Paisorigen = cmbBxPais.Text;
            miCaracterizacion.Genero = cmbBxGenero.SelectedItem.ToString();
            miCaracterizacion.Fechanacimiento = dtTmPckrNacimiento.Text;
            miCaracterizacion.Edad = int.Parse(txtBxEdad.Text);
            miCaracterizacion.Estadocivil = cmbBxEstadoCivil.SelectedItem.ToString();
            miCaracterizacion.Numerohijos = int.Parse(txtBxHijos.Text);
            miCaracterizacion.Direccionresidencia = txtBxDireccion.Text;
            miCaracterizacion.Barrioresidencia = txtBxBarrio.Text;
            miCaracterizacion.Tiempopermanencia = int.Parse(txtBxPermanencia.Text);
            miCaracterizacion.Telefonocontacto = int.Parse(txtBxTelefono.Text);
            miCaracterizacion.Ocupacion = cmbBxOcupacion.Text;
            miCaracterizacion.Nivelescolaridad = cmbBxEscolaridad.SelectedItem.ToString();
            miCaracterizacion.Eps = cmbBxEPS.SelectedItem.ToString();
            miCaracterizacion.Regimen = cmbBxRegimen.SelectedItem.ToString();
            miCaracterizacion.Email = txtBxEmail.Text;
            miCaracterizacion.Contactoemergencia = int.Parse(txtBxEmergencia.Text);
            miCaracterizacion.Antecedentesmedicos = lblantecedentes.Text;
            miCaracterizacion.Convenio = cmbBxConvenio.SelectedItem.ToString();

            MiLista.Add(miCaracterizacion);
            dtGrdVwvisualizacion.DataSource = null;
            dtGrdVwvisualizacion.DataSource = MiLista;
            LimpiarControles();
            txtBxNombre.Focus();
            tlStrpLblConsultar.Enabled = true;

        }
        //Metodo para limpiar los controles
        private void LimpiarControles()
        {
            txtBxNombre.Clear();
            txtBxApellido.Clear();
            txtBxNumeroIdentificacion.Clear();
            cmbBxPais.SelectedIndex = 0;
            txtBxPermanencia.Clear();
            txtBxEdad.Clear();
            txtBxHijos.Clear();
            txtBxDireccion.Clear();
            txtBxBarrio.Clear();
            txtBxTelefono.Clear();
            cmbBxOcupacion.SelectedIndex = 0;
            cmbBxEPS.SelectedIndex = 0;
            txtBxEmail.Clear();
            txtBxEmergencia.Clear();
            chckdLstBxAntecedentes.SelectedIndex = 0;
            cmbBxIdentificacion.SelectedIndex = 0;
            cmbBxGenero.SelectedIndex = 0;
            cmbBxEstadoCivil.SelectedIndex = 0;
            cmbBxEscolaridad.SelectedIndex = 0;
            cmbBxRegimen.SelectedIndex = 0;
            cmbBxConvenio.SelectedIndex = 0;
        }
        //Validar Convenio
        private bool ValidarConvenio()
        {
            if (string.IsNullOrEmpty(cmbBxConvenio.Text))
            {
                errorProvider1.SetError(cmbBxConvenio, "Debe seleccionar un convenio");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbBxConvenio, "");
                return true;
            }
        }

        //Validar Antecedentes médicos
        private bool ValidarAntecedentes()
        {
            if (string.IsNullOrEmpty(chckdLstBxAntecedentes.Text))
            {
                errorProvider1.SetError(chckdLstBxAntecedentes, "Debe ingresar los antecedentes médicos");
                return false;
            }
            else
            {
                errorProvider1.SetError(chckdLstBxAntecedentes, "");
                return true;
            }
        }

        private bool ValidarContactoEmer()
        {
            int Telcontactoemer;
            if (!int.TryParse(txtBxEmergencia.Text, out Telcontactoemer) || txtBxEmergencia.Text == "")
            {
                errorProvider1.SetError(txtBxEmergencia, "Debe ingresar un valor numerico para el teléfono de contacto de emergencia");
                txtBxEmergencia.Clear();
                txtBxEmergencia.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxEmergencia, "");
                return true;
            }
        }

        //Validar Email
        private bool ValidarEmail()
        {
            if (string.IsNullOrEmpty(txtBxEmail.Text))
            {
                errorProvider1.SetError(txtBxEmail, "Debe ingresar el Email");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxEmail, "");
                return true;
            }
        }

        //Validar Régimen
        private bool ValidarRegimen()
        {
            if (string.IsNullOrEmpty(cmbBxRegimen.Text))
            {
                errorProvider1.SetError(cmbBxRegimen, "Debe seleccionar un régimen");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbBxRegimen, "");
                return true;
            }
        }

        //Validar La EPS
        private bool ValidarEps()
        {
            if (string.IsNullOrEmpty(cmbBxEPS.Text))
            {
                errorProvider1.SetError(cmbBxEPS, "Debe seleccionar una EPS");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbBxEPS, "");
                return true;
            }
        }

        //Validar el nivel de escolaridad
        private bool ValidarNivelescolaridad()
        {
            if (string.IsNullOrEmpty(cmbBxEscolaridad.Text))
            {
                errorProvider1.SetError(cmbBxEscolaridad, "Debe seleccionar un nivel de escolaridad");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbBxEscolaridad, "");
                return true;
            }
        }

        //Validar la Ocupación
        private bool ValidarOcupacion()
        {
            if (string.IsNullOrEmpty(cmbBxOcupacion.Text))
            {
                errorProvider1.SetError(cmbBxOcupacion, "Debe ingresar la ocupación");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbBxOcupacion, "");
                return true;
            }
        }

        //Validar Teléfono de contacto
        private bool ValidarTelefonocontacto()
        {
            int Telcontacto;
            if (!int.TryParse(txtBxTelefono.Text, out Telcontacto) || txtBxTelefono.Text == "")
            {
                errorProvider1.SetError(txtBxTelefono, "Debe ingresar un valor numerico para el teléfono de contacto");
                txtBxTelefono.Clear();
                txtBxTelefono.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxTelefono, "");
                return true;
            }
        }

        //Validar Barrio
        private bool ValidarBarrio()
        {
            if (string.IsNullOrEmpty(txtBxBarrio.Text))
            {
                errorProvider1.SetError(txtBxBarrio, "Debe ingresar el barrio de residencia");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxBarrio, "");
                return true;
            }
        }

        //Validar Dirección de Residencia
        private bool ValidarDireccion()
        {
            if (string.IsNullOrEmpty(txtBxDireccion.Text))
            {
                errorProvider1.SetError(txtBxDireccion, "Debe ingresar la dirección de residencia");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxDireccion, "");
                return true;
            }
        }

        //Validar Numero de Hijos
        private bool ValidarNumerohijos()
        {
            int Hijos;
            if (!int.TryParse(txtBxHijos.Text, out Hijos) || txtBxHijos.Text == "")
            {
                errorProvider1.SetError(txtBxHijos, "Debe ingresar un valor numerico para el numero de hijos");
                txtBxHijos.Clear();
                txtBxHijos.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxHijos, "");
                return true;
            }
        }

        //Validar Estado Civil
        private bool ValidarEstadocivil()
        {
            if (string.IsNullOrEmpty(cmbBxEstadoCivil.Text))
            {
                errorProvider1.SetError(cmbBxEstadoCivil, "Debe seleccionar un tipo de Estado Civil");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbBxEstadoCivil, "");
                return true;
            }
        }

        //Validar Edad
        private bool ValidarEdad()
        {
            int Edad;
            if (!int.TryParse(txtBxEdad.Text, out Edad) || txtBxEdad.Text == "")
            {
                errorProvider1.SetError(txtBxEdad, "Debe ingresar un valor numerico para la edad");
                txtBxEdad.Clear();
                txtBxEdad.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxEdad, "");
                return true;
            }
        }

        //Validar Fecha de Nacimiento
        private bool ValidarFechanacimiento()
        {
            if (string.IsNullOrEmpty(dtTmPckrNacimiento.Text))
            {
                errorProvider1.SetError(dtTmPckrNacimiento, "Debe ingresar la fecha de Nacimiento");
                return false;
            }
            else
            {
                errorProvider1.SetError(dtTmPckrNacimiento, "");
                return true;
            }
        }

        //Validar Género
        private bool ValidarGenero()
        {
            if (string.IsNullOrEmpty(cmbBxGenero.Text))
            {
                errorProvider1.SetError(cmbBxGenero, "Debe seleccionar un tipo de Género");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbBxGenero, "");
                return true;
            }
        }

        //Validar Tiempo de Permanencia 
        private bool ValidarTiempopermanencia()
        {
            int Tiempoper;
            if(!int.TryParse(txtBxPermanencia.Text, out Tiempoper)||txtBxPermanencia.Text=="")
            {
                errorProvider1.SetError(txtBxPermanencia, "Debe ingresar un valor numerico para el tiempo de permanencia");
                txtBxPermanencia.Clear();
                txtBxPermanencia.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxPermanencia, "");
                return true;
            }
        }

        //Validar País de Origen
        private bool ValidarPaisorigen()
        {
            if (string.IsNullOrEmpty(cmbBxPais.Text))
            {
                errorProvider1.SetError(cmbBxPais, "Debe ingresar el País de Origen");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbBxPais, "");
                return true;
            }
        }

        //Validar Numero de Identificación
        private bool ValidarNumeroidentificacion()
        {
            if (string.IsNullOrEmpty(txtBxNumeroIdentificacion.Text))
            {
                errorProvider1.SetError(txtBxNumeroIdentificacion, "Debe ingresar el Numero de identificación");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxNumeroIdentificacion, "");
                return true;
            }
        }

        //Validar Tipo de Identificación
        private bool ValidarTipoidentificacion()
        {
            if(string.IsNullOrEmpty(cmbBxIdentificacion.Text))
            {
                errorProvider1.SetError(cmbBxIdentificacion, "Debe seleccionar un tipo de identificación");
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbBxIdentificacion, "");
                return true;
            }
        }

        //Validar Apellido
        private bool ValidarApellido()
        {
            if(string.IsNullOrEmpty(txtBxApellido.Text))
            {
                errorProvider1.SetError(txtBxApellido, "Debe ingresar un Apellido");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxApellido, "");
                return true;
            }
        }

        // Validar el Nombre
        private bool ValidarNombre()
        {
            if(string.IsNullOrEmpty(txtBxNombre.Text))
            {
                errorProvider1.SetError(txtBxNombre, "Debe ingresar un Nombre");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBxNombre, "");
                return true;
            }
        }



        private void tlStrpLblConsultar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre()==false)
            {
                return;
            }
            ClsLista miCaracterizacion = GetCaracterizacion(txtBxNombre.Text);
            if (miCaracterizacion == null)
            {
                errorProvider1.SetError(txtBxNombre, "El nombre no se encuentra registrado en la lista");
                LimpiarControles();
                txtBxNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtBxNombre, "");
                txtBxNombre.Text = miCaracterizacion.Nombrescompletos;
                txtBxApellido.Text = miCaracterizacion.Apellidoscompletos;
                txtBxNumeroIdentificacion.Text = miCaracterizacion.Numeroidentificacion;
                cmbBxPais.Text = miCaracterizacion.Paisorigen;
                txtBxPermanencia.Text = miCaracterizacion.Tiempopermanencia.ToString();
                dtTmPckrNacimiento.Text = miCaracterizacion.Fechanacimiento;
                txtBxEdad.Text = miCaracterizacion.Edad.ToString();
                txtBxHijos.Text = miCaracterizacion.Numerohijos.ToString();
                txtBxDireccion.Text = miCaracterizacion.Direccionresidencia;
                txtBxBarrio.Text = miCaracterizacion.Barrioresidencia;
                txtBxTelefono.Text = miCaracterizacion.Telefonocontacto.ToString();
                cmbBxOcupacion.Text = miCaracterizacion.Ocupacion;
                cmbBxEPS.Text = miCaracterizacion.Eps;
                txtBxEmail.Text = miCaracterizacion.Email;
                txtBxEmergencia.Text = miCaracterizacion.Contactoemergencia.ToString();
                chckdLstBxAntecedentes.Text = miCaracterizacion.Antecedentesmedicos;
                cmbBxIdentificacion.SelectedItem = miCaracterizacion.Tipoidentificacion;
                cmbBxGenero.SelectedItem = miCaracterizacion.Genero;
                cmbBxEstadoCivil.SelectedItem = miCaracterizacion.Estadocivil;
                cmbBxEscolaridad.SelectedItem = miCaracterizacion.Nivelescolaridad;
                cmbBxRegimen.SelectedItem = miCaracterizacion.Regimen;
                cmbBxConvenio.SelectedItem = miCaracterizacion.Convenio;
                tlStrpLbleliminar.Enabled = true;
            }

        }
        //Consultar Nombre
        private ClsLista GetCaracterizacion(string nombre)
        {
            return MiLista.Find(nombrec => nombrec.Nombrescompletos.Contains(nombre));
        }


        private void tlStrpLbleliminar_Click(object sender, EventArgs e)
        {

            if (txtBxNombre.Text == "")
            {
                errorProvider1.SetError(txtBxNombre, "Debe consultar la persona a eliminar");
                LimpiarControles();
                txtBxNombre.Focus();
                tlStrpLbleliminar.Enabled = false;
                return;
            }
            else
            {
                errorProvider1.SetError(txtBxNombre, "");
                DialogResult Respuesta = MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (ClsLista miCaracterizacion in MiLista)
                    {
                        if (miCaracterizacion.Nombrescompletos == txtBxNombre.Text)
                        {
                            MiLista.Remove(miCaracterizacion);
                            break;
                        }
                    }
                    LimpiarControles();
                    dtGrdVwvisualizacion.DataSource = null;
                    dtGrdVwvisualizacion.DataSource = MiLista;
                }
            }
        }

        private void tlStrpLblregresar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el formulario activo
            frmOpciones frm = new frmOpciones();
            frm.Show();
        }

        private void tlStrpLblsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
