using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Estruturais.Adapter
{
    public class ClienteApiExterna
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
    }

    public class Cliente
    {
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public long Cpf { get; set; }
    }

    public static class ClienteAdapter
    {
        public static Cliente ConverterParaCliente(this ClienteApiExterna cliente)
        {
            return new Cliente
            {
                NomeCompleto = $"{cliente.Nome} {cliente.Sobrenome}",
                DataNascimento = cliente.DataNascimento,
                Cpf = long.Parse(cliente.Cpf.Replace(".", string.Empty).Replace("-", string.Empty))
            };
        }
    }

    public class BancoDeDados
    {
        public void SalvarCliente(Cliente cliente)
        {
            Console.WriteLine($"Cliente {cliente.NomeCompleto} salvo com sucesso!");
        }
    }
}
