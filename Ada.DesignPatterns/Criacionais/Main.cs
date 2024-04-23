using Ada.DesignPatterns.Criacionais.AbstractFactory;
using Ada.DesignPatterns.Criacionais.Builder;
using Ada.DesignPatterns.Criacionais.Factory;
using Ada.DesignPatterns.Criacionais.Protptype;
using Ada.DesignPatterns.Criacionais.Singleton;

namespace Ada.DesignPatterns.Criacionais
{
    static class Main
    {
        //Singleton
        //MeuBancoDeDados banco1 = MeuBancoDeDados.ObterInstancia();

        //MeuBancoDeDados banco2 = MeuBancoDeDados.ObterInstancia();

        //if(banco1 == banco2)
        //{
        //    Console.WriteLine("Os dois bancos são a mesma instância.");
        //}
        //else
        //{
        //    Console.WriteLine("Os dois bancos são instâncias diferentes.");
        //}

        // service.AddSingleton<MeuBancoDeDados>();

        //Console.ReadKey();


        //Factory
        //CriadorDeLog logCreator;
        //Console.WriteLine("Digite 'simples' para log simples ou qualquer outra coisa para log detalhado:");
        //string input = Console.ReadLine();

        //if (input.ToLower() == "simples")
        //{
        //    logCreator = new CriadorLogSimples();
        //}
        //else
        //{
        //    logCreator = new CriadorLogDetalhado();
        //}

        //logCreator.LogMessage("Este é um teste de log!");



        //Console.ReadKey();



        ////Abstract Factory
        //IFabricaInterfaceGrafica fabrica;
        //Aplicacao aplicacao;

        //Console.WriteLine("Digite 'claro' para o tema Claro ou 'escuro' para o tema Escuro:");
        //string tema = Console.ReadLine().ToLower();

        //if (tema == "claro")
        //{
        //    fabrica = new FabricaTemaClaro();
        //}
        //else
        //{
        //    fabrica = new FabricaTemaEscuro();
        //}

        //aplicacao = new Aplicacao(fabrica);
        //aplicacao.Desenhar();

        //Console.ReadKey();


        //Builder
        //DiretorInterface diretor = new DiretorInterface();
        //InterfaceBuilder builder;

        //Console.WriteLine("Digite o tipo de cliente ('padrao', 'vip', 'consultor'):");
        //string tipoCliente = Console.ReadLine().ToLower();

        //switch (tipoCliente)
        //{
        //    case "vip":
        //        builder = new ClienteVIPBuilder();
        //        break;
        //    case "consultor":
        //        builder = new ClienteConsultorBuilder();
        //        break;
        //    default:
        //        builder = new ClientePadraoBuilder();
        //        break;
        //}

        //var interfaceUsuario = diretor.MontarInterface(builder);
        //interfaceUsuario.MostrarInterface();
        //Console.ReadKey();



        //Prototype
        //Documento docOriginal = new Documento("Documento Original", "Este é o conteúdo original.");

        //// Clonando o documento original para criar uma cópia
        //Documento docCopia = docOriginal.Clone() as Documento;

        //// Modificando o conteúdo da cópia
        //docCopia.Conteudo = "Este conteúdo foi modificado na cópia.";

        //// Imprimindo ambos os documentos para verificar o resultado da clonagem
        //Console.WriteLine("Documento Original:");
        //docOriginal.Print();
        //Console.WriteLine("\nDocumento Cópia:");
        //docCopia.Print();
        //Console.ReadKey();
    }
}
