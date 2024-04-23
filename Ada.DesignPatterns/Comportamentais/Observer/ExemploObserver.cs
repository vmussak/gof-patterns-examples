using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Comportamentais.Observer
{
    public interface IObserver
    {
        void Atualizar(Pedido pedido);
    }

    // Concrete Observers
    public class GeradorNF : IObserver
    {
        public void Atualizar(Pedido pedido)
        {
            Console.WriteLine($"Gerando Nota Fiscal para o pedido #{pedido.NumeroPedido}");
        }
    }

    public class SeparadorEstoque : IObserver
    {
        public void Atualizar(Pedido pedido)
        {
            Console.WriteLine($"Separando estoque para o pedido #{pedido.NumeroPedido}");
        }
    }

    public class EnviadorBrindes : IObserver
    {
        public void Atualizar(Pedido pedido)
        {
            Console.WriteLine($"Enviando brindes para o pedido #{pedido.NumeroPedido}");
        }
    }

    // Subject
    public class Pedido
    {
        public Pedido(int numeroPedido)
        {
            NumeroPedido = numeroPedido;
        }
        public int NumeroPedido { get; set; }
    }

    public class PedidoService
    {
        public Pedido _pedido { get; private set; }
        private List<IObserver> _observers = new List<IObserver>();

        public void AdicionarObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoverObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void RealizarPedido(Pedido pedido)
        {
            _pedido = pedido;
            Console.WriteLine($"Pedido #{pedido.NumeroPedido} realizado com sucesso!");
            NotificarObservers();
        }

        private void NotificarObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Atualizar(_pedido);
            }
        }
    }
}
