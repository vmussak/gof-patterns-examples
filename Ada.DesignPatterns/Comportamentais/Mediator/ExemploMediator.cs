using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Comportamentais.Mediator
{
    public interface ITorreDeControle
    {
        void RegistrarAviao(Aviao aviao);
        void EnviarMensagem(string mensagem, Aviao aviao);
    }

    // Concrete Mediator
    public class TorreDeControleConcreta : ITorreDeControle
    {
        private List<Aviao> _avioes = new List<Aviao>();

        public void RegistrarAviao(Aviao aviao)
        {
            _avioes.Add(aviao);
        }

        public void EnviarMensagem(string mensagem, Aviao aviaoOrigem)
        {
            foreach (var aviao in _avioes)
            {
                // Não enviar a mensagem para o próprio avião que a enviou
                if (aviao != aviaoOrigem)
                {
                    aviao.ReceberMensagem(mensagem);
                }
            }
        }
    }

    // Colleague class
    public class Aviao
    {
        public string Identificacao { get; private set; }
        private ITorreDeControle _torreDeControle;

        public Aviao(string id, ITorreDeControle torreDeControle)
        {
            Identificacao = id;
            _torreDeControle = torreDeControle;
            _torreDeControle.RegistrarAviao(this);
        }

        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"{Identificacao} enviando mensagem: {mensagem}");
            _torreDeControle.EnviarMensagem(mensagem, this);
        }

        public void ReceberMensagem(string mensagem)
        {
            Console.WriteLine($"{Identificacao} recebeu mensagem: {mensagem}");
        }
    }
}
