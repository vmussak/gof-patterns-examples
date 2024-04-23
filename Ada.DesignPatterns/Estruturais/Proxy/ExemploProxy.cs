using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Estruturais.Proxy
{
    public interface IDocumento
    {
        void MostrarDocumento(string nomeUsuario);
    }

    // Documento Real
    public class DocumentoReal : IDocumento
    {
        private string conteudo;

        public DocumentoReal(string conteudo)
        {
            // Simula a carga de um documento com dados sensíveis
            this.conteudo = conteudo;
            CarregarDocumento();
        }

        private void CarregarDocumento()
        {
            Console.WriteLine("Carregando documento...");
        }

        public void MostrarDocumento(string nomeUsuario)
        {
            Console.WriteLine($"Documento para {nomeUsuario}: {conteudo}");
        }
    }

    // Proxy
    public class ProxyDocumento : IDocumento
    {
        private DocumentoReal documentoReal;
        private string conteudo;
        private PermissaoUsuario permissoes;

        public ProxyDocumento(string conteudo, PermissaoUsuario permissoes)
        {
            this.conteudo = conteudo;
            this.permissoes = permissoes;
        }

        public void MostrarDocumento(string nomeUsuario)
        {
            if (permissoes.TemPermissao(nomeUsuario))
            {
                if (documentoReal == null)
                {
                    documentoReal = new DocumentoReal(conteudo);
                }
                documentoReal.MostrarDocumento(nomeUsuario);
            }
            else
            {
                Console.WriteLine($"Acesso negado para o usuário {nomeUsuario}.");
            }
        }
    }

    // Controle de Permissões
    public class PermissaoUsuario
    {
        public bool TemPermissao(string nomeUsuario)
        {
            // Simulação simples de permissão
            return nomeUsuario == "admin";
        }
    }
}
