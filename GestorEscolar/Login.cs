using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;

namespace GestorEscolar
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public static List<Usuarios> _Usuarios = new List<Usuarios>();



        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //SkinManager.ColorScheme= new ColorScheme(Primary)

        }


        static void Db()
        {
            StreamWriter db = new StreamWriter(".\\Admin.txt");
            foreach (Usuarios x in _Usuarios)
            {
                db.WriteLine($"{x.name};{x.id};{x.pass};{x.role}; {x.contact}");

            }
            db.Close();
        }

        private void Leer(List<Usuarios> _Usuarios)
        {
            int cont = 0, op = 1;
            //admins
            StreamReader sr = new StreamReader(".\\Admin.txt");
            string line = null;
            line = sr.ReadLine();
            //directivos
            StreamReader sr2 = new StreamReader(".\\directivos.txt");
            string line2 = null;
            line2 = sr2.ReadLine();


            do
            {
                switch (op)
                {
                    case 1:

                        while (line != null)
                        {
                            //admins
                            string[] vec = line.Split(';');
                            _Usuarios.Add(new Usuarios(vec[0], vec[1], vec[2], vec[3], vec[4]));
                            line = sr.ReadLine();


                            foreach (Usuarios v in _Usuarios)
                            {

                                if (txtDoc.Text == v.id && txtPass.Text == v.pass && v.role == "admin")
                                {
                                    MessageBox.Show("Bienvenido " + v.name);
                                    AdminPage admin = new AdminPage();

                                    admin.Show();
                                    this.Hide();
                                    cont = 3;

                                }
                                

                                else
                                {
                                    op = 2;
                                }

                            }
                        }

                        break;

                    case 2:

                        while (line2 != null)
                        {
                            //directivos
                            string[] vec2 = line2.Split(';');
                            _Usuarios.Add(new Usuarios(vec2[0], vec2[1], vec2[2], vec2[3], vec2[4]));
                            line2 = sr2.ReadLine();


                            foreach (Usuarios v2 in _Usuarios)
                            {

                                if (txtDoc.Text == v2.id && txtPass.Text == v2.pass && v2.role == "directivo")
                                {
                                    MessageBox.Show("Bienvenido " + v2.name);
                                    DirectivoPage directivo = new DirectivoPage();

                                    directivo.Show();
                                    this.Hide();
                                    cont = 3;

                                }
                               

                                else
                                {
                                    op = 2;
                                }

                            }
                        }

                        break;

                }


                if (cont > 3) { MessageBox.Show("Usuario no encontrado"); }
                sr.Close();

            } while (cont != 3);



        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Leer(_Usuarios);
        }

        /* private void btnRegistar_Click(object sender, EventArgs e)
         {
             string nom = "Alejo";
             string id = "1000897372";
             string pass = "654321";
             string role = "admin";
             string contact = "555555"
             _Usuarios.Add(new Usuarios(nom, id, pass, role));
             Db();


         }*/

        private void txtDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
