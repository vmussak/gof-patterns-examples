using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Criacionais.Builder
{
    public class InterfaceUsuario
    {
        public List<string> Telas { get; private set; }

        public InterfaceUsuario()
        {
            Telas = new List<string>();
        }

        public void AdicionarTela(string tela)
        {
            Telas.Add(tela);
        }

        public void MostrarInterface()
        {
            Console.WriteLine("Telas disponíveis:");
            foreach (var tela in Telas)
            {
                Console.WriteLine(tela);
            }
        }
    }

    // Builder Abstrato
    public abstract class InterfaceBuilder
    {
        protected InterfaceUsuario interfaceUsuario;

        public void CriarNovaInterface()
        {
            interfaceUsuario = new InterfaceUsuario();
        }

        public InterfaceUsuario PegarInterface()
        {
            return interfaceUsuario;
        }

        public abstract void ConstruirTelasIniciais();
        public abstract void ConstruirTelasEspeciais();
    }

    // Builder Concreto para Cliente Padrão
    public class ClientePadraoBuilder : InterfaceBuilder
    {
        public override void ConstruirTelasIniciais()
        {
            interfaceUsuario.AdicionarTela("Inicial");
        }

        public override void ConstruirTelasEspeciais()
        {
            // Não adiciona telas especiais para clientes padrão
        }
    }

    // Builder Concreto para Cliente VIP
    public class ClienteVIPBuilder : InterfaceBuilder
    {
        public override void ConstruirTelasIniciais()
        {
            interfaceUsuario.AdicionarTela("Inicial");
        }

        public override void ConstruirTelasEspeciais()
        {
            interfaceUsuario.AdicionarTela("Benefícios");
        }
    }

    // Builder Concreto para Cliente Consultor
    public class ClienteConsultorBuilder : InterfaceBuilder
    {
        public override void ConstruirTelasIniciais()
        {
            interfaceUsuario.AdicionarTela("Inicial");
        }

        public override void ConstruirTelasEspeciais()
        {
            interfaceUsuario.AdicionarTela("Benefícios");
            interfaceUsuario.AdicionarTela("Parceiros");
        }
    }

    // Diretor
    public class DiretorInterface
    {
        public InterfaceUsuario MontarInterface(InterfaceBuilder builder)
        {
            builder.CriarNovaInterface();
            builder.ConstruirTelasIniciais();
            builder.ConstruirTelasEspeciais();
            return builder.PegarInterface();
        }
    }
}
