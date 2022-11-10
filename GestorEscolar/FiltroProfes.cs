using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorEscolar
{
    public partial class FiltroProfes : UserControl
    {
        string nomb = "", doc = "", clave = "", contac = "";

        bool Validar, ValId;

        public FiltroProfes()
        {
            InitializeComponent();
        }


        private void flpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            nomb = txtNomb.Text;
            doc = txtDoc.Text;
            clave = txtPass.Text;
            contac = txtContacto.Text;
            Validar = ValidarDatos(nomb, doc, clave, contac);
            ValId = true;

            if (Validar == true)
            {
                if (doc != dgvProfes.CurrentRow.Cells["ColumnId"].Value.ToString())
                {
                    ValId = ValidarId(doc);
                }

                if (ValId == true)
                {

                    dgvProfes.CurrentRow.Cells["ColumnName"].Value = nomb;
                    dgvProfes.CurrentRow.Cells["ColumnId"].Value = doc;
                    dgvProfes.CurrentRow.Cells["ColumnPass"].Value = clave;
                    dgvProfes.CurrentRow.Cells["ColumnContacto"].Value = contac;
                    MessageBox.Show("Usuario modificado correctamente");
                    actBtn();
                    Limpiar();

                }

            }

        }



        private void dgvDirectivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDirectivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvProfes.Rows)
                {

                    txtNomb.Text = dgvProfes.CurrentRow.Cells["ColumnName"].Value.ToString();
                    txtContacto.Text = dgvProfes.CurrentRow.Cells["ColumnContacto"].Value.ToString();
                    txtDoc.Text = dgvProfes.CurrentRow.Cells["ColumnId"].Value.ToString();
                    txtPass.Text = dgvProfes.CurrentRow.Cells["ColumnPass"].Value.ToString();


                }

                desactBtn();
            }
            catch { }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nomb = txtNomb.Text;
            doc = txtDoc.Text;
            clave = txtPass.Text;
            contac = txtContacto.Text;
            Validar = ValidarDatos(nomb, doc, clave, contac);

            if (Validar == true)
            {
                ValId = ValidarId(doc);
                if (ValId == true)
                {

                    dgvProfes.Rows.Add(nomb, doc, clave, contac);
                    MessageBox.Show("¡Usuario registrado con éxito!");
                    Limpiar();

                }

            }


        }

        //validación a la hora de registrar datos
        public bool ValidarDatos(string _nomb, string _doc, string _clave, string _contac)
        {
            if (_nomb == "")
            {
                MessageBox.Show("Falta ingresar nombre");
                errorProviderValidar.SetError(txtNomb, "Ingrese un nombre: ");
                Validar = false;

            }
            else if (_doc == "")
            {

                MessageBox.Show("Falta ingresar documento");
                errorProviderValidar.SetError(txtDoc, "Ingrese el documento: ");
                Validar = false;

            }
            else if (_clave == "")
            {

                MessageBox.Show("Falta ingresar contraseña");
                errorProviderValidar.SetError(txtPass, "Ingrese la contraseña: ");
                Validar = false;

            }
            else if (_contac == "")
            {

                MessageBox.Show("Falta ingresar número de contacto");
                errorProviderValidar.SetError(txtContacto, "Ingrese el número de contacto: ");
                Validar = false;

            }
            else
            {
                Validar = true;
                errorProviderValidar.SetError(txtNomb, "");
                errorProviderValidar.SetError(txtDoc, "");
                errorProviderValidar.SetError(txtPass, "");
                errorProviderValidar.SetError(txtContacto, "");
            }


            return Validar;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string question = "¿Eliminar este usuario?";
            string title = "Eliminar usuario";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(question, title, buttons);

            if (result == DialogResult.Yes)
            {
                dgvProfes.Rows.RemoveAt(dgvProfes.CurrentRow.Index);
                MessageBox.Show("Usuario eliminado correctamente.");
                actBtn();
                Limpiar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void flpProfesores_Paint(object sender, PaintEventArgs e)
        {

        }



        //Validación para no permitir documentos repetidos
        public bool ValidarId(string _doc)
        {

            ValId = true;

            for (int i = 0; i < dgvProfes.RowCount; i++)
            {
                foreach (DataGridViewRow row in dgvProfes.Rows)
                {
                    string strFila = ColumnId.Index.ToString();
                    string valor = Convert.ToString(row.Cells["ColumnId"].Value);

                    if (valor == _doc)
                    {
                        MessageBox.Show("Ya existe este documento: ");
                        errorProviderValidar.SetError(txtDoc, "Ingrese otro documento");
                        ValId = false;
                        break;

                    }
                    else
                    {
                        errorProviderValidar.SetError(txtDoc, "");
                        ValId = true;
                    }
                }

            }
            return ValId;
        }

        private void Limpiar()
        {
            txtNomb.Text = "";
            txtDoc.Text = "";
            txtPass.Text = "";
            txtContacto.Text = "";
        }

        private void actBtn()
        {

            btnAdd.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnMod.Enabled = false;

        }

        private void desactBtn()
        {
            btnAdd.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;
            btnMod.Enabled = true;
        }

    }
}