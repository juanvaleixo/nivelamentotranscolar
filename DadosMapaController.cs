using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NivelamentoTranscolar
{
    public class DadosMapaController : Controller
    {
        private AppDataConnection _connection;

        public DadosMapaController(AppDataConnection connection)
        {
            _connection = connection;
        }

    }
}
