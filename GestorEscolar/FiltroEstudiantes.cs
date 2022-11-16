using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GestorEscolar
{
    public partial class FiltroEstudiantes : UserControl
    {

        public static List<Usuarios> _Usuarios = new List<Usuarios>();

        string nomb = "", doc = "", clave = "", contac = "", role = "";

        bool Validar, ValId;

        public FiltroEstudiantes()
        {
            InitializeComponent();
        }

        private void flpPrincipal_Paint(object sender, PaintEventArgs e)
        {
            StreamReader sr = new StreamReader(".\\estudiantes.txt");
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string[] leer = line.Split(';');

                dgvEstudiantes.Rows.Add(leer);
            }
            sr.Close();
        }



        private void btnMod_Click(object sender, EventArgs e)
        {
            

        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEstudiantes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvEstudiantes.Rows)
                {

                    txtNomb.Text = dgvEstudiantes.CurrentRow.Cells["ColumnName"].Value.ToString();
                    txtContacto.Text = dgvEstudiantes.CurrentRow.Cells["ColumnContacto"].Value.ToString();
                    txtDoc.Text = dgvEstudiantes.CurrentRow.Cells["ColumnId"].Value.ToString();
                    cbRole.Text = dgvEstudiantes.CurrentRow.Cells["ColumnRole"].Value.ToString();
                    txtPass.Text = dgvEstudiantes.CurrentRow.Cells["ColumnPass"].Value.ToString();
                }

                desactBtn();
            }
            catch { }

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
            else if (_role == "" || _role != "estudiante")
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            string question = "¿Eliminar este usuario?";
            string title = "Eliminar usuario";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(question, title, buttons);

            if (result == DialogResult.Yes)
            {
                dgvEstudiantes.Rows.RemoveAt(dgvEstudiantes.CurrentRow.Index);

                foreach (Usuarios del in _Usuarios)
                {

                    string nom = dgvEstudiantes.CurrentRow.Cells["ColumnName"].Value.ToString();
                    string id = dgvEstudiantes.CurrentRow.Cells["ColumnId"].Value.ToString();
                    string pass = dgvEstudiantes.CurrentRow.Cells["ColumnPass"].Value.ToString();
                    string role = dgvEstudiantes.CurrentRow.Cells["ColumnRole"].Value.ToString();
                    string contac = dgvEstudiantes.CurrentRow.Cells["ColumnContacto"].Value.ToString();
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


            

        }

        static void Db()
        {
            StreamWriter db = new StreamWriter(".\\estudiantes.txt");
            foreach (Usuarios x in _Usuarios)
            {
                db.WriteLine($"{x.name};{x.id};{x.pass};{x.role};{x.contact}");

            }
            db.Close();
        }

        private void flpEstudiantes_Paint(object sender, PaintEventArgs e)
        {

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

                        dgvEstudiantes.Rows.Add(nomb, doc, clave, role, contac);
                        MessageBox.Show("¡Usuario registrado con éxito!");
                        Limpiar();

                    }

                }

        }

        private void btnMod_Click_1(object sender, EventArgs e)
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
                if (doc != dgvEstudiantes.CurrentRow.Cells["ColumnId"].Value.ToString())
                {
                    ValId = ValidarId(doc);
                }

                if (ValId == true)
                {

                    dgvEstudiantes.CurrentRow.Cells["ColumnName"].Value = nomb;
                    dgvEstudiantes.CurrentRow.Cells["ColumnId"].Value = doc;
                    dgvEstudiantes.CurrentRow.Cells["ColumnPass"].Value = clave;
                    dgvEstudiantes.CurrentRow.Cells["ColumnRole"].Value = role;
                    dgvEstudiantes.CurrentRow.Cells["ColumnContacto"].Value = contac;
                    MessageBox.Show("Usuario modificado correctamente");
                    actBtn();
                    Limpiar();

                }

            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEstudiantes.RowCount; i++)
            {

                string nom = dgvEstudiantes.Rows[i].Cells["ColumnName"].Value.ToString();
                string id = dgvEstudiantes.Rows[i].Cells["ColumnId"].Value.ToString();
                string pass = dgvEstudiantes.Rows[i].Cells["ColumnPass"].Value.ToString();
                string role = dgvEstudiantes.Rows[i].Cells["ColumnRole"].Value.ToString();
                string contac = dgvEstudiantes.Rows[i].Cells["ColumnContacto"].Value.ToString();
                _Usuarios.Add(new Usuarios(nom, id, pass, role, contac));

                Db();

            }
            MessageBox.Show("Datos guardados");
        }


        private void dgvEstudiantes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbDirectivos_Enter(object sender, EventArgs e)
        {

        }



        //Validación para no permitir documentos repetidos
        public bool ValidarId(string _doc)
        {

            ValId = true;

            for (int i = 0; i < dgvEstudiantes.RowCount; i++)
            {
                foreach (DataGridViewRow row in dgvEstudiantes.Rows)
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


