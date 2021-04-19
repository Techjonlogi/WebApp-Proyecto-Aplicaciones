using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpotyWeb.ModelosBD;

namespace SpotyWeb.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }

        [BindProperty]
        public string Nickname { get; set; }

        [BindProperty]
        public string Correo { get; set; }



        [BindProperty]
        public string Contraseña { get; set; }




       

        public void OnPost()
        {
            Utilities.Utilities registro = new Utilities.Utilities();
            Usuario usu = new Usuario();
            usu.Nombre = Nombre;
            usu.NickName = Nickname;
            usu.Correo = Correo;
            usu.Contraseña = Contraseña;
            registro.HacerRegistroUsuario(usu);
        }
    }
}
