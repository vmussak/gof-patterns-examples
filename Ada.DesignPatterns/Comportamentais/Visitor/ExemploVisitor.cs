using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Comportamentais.Visitor
{
    // Visitor interface
    public interface IVisitor
    {
        void Visit(Engenheiro engenheiro);
        void Visit(Gerente gerente);
    }

    // Concrete Visitors
    public class AumentoSalario : IVisitor
    {
        public void Visit(Engenheiro engenheiro)
        {
            engenheiro.Salario *= 1.10; // 10% raise
            Console.WriteLine($"Novo salário do engenheiro {engenheiro.Nome}: {engenheiro.Salario:C}");
        }

        public void Visit(Gerente gerente)
        {
            gerente.Salario *= 1.20; // 20% raise
            Console.WriteLine($"Novo salário do gerente {gerente.Nome}: {gerente.Salario:C}");
        }
    }

    // Element interface
    public interface IEmpregado
    {
        void Accept(IVisitor visitor);
    }

    // Concrete Elements
    public class Engenheiro : IEmpregado
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Engenheiro(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Gerente : IEmpregado
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Gerente(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
