using System;
using System.Collections.Generic;

#nullable disable

namespace SpotyWeb.ModelosBD
{
    public partial class AlbumCancion
    {
        public string Album { get; set; }
        public string Cancion { get; set; }

        public virtual Album AlbumNavigation { get; set; }
        public virtual Cancion CancionNavigation { get; set; }
    }
}
