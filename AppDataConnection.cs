using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;

namespace NivelamentoTranscolar
{
    public class AppDataConnection: DataConnection
    {
        public AppDataConnection(LinqToDbConnectionOptions<AppDataConnection> options)
            :base(options)
        {
         
        }
        public ITable<DadosMapa> DadosMapa => GetTable<DadosMapa>();
    }
}
