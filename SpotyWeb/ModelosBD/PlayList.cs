using System;
using System.Collections.Generic;

#nullable disable

namespace SpotyWeb.ModelosBD
{
    public partial class PlayList
    {
        public string IdPlaylist { get; set; }
        public string Nombre { get; set; }
        public string Cancion { get; set; }
        public string Usuario { get; set; }

        public virtual Cancion CancionNavigation { get; set; }
        public virtual PlayListUsuario PlayListUsuario { get; set; }
    }
}
