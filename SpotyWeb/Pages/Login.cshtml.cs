using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpotyWeb.ModelosBD;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using static SpotyWeb.ResultadosOperaciones.ResultadosLogin;
using static SpotyWeb.Utilities.Utilities;

namespace SpotyWeb.Pages
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        public string nickname { get; set; }

        [BindProperty]
        public string Contraseña { get; set; }

        [BindProperty]
        public ResultadosDeLogin estatus { get; set; }



        public void OnPost()
        {
            Utilities.Utilities login = new Utilities.Utilities();
            estatus = login.doLogin(nickname, Contraseña);
            ViewData["Message"] = $"Hi {estatus} this is the contact page";


        }
    }
}
