using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Estruturais.Facade
{
    public class SistemaDeInventario
    {
        private Dictionary<string, int> inventario = new Dictionary<string, int>
    {
        { "1984", 4 },
        { "O Senhor dos Anéis", 2 }
    };

        public bool VerificarDisponibilidade(string livro)
        {
            if (inventario.ContainsKey(livro) && inventario[livro] > 0)
            {
                Console.WriteLine($"O livro '{livro}' está disponível.");
                return true;
            }
            else
            {
                Console.WriteLine($"O livro '{livro}' não está disponível.");
                return false;
            }
        }

        public void AtualizarInventario(string livro)
        {
            if (inventario.ContainsKey(livro) && inventario[livro] > 0)
            {
                inventario[livro]--;
            }
        }
    }

    public class SistemaDeUsuarios
    {
        public bool VerificarStatusUsuario(string usuario)
        {
            // Simulação simples de verificação
            Console.WriteLine($"Status do usuário '{usuario}' verificado.");
            return true;
        }
    }

    public class SistemaDeEmprestimos
    {
        public void RegistrarEmprestimo(string usuario, string livro)
        {
            Console.WriteLine($"Empréstimo do livro '{livro}' registrado para o usuário '{usuario}'.");
        }
    }

    // Facade
    public class BibliotecaFacade
    {
        private SistemaDeInventario inventario = new SistemaDeInventario();
        private SistemaDeUsuarios usuarios = new SistemaDeUsuarios();
        private SistemaDeEmprestimos emprestimos = new SistemaDeEmprestimos();

        public void EmprestarLivro(string usuario, string livro)
        {
            Console.WriteLine("Processando o empréstimo...");
            if (usuarios.VerificarStatusUsuario(usuario) && inventario.VerificarDisponibilidade(livro))
            {
                emprestimos.RegistrarEmprestimo(usuario, livro);
                inventario.AtualizarInventario(livro);
            }
        }
    }
}
