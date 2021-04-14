using System;
using System.Collections.Generic;

#nullable disable

namespace SpotyWeb.ModelosBD
{
    public partial class Usuario
    {
        public Usuario()
        {
            PlayListUsuarios = new HashSet<PlayListUsuario>();
        }

        public string NickName { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Follows { get; set; }
        public string KeySesion { get; set; }

        public virtual UsuarioCancion UsuarioCancion { get; set; }
        public virtual ICollection<PlayListUsuario> PlayListUsuarios { get; set; }
    }
}
