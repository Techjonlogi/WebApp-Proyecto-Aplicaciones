using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotyWeb.ResultadosOperaciones
{
    public class ResultadosDeRegistro
    {
        public enum ResultadosRegistro
        {

            YaExisteUnRegistro,
            ErrorDeBD,
            ErrorDesconocido,
            RegistradoConExito

        }
    }
}
