using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEscolar
{
    public class Usuarios
    {
        public string name { get; set; }
        public string id { get; set; }
        public string pass { get; set; }
        public string role { get; set; }

        public  Usuarios(string _name, string _id, string _pass, string _role) {
            name = _name;
            id = _id;
            pass = _pass;
            role = _role;


            
        }


    }
}
