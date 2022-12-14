using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GestorEscolar
{
    public partial class FiltroDirectivos : UserControl
    {
        public static List<Usuarios> _Usuarios = new List<Usuarios>();

        string nomb = "", doc = "", clave = "", contac = "", role = "";

        bool Validar, ValId;

        public FiltroDirectivos()
        {
            InitializeComponent();
        }

        private void flpPrincipal_Paint(object sender, PaintEventArgs e)
        {
            StreamReader sr = new StreamReader(".\\directivos.txt");
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string[] leer = line.Split(';');

                dgvDirectivos.Rows.Add(leer);
            }
            sr.Close();
        }



        private void btnMod_Click(object sender, EventArgs e)
        {
            nomb = txtNomb.Text;
            doc = txtDoc.Text;
            clave = txtPass.Text;
            contac = txtContacto.Text;
            role = cbRole.Text;
            Validar = ValidarDatos(nomb, doc, clave, contac, role);
            ValId = true;

            if (Validar == true)
            {
                if (doc != dgvDirectivos.CurrentRow.Cells["ColumnId"].Value.ToString())
                {
                    ValId = ValidarId(doc);
                }

                if (ValId == true)
                {

                    dgvDirectivos.CurrentRow.Cells["ColumnName"].Value = nomb;
                    dgvDirectivos.CurrentRow.Cells["ColumnId"].Value = doc;
                    dgvDirectivos.CurrentRow.Cells["ColumnPass"].Value = clave;
                    dgvDirectivos.CurrentRow.Cells["ColumnRole"].Value = role;
                    dgvDirectivos.CurrentRow.Cells["ColumnContacto"].Value = contac;
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
                foreach (DataGridViewRow row in dgvDirectivos.Rows)
                {

                    txtNomb.Text = dgvDirectivos.CurrentRow.Cells["ColumnName"].Value.ToString();
                    txtContacto.Text = dgvDirectivos.CurrentRow.Cells["ColumnContacto"].Value.ToString();
                    txtDoc.Text = dgvDirectivos.CurrentRow.Cells["ColumnId"].Value.ToString();
                    cbRole.Text = dgvDirectivos.CurrentRow.Cells["ColumnRole"].Value.ToString();
                    txtPass.Text = dgvDirectivos.CurrentRow.Cells["ColumnPass"].Value.ToString();
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
            role = cbRole.Text;

            Validar = ValidarDatos(nomb, doc, clave, contac, role);

            if (Validar == true)
            {
                ValId = ValidarId(doc);
                if (ValId == true)
                {

                    dgvDirectivos.Rows.Add(nomb, doc, clave, role, contac);
                    MessageBox.Show("¡Usuario registrado con éxito!");
                    Limpiar();

                }

            }


        }

        //validación a la hora de registrar datos
        public bool ValidarDatos(string _nomb, string _doc, string _clave, string _contac, string _role)
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
            else if (_role == "" || _role != "directivo")
            {
                MessageBox.Show("Falta ingresar el rol");
                errorProviderValidar.SetError(cbRole, "Ingrese el rol ");
                Validar = false;

            }
            else
            {
                Validar = true;
                errorProviderValidar.SetError(txtNomb, "");
                errorProviderValidar.SetError(txtDoc, "");
                errorProviderValidar.SetError(txtPass, "");
                errorProviderValidar.SetError(txtContacto, "");
                errorProviderValidar.SetError(cbRole, "");
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
                dgvDirectivos.Rows.RemoveAt(dgvDirectivos.CurrentRow.Index);

                foreach (Usuarios del in _Usuarios)
                {

                    string nom = dgvDirectivos.CurrentRow.Cells["ColumnName"].Value.ToString();
                    string id = dgvDirectivos.CurrentRow.Cells["ColumnId"].Value.ToString();
                    string pass = dgvDirectivos.CurrentRow.Cells["ColumnPass"].Value.ToString();
                    string role = dgvDirectivos.CurrentRow.Cells["ColumnRole"].Value.ToString();
                    string contac = dgvDirectivos.CurrentRow.Cells["ColumnContacto"].Value.ToString();
                    _Usuarios.Remove(new Usuarios(del.name, del.id, del.pass, del.role, del.contact));
                }

                Db();


                MessageBox.Show("Usuario eliminado correctamente.");
                actBtn();
                Limpiar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
        //datos en el archivo plano
        private void btnGuardar_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < dgvDirectivos.RowCount; i++)
            {

                string nom = dgvDirectivos.Rows[i].Cells["ColumnName"].Value.ToString();
                string id = dgvDirectivos.Rows[i].Cells["ColumnId"].Value.ToString();
                string pass = dgvDirectivos.Rows[i].Cells["ColumnPass"].Value.ToString();
                string role = dgvDirectivos.Rows[i].Cells["ColumnRole"].Value.ToString();
                string contac = dgvDirectivos.Rows[i].Cells["ColumnContacto"].Value.ToString();
                _Usuarios.Add(new Usuarios(nom, id, pass, role, contac));

                Db();

            }
            MessageBox.Show("Datos guardados");

        }

        static void Db()
        {
            StreamWriter db = new StreamWriter(".\\directivos.txt");
            foreach (Usuarios x in _Usuarios)
            {
                db.WriteLine($"{x.name};{x.id};{x.pass};{x.role};{x.contact}");

            }
            db.Close();
        }






        private void gbDirectivos_Enter(object sender, EventArgs e)
        {

        }



        //Validación para no permitir documentos repetidos
        public bool ValidarId(string _doc)
        {

            ValId = true;

            for (int i = 0; i < dgvDirectivos.RowCount; i++)
            {
                foreach (DataGridViewRow row in dgvDirectivos.Rows)
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
