using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Criacionais.Factory
{
    public interface ILog
    {
        void EscreverLog(string mensagem);
    }

    // ConcreteProduct1
    class SimpleLog : ILog
    {
        public void EscreverLog(string message)
        {
            Console.WriteLine($"SimpleLog: {message}");
        }
    }

    // ConcreteProduct2
    class DetailedLog : ILog
    {
        public void EscreverLog(string message)
        {
            Console.WriteLine($"DetailedLog [{DateTime.Now}]: {message}");
        }
    }

    abstract class CriadorDeLog
    {
        public abstract ILog CriarLog();

        public void LogMessage(string mensagem)
        {
            var log = CriarLog();
            log.EscreverLog(mensagem);
        }
    }

    class CriadorLogSimples : CriadorDeLog
    {
        public override ILog CriarLog()
        {
            return new SimpleLog();
        }
    }

    class CriadorLogDetalhado : CriadorDeLog
    {
        public override ILog CriarLog()
        {
            return new DetailedLog();
        }
    }
}
