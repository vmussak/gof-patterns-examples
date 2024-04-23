using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Estruturais.Decorator
{
    public abstract class Bebida
    {
        public virtual string Descricao { get; protected set; } = "Bebida Desconhecida";

        public abstract double Custo();
    }

    // Componente Concreto
    public class Cafe : Bebida
    {
        public Cafe()
        {
            Descricao = "Café";
        }

        public override double Custo()
        {
            return 1.99;
        }
    }

    // Decorador
    public abstract class DecoradorDeCondimento : Bebida
    {
        public abstract override string Descricao { get; }
    }

    // Decorador Concreto
    public class Leite : DecoradorDeCondimento
    {
        private Bebida bebida;

        public Leite(Bebida bebida)
        {
            this.bebida = bebida;
        }

        public override string Descricao => bebida.Descricao + ", Leite";

        public override double Custo()
        {
            return bebida.Custo() + 0.50;
        }
    }

    // Outro Decorador Concreto
    public class Chantilly : DecoradorDeCondimento
    {
        private Bebida bebida;

        public Chantilly(Bebida bebida)
        {
            this.bebida = bebida;
        }

        public override string Descricao => bebida.Descricao + ", Chantilly";

        public override double Custo()
        {
            return bebida.Custo() + 0.70;
        }
    }
}
