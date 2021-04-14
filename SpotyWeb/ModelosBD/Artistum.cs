using System;
using System.Collections.Generic;

#nullable disable

namespace SpotyWeb.ModelosBD
{
    public partial class Artistum
    {
        public Artistum()
        {
            Cancions = new HashSet<Cancion>();
        }

        public int IdArtista { get; set; }
        public string NombreArtista { get; set; }
        public string NumeroAlbumes { get; set; }
        public string Seguidores { get; set; }
        public string AñoInicio { get; set; }

        public virtual ICollection<Cancion> Cancions { get; set; }
    }
}
