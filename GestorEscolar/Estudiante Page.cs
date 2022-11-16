using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorEscolar
{
    public partial class EstudiantePage : MaterialSkin.Controls.MaterialForm
    {

        public static List<Usuarios> _Usuarios = new List<Usuarios>();
        public EstudiantePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNotas.CurrentRow.Cells["ColumnN1"].Value = 2;
            dgvNotas.CurrentRow.Cells["ColumnN2"].Value = 3;
            dgvNotas.CurrentRow.Cells["ColumnN3"].Value = 4;
            dgvNotas.CurrentRow.Cells["ColumnN4"].Value = 4;
            dgvNotas.CurrentRow.Cells["ColumnP¨rom"].Value = (int.Parse(dgvNotas.CurrentRow.Cells["ColumnN1"].Value.ToString()+ int.Parse(dgvNotas.CurrentRow.Cells["ColumnN2"].Value.ToString()+ int.Parse(dgvNotas.CurrentRow.Cells["ColumnN3"].Value.ToString()+ int.Parse(dgvNotas.CurrentRow.Cells["ColumnN4"].Value.ToString())))))/4;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            StreamReader sr3 = new StreamReader(".\\estudiantes.txt");
            string line3 = null;
            line3 = sr3.ReadLine();

            string[] vec3 = line3.Split(';');
            _Usuarios.Add(new Usuarios(vec3[0], vec3[1], vec3[2], vec3[3], vec3[4]));
            line3 = sr3.ReadLine();


            foreach (Usuarios v3 in _Usuarios)
            {
                lblName.Text = v3.name;

               

                
            }
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

