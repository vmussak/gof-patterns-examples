using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Comportamentais.TemplateMethod
{
    public abstract class ProcessadorDeDocumento
    {
        // The template method defines the skeleton of an algorithm.
        public void ProcessarDocumento()
        {
            AbrirDocumento();
            LerDados();
            ProcessarDados();
            SalvarDocumento();
        }

        // These operations already have implementations.
        private void AbrirDocumento()
        {
            Console.WriteLine("Documento aberto.");
        }

        // These operations must be implemented in subclasses.
        protected abstract void LerDados();
        protected abstract void ProcessarDados();

        private void SalvarDocumento()
        {
            Console.WriteLine("Documento salvo.");
        }
    }

    // Concrete class
    public class ProcessadorPDF : ProcessadorDeDocumento
    {
        protected override void LerDados()
        {
            Console.WriteLine("Lendo dados do PDF.");
        }

        protected override void ProcessarDados()
        {
            Console.WriteLine("Processando dados do PDF.");
        }
    }

    // Concrete class
    public class ProcessadorWord : ProcessadorDeDocumento
    {
        protected override void LerDados()
        {
            Console.WriteLine("Lendo dados do Word.");
        }

        protected override void ProcessarDados()
        {
            Console.WriteLine("Processando dados do Word.");
        }
    }
}
