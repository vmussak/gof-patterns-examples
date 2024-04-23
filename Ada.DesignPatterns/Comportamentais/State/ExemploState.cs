using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Comportamentais.State
{
    public interface IEstadoSemaforo
    {
        void ProximoEstado(Semaforo semaforo);
    }

    // Concrete states
    public class EstadoVermelho : IEstadoSemaforo
    {
        public void ProximoEstado(Semaforo semaforo)
        {
            Console.WriteLine("Semaforo em Vermelho - Pare");
            Thread.Sleep(1000); // Representa o tempo que o semáforo fica no vermelho
            semaforo.EstadoAtual = new EstadoVerde();
        }
    }

    public class EstadoVerde : IEstadoSemaforo
    {
        public void ProximoEstado(Semaforo semaforo)
        {
            Console.WriteLine("Semaforo em Verde - Siga");
            Thread.Sleep(1000); // Representa o tempo que o semáforo fica no verde
            semaforo.EstadoAtual = new EstadoAmarelo();
        }
    }

    public class EstadoAmarelo : IEstadoSemaforo
    {
        public void ProximoEstado(Semaforo semaforo)
        {
            Console.WriteLine("Semaforo em Amarelo - Atenção");
            Thread.Sleep(1000); // Representa o tempo que o semáforo fica no amarelo
            semaforo.EstadoAtual = new EstadoVermelho();
        }
    }

    // Context
    public class Semaforo
    {
        public IEstadoSemaforo EstadoAtual { get; set; }

        public Semaforo(IEstadoSemaforo estadoInicial)
        {
            EstadoAtual = estadoInicial;
        }

        public void MudarEstado()
        {
            EstadoAtual.ProximoEstado(this);
        }
    }
}
