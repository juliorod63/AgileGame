using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AgileGame.Pages
{
    public class KanbanModel: PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public BoardList Tableros {get; set;}

        public KanbanModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            Tableros = new BoardList();

            var tablero = new BoardList.Board();
            tablero.Title = "CTE";
            tablero.Id = 1;
            Tableros.Boards.Add(tablero);

            var tablero2= new BoardList.Board();
            tablero2.Title = "DES";
            tablero2.Id = 2;
            Tableros.Boards.Add(tablero2);

        }

    }
}
