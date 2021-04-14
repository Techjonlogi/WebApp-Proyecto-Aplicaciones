using System;
using System.Collections.Generic;

#nullable disable

namespace SpotyWeb.ModelosBD
{
    public partial class Cancion
    {
        public Cancion()
        {
            AlbumCancions = new HashSet<AlbumCancion>();
            PlayLists = new HashSet<PlayList>();
            UsuarioCancions = new HashSet<UsuarioCancion>();
        }

        public string IdCancion { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Duracion { get; set; }
        public string Album { get; set; }
        public int? Artista { get; set; }
        public string RutaRecurso { get; set; }

        public virtual Artistum ArtistaNavigation { get; set; }
        public virtual ICollection<AlbumCancion> AlbumCancions { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
        public virtual ICollection<UsuarioCancion> UsuarioCancions { get; set; }
    }
}
