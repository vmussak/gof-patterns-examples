using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Comportamentais.Command
{
    public interface ICommand
    {
        void Execute();
    }

    // Receiver class
    public class Pedido
    {
        public List<string> Itens { get; private set; } = new List<string>();

        public void AdicionarItem(string item)
        {
            Itens.Add(item);
            Console.WriteLine($"Item adicionado: {item}");
        }

        public void FinalizarPedido()
        {
            Console.WriteLine("Pedido finalizado com os seguintes itens:");
            foreach (var item in Itens)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }

    // Concrete Command classes
    public class AdicionarItemCommand : ICommand
    {
        private Pedido _pedido;
        private string _item;

        public AdicionarItemCommand(Pedido pedido, string item)
        {
            _pedido = pedido;
            _item = item;
        }

        public void Execute()
        {
            _pedido.AdicionarItem(_item);
        }
    }

    public class FinalizarPedidoCommand : ICommand
    {
        private Pedido _pedido;

        public FinalizarPedidoCommand(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Execute()
        {
            _pedido.FinalizarPedido();
        }
    }

    // Invoker class
    public class Garcom
    {
        private ICommand _comando;

        public void SetCommand(ICommand comando)
        {
            _comando = comando;
        }

        public void Submit()
        {
            if (_comando != null)
            {
                _comando.Execute();
            }
        }
    }
}
