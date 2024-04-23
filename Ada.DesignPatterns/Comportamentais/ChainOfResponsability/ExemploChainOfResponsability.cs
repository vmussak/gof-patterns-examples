using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Comportamentais.ChainOfResponsability
{
    public interface IAprovador
    {
        IAprovador ProximoAprovador { get; set; }
        void ProcessarPedido(Compra compra);
    }

    public class Compra
    {
        public int NumeroCompra { get; set; }
        public double Valor { get; set; }
        public string Finalidade { get; set; }

        public Compra(int numero, double valor, string finalidade)
        {
            NumeroCompra = numero;
            Valor = valor;
            Finalidade = finalidade;
        }
    }

    public class Gerente : IAprovador
    {
        private double _limiteAprovacao;
        public IAprovador ProximoAprovador { get; set; }
        public string Nome { get; set; }

        public Gerente(string nome, double limiteAprovacao)
        {
            this.Nome = nome;
            _limiteAprovacao = limiteAprovacao;
        }

        public void ProcessarPedido(Compra compra)
        {
            if (compra.Valor < _limiteAprovacao)
            {
                Console.WriteLine($"{this.Nome} aprovou o pedido nº {compra.NumeroCompra} no valor de {compra.Valor:C}");
            }
            else if (ProximoAprovador != null)
            {
                ProximoAprovador.ProcessarPedido(compra);
            }
            else
            {
                Console.WriteLine($"O pedido nº {compra.NumeroCompra} no valor de {compra.Valor:C} requer uma reunião executiva!");
            }
        }
    }
}
