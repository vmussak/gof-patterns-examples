using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Estruturais.Flyweight
{
    public interface CaractereFlyweight
    {
        void Exibir(int ponto);
    }

    // Concrete Flyweight
    public class Caractere : CaractereFlyweight
    {
        private readonly char simbolo;
        private readonly string fonte;
        private readonly int tamanho;
        private readonly ConsoleColor cor;

        public Caractere(char simbolo, string fonte, int tamanho, ConsoleColor cor)
        {
            this.simbolo = simbolo;
            this.fonte = fonte;
            this.tamanho = tamanho;
            this.cor = cor;
        }

        public void Exibir(int ponto)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine($"Caractere: {simbolo} - Fonte: {fonte}, Tamanho: {tamanho}, Ponto: {ponto}, HashCode: {GetHashCode()}");
            Console.ResetColor();
        }
    }

    // Flyweight Factory
    public class CaractereFactory
    {
        private Dictionary<string, Caractere> caracteres = new Dictionary<string, Caractere>();

        public Caractere GetCaractere(char chave, string fonte, int tamanho, ConsoleColor cor)
        {
            string identidade = $"{chave}-{fonte}-{tamanho}-{cor}";
            if (!caracteres.ContainsKey(identidade))
            {
                caracteres[identidade] = new Caractere(chave, fonte, tamanho, cor);
            }
            return caracteres[identidade];
        }
    }

    // Cliente
    public class Documento
    {
        private List<CaractereFlyweight> conteudo = new List<CaractereFlyweight>();
        private CaractereFactory factory = new CaractereFactory();

        public void AdicionarCaractere(char simbolo, string fonte, int tamanho, ConsoleColor cor, int ponto)
        {
            CaractereFlyweight c = factory.GetCaractere(simbolo, fonte, tamanho, cor);
            conteudo.Add(c);
            c.Exibir(ponto);
        }
    }
}
