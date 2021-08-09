using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using AgileGame.Models;
using AgileGame.Data;

namespace AgileGame.Pages
{
    public class InstruccionesModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public InstruccionesModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //no accion
        }
    }
}
