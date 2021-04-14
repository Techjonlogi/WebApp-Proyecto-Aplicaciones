using System;
using System.Collections.Generic;

#nullable disable

namespace SpotyWeb.ModelosBD
{
    public partial class UsuarioCancion
    {
        public string Usuario { get; set; }
        public string Cancion { get; set; }

        public virtual Cancion CancionNavigation { get; set; }
        public virtual Usuario UsuarioNavigation { get; set; }
    }
}
