using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SpotyWeb.ResultadosOperaciones.ResultadosLogin;
using SpotyWeb.ModelosBD;

namespace SpotyWeb.Utilities
{
    public class Utilities
    {

        public ResultadosDeLogin doLogin(string nickname, string password) {

            using (SpotyWebBDContext db = new SpotyWebBDContext())
            {
                var usu = db.Usuarios.Where((x) => x.NickName == nickname).FirstOrDefault();
                if (usu != null)
                {
                    if (usu.Contraseña.Equals(password))
                    {

                        return ResultadosDeLogin.UsuarioEncontrado;
                    }
                    else
                    {
                        return ResultadosDeLogin.ContraseñaIncorrecta;
                    }
                }
                else
                {
                    return ResultadosDeLogin.NoExisteUrsuario;
                }
            }


        }

    }
}
