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
            StreamWriter db = new StreamWriter("C:\\Users\\AMD\\source\\repos\\GestorEscolar\\GestorEscolar\\Txt\\usuarios.txt");
            foreach(Usuarios x in _Usuarios)
            {
                db.WriteLine($"{x.name};{x.id};{x.pass};{x.role}");

            }
            db.Close();
        }
        
       private void Leer()
        {
            StreamReader sr = new StreamReader("C:\\Users\\AMD\\source\\repos\\GestorEscolar\\GestorEscolar\\Txt\\usuarios.txt");
            string line = null;
            line = sr.ReadLine();

            while(line != null)
            {
                string[] vec = line.Split(';');
                _Usuarios.Add(new Usuarios(vec[0], vec[1], vec[2], vec[3]));
                line = sr.ReadLine();
                foreach(Usuarios v in _Usuarios)
                {

                    if (txtDoc.Text == v.id && txtPass.Text == v.pass && v.role=="admin")
                    {
                        MessageBox.Show("Bienvenido " + v.name);
                        AdminPage admin = new AdminPage();
                        
                        admin.Show();
                        this.Hide();

                    }
                    else { MessageBox.Show("Usuario no encontrado."); }
                  
                }
                sr.Close();
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Leer();
        }

       /* private void btnRegistar_Click(object sender, EventArgs e)
        {
            string nom = "Alejo";
            string id = "1000897372";
            string pass = "654321";
            string role = "admin";
            _Usuarios.Add(new Usuarios(nom, id, pass, role));
            Db();


        }*/

        private void txtDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
