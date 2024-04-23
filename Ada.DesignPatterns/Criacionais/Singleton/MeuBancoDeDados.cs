using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Criacionais.Singleton
{
    public class MeuBancoDeDados
    {
        private static MeuBancoDeDados _instancia;
        public static MeuBancoDeDados ObterInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new MeuBancoDeDados();
            }

            return _instancia;
        }
    }
}
