using Ada.DesignPatterns.Estruturais.Adapter;
using Ada.DesignPatterns.Estruturais.Bridge;
using Ada.DesignPatterns.Estruturais.Composite;
using Ada.DesignPatterns.Estruturais.Decorator;
using Ada.DesignPatterns.Estruturais.Facade;
using Ada.DesignPatterns.Estruturais.Flyweight;
using Ada.DesignPatterns.Estruturais.Proxy;


namespace Ada.DesignPatterns.Estruturais
{
    public class Main
    {


        // Adapter

        //var clienteApiExterna = new ClienteApiExterna
        //{
        //    Nome = "Ada",
        //    Sobrenome = "Lovelace",
        //    DataNascimento = new DateTime(1815, 12, 10),
        //    Cpf = "000.000.000-00"
        //};

        //var bancoDeDados = new BancoDeDados();

        //var cliente = clienteApiExterna.ConverterParaCliente();

        //bancoDeDados.SalvarCliente(cliente);

        //Console.ReadKey();















        ////Bridge
        //IMessageSender emailSender = new EmailSender();
        //IMessageSender smsSender = new SmsSender();

        //Message userMessage = new UserMessage(emailSender);
        //userMessage.Send("Bem-vindo", "Obrigado por se registrar!");

        //Message adminMessage = new AdminMessage(smsSender);
        //adminMessage.Send("Alerta", "Ação necessária!");

        //Console.ReadKey();

















        //Composite
        //var devTeam = new Department("Development Team");
        //devTeam.Add(new Employee("Alice", 80000));
        //devTeam.Add(new Employee("Bob", 90000));

        //var qaTeam = new Department("QA Team");
        //qaTeam.Add(new Employee("Charlie", 70000));

        //var techDepartment = new Department("Tech Department");
        //techDepartment.Add(devTeam);
        //techDepartment.Add(qaTeam);
        //techDepartment.Add(new Employee("Dave", 120000)); 

        //Console.WriteLine($"Total salary for {techDepartment.GetName()}: ${techDepartment.CalculateTotalSalary()}");

        //Console.ReadKey();












        // Decorator

        //Bebida bebida = new Cafe();
        //Console.WriteLine($"{bebida.Descricao}: ${bebida.Custo()}");

        //// Adiciona Leite
        //bebida = new Leite(bebida);
        //Console.WriteLine($"{bebida.Descricao}: ${bebida.Custo()}");

        //// Adiciona Chantilly
        //bebida = new Chantilly(bebida);
        //Console.WriteLine($"{bebida.Descricao}: ${bebida.Custo()}");

        //Console.ReadKey();















        //Facade

        //BibliotecaFacade biblioteca = new BibliotecaFacade();
        //biblioteca.EmprestarLivro("João", "1984");

        //Console.ReadKey();




















        //Flyweight


        //Documento doc = new Documento();
        //// Adicionando alguns caracteres ao documento
        //doc.AdicionarCaractere('A', "Arial", 12, ConsoleColor.Red, 1);
        //doc.AdicionarCaractere('B', "Arial", 12, ConsoleColor.Red, 2);
        //doc.AdicionarCaractere('A', "Arial", 12, ConsoleColor.Red, 3);  // Reutilizando o objeto Flyweight
        //Console.ReadKey();

















        ////Proxy
        //ProxyDocumento proxy = new ProxyDocumento("Conteúdo Sensível", new PermissaoUsuario());
        //proxy.MostrarDocumento("admin");
        //proxy.MostrarDocumento("guest");
        //Console.ReadKey();
    }
}
