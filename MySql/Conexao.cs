using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    static class Conexao
    {
        private const string servidor = "localhost";
        private const string bancoDados = "dbForm";
        private const string usuario = "root";
        private const string senha = "kiraFE22022006";

        static public string conexao = $"server={servidor}; user id={usuario};database={bancoDados};password={senha}";
    }
}
