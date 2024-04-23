using Ada.DesignPatterns.Comportamentais.ChainOfResponsability;
using Ada.DesignPatterns.Comportamentais.Command;
using Ada.DesignPatterns.Comportamentais.Iterator;
using Ada.DesignPatterns.Comportamentais.Mediator;
using Ada.DesignPatterns.Comportamentais.Memento;
using Ada.DesignPatterns.Comportamentais.Observer;
using Ada.DesignPatterns.Comportamentais.State;
using Ada.DesignPatterns.Comportamentais.Strategy;
using Ada.DesignPatterns.Comportamentais.TemplateMethod;
using Ada.DesignPatterns.Comportamentais.Visitor;

//ChainOfResponsability

//Gerente gerente = new Gerente("Marcos", 10000);

//Gerente gerenteSenior = new Gerente("Mariana", 25000);
//Gerente diretor = new Gerente("Cecília", 100000);

//gerente.ProximoAprovador = gerenteSenior;
//gerenteSenior.ProximoAprovador = diretor;

//// Gerar e processar pedidos de compra
//Compra p1 = new Compra(1, 4500, "Materiais");
//Compra p2 = new Compra(2, 17500, "Projeto X");
//Compra p3 = new Compra(3, 75000, "Projeto Y");

//gerente.ProcessarPedido(p1);
//gerente.ProcessarPedido(p2);
//gerente.ProcessarPedido(p3);


//Console.ReadKey();

















// Command
//Pedido pedido = new Pedido();
//Garcom garcom = new Garcom();

//// Adicionando itens ao pedido
//garcom.SetCommand(new AdicionarItemCommand(pedido, "Hambúrguer"));
//garcom.Submit();
//garcom.SetCommand(new AdicionarItemCommand(pedido, "Batatas fritas"));
//garcom.Submit();

//// Finalizando o pedido
//garcom.SetCommand(new FinalizarPedidoCommand(pedido));
//garcom.Submit();

//Console.ReadKey();





















// Iterator

//Biblioteca biblioteca = new Biblioteca();
//biblioteca.Add(new Livro("1984", "George Orwell"));
//biblioteca.Add(new Livro("A Revolução dos Bichos", "George Orwell"));
//biblioteca.Add(new Livro("Cem Anos de Solidão", "Gabriel Garcia Marquez"));

//IIterator<Livro> iterator = biblioteca.CreateIterator();
//while (iterator.HasNext())
//{
//    Livro livro = iterator.Next();
//    Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}");
//}

//Console.ReadKey();







//Mediator

//ITorreDeControle torre = new TorreDeControleConcreta();

//Aviao aviao1 = new Aviao("Avião 1", torre);
//Aviao aviao2 = new Aviao("Avião 2", torre);
//Aviao aviao3 = new Aviao("Avião 3", torre);

//aviao1.EnviarMensagem("Solicito autorização para decolar.");
//aviao2.EnviarMensagem("Solicito autorização para pousar.");

//Console.ReadKey();











// Memento
//EditorTexto editor = new EditorTexto();
//Caretaker caretaker = new Caretaker(editor);

//editor.Conteudo = "Primeira linha do texto\n";
//caretaker.Salvar();
//editor.Conteudo += "Segunda linha do texto\n";
//caretaker.Salvar();
//editor.Conteudo += "Terceira linha do texto\n";

//Console.WriteLine("Estado Atual:");
//Console.WriteLine(editor.Conteudo);

//caretaker.Desfazer(1); // Desfazendo para o estado após a segunda linha

//Console.WriteLine("Estado após desfazer:");
//Console.WriteLine(editor.Conteudo);







//Observer
//var pedidoService = new PedidoService();
//var geradorNF = new GeradorNF();
//var separadorEstoque = new SeparadorEstoque();
//var enviadorBrindes = new EnviadorBrindes();

//pedidoService.AdicionarObserver(geradorNF);
//pedidoService.AdicionarObserver(separadorEstoque);
//pedidoService.AdicionarObserver(enviadorBrindes);

//var meuPedido = new Ada.DesignPatterns.Comportamentais.Observer.Pedido(123);
//pedidoService.RealizarPedido(meuPedido);

//Console.ReadKey();

























////State
//Semaforo semaforo = new Semaforo(new EstadoVermelho());
//semaforo.MudarEstado();
//semaforo.MudarEstado();
//semaforo.MudarEstado();
//semaforo.MudarEstado();

//Console.ReadKey();

























//Strategy

//var calculador = new CalculadorDeRota(new RotaMaisRapida());
//calculador.CalcularRota("Ponto A", "Ponto B");

//// Mudar a estratégia para Rota Mais Curta
//calculador.DefinirEstrategia(new RotaMaisCurta());
//calculador.CalcularRota("Ponto A", "Ponto B");

//// Mudar a estratégia para Rota Mais Cênica
//calculador.DefinirEstrategia(new RotaMaisBarata());
//calculador.CalcularRota("Ponto A", "Ponto B");

//Console.ReadKey();

























//Template Method

//ProcessadorDeDocumento processadorPDF = new ProcessadorPDF();
//processadorPDF.ProcessarDocumento();

//ProcessadorDeDocumento processadorWord = new ProcessadorWord();
//processadorWord.ProcessarDocumento();

//Console.ReadKey();




























//Visitor
List<IEmpregado> empregados = new List<IEmpregado>
{
    new Engenheiro("Alice", 70000),
    new Ada.DesignPatterns.Comportamentais.Visitor.Gerente("Bob", 90000)
};

var visitor = new AumentoSalario();

foreach (var empregado in empregados)
{
    empregado.Accept(visitor);
}