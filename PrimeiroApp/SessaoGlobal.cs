using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeiroApp;

namespace Sessao
{
    internal class SessaoGlobal
    {

        public static class SessaoUsuario
        {


            public static string NomeUsuario { get; set; }
            public static string IdUsuario { get; set; }  


            
            
            public static void LimparSessao()
            {
                NomeUsuario = null;
                IdUsuario = null;
            }
        }

    }
}
