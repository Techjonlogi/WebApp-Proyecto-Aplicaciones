using System;
using System.Collections.Generic;

#nullable disable

namespace SpotyWeb.ModelosBD
{
    public partial class PlayListUsuario
    {
        public string PlayList { get; set; }
        public string Usuario { get; set; }

        public virtual PlayList PlayListNavigation { get; set; }
        public virtual Usuario UsuarioNavigation { get; set; }
    }
}
