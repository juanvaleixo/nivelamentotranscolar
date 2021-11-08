using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace NivelamentoTranscolar
{
    public class DadosMapa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int latitude { get; set; }
        public int longitude { get; set; }
    }
}
