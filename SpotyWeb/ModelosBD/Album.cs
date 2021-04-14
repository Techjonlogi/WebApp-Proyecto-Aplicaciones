using System;
using System.Collections.Generic;

#nullable disable

namespace SpotyWeb.ModelosBD
{
    public partial class Album
    {
        public string IdAlbum { get; set; }
        public string Nombre { get; set; }
        public string Año { get; set; }
        public string Artista { get; set; }
        public string Canciones { get; set; }

        public virtual AlbumCancion AlbumCancion { get; set; }
    }
}
