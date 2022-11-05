using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GestorEscolar
{
    public partial class AdminPage : MaterialSkin.Controls.MaterialForm
    {
        //Estilo de los botones
        private Button btnSel;
        private Panel borde;

        public AdminPage()
        {
            InitializeComponent();
            borde = new Panel();
            borde.Size = new Size(100, 2);
            panelMenu.Controls.Add(borde);
            ActivarBtns(btnDirectivos);
            FiltroDirectivos fd = new FiltroDirectivos();
            Filtros(fd);
        }

        //Propiedades para el menú
        private void ActivarBtns(object boton)
        {
            DesacBtns();
            if(boton != null)
            {
                btnSel = (Button)boton;
                btnSel.ForeColor = Color.Gold;

                borde.BackColor = Color.Gold;
                borde.Location = new Point(btnSel.Location.X, 34);
                borde.Visible = true;
                borde.BringToFront();
                          
            }
        }

        private void DesacBtns()
        {
            if(btnSel != null)
            {
                btnSel.ForeColor = Color.Black;
            }
        }

        private void Filtros(UserControl filtro) {

            filtro.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(filtro);
            filtro.BringToFront();

        
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void btnDirectivos_Click(object sender, EventArgs e)
        {
            ActivarBtns(sender);
            FiltroDirectivos fd = new FiltroDirectivos();
            Filtros(fd);
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            ActivarBtns(sender);
            FiltroProfes fp = new FiltroProfes();
            Filtros(fp);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            ActivarBtns(sender);
            FiltroEstudiantes fe = new FiltroEstudiantes();
            Filtros(fe);
        }

        //No sé si algo va aquí xd




    }

}

