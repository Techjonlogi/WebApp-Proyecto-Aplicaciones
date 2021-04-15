using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpotyWeb.ModelosBD;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpotyWeb.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            
               /* using (SpotyWebBDContext db = new SpotyWebBDContext())
                {
                    var usu = db.Usuario.Where((x) => x.Nickname == usuario.Nickname).FirstOrDefault();
                    if (usu != null)
                    {
                        if (usu.Password.Equals(usuario.Password))
                        {

                            Callback.GetLoginResult(LoginResults.UsuarioEncontrado);
                        }
                        else
                        {
                            Callback.GetLoginResult(LoginResults.ContraseñaIncorrecta);
                        }
                    }
                    else
                    {
                        Callback.GetLoginResult(LoginResults.NoExisteUrsuario);
                    }
                }

            */
        }
    }
}
