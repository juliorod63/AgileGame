using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AgileGame.Models;
using AgileGame.Data;

namespace AgileGame.Pages
{
    public class KanbanModel: PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public List<Tablero> Tableros {get; set;}

        private readonly AgileGameContext _db;

        public KanbanModel(ILogger<PrivacyModel> logger, AgileGameContext db)
        {
            _logger = logger;
            _db= db;
            Tableros= new List<Tablero>();
        }
        public void OnGet()
        {
            Tableros = _db.Tableros.ToList();

        }

    }
}
