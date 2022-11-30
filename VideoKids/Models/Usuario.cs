using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaVideos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public string Login { get; set; }
        public int Estatus { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword_aux { get; set; }
    }

    public class UserLogin
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}