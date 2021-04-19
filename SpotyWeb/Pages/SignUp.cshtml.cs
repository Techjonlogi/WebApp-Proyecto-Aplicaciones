using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            Utilities.Utilities login = new Utilities.Utilities();
        }
    }
}
