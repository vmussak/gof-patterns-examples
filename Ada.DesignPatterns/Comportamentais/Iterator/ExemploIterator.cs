using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Comportamentais.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    // Aggregate interface
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }

    // Concrete Aggregate
    public class Biblioteca : IAggregate<Livro>
    {
        private List<Livro> _livros = new List<Livro>();

        public void Add(Livro livro)
        {
            _livros.Add(livro);
        }

        public IIterator<Livro> CreateIterator()
        {
            return new BibliotecaIterator(this);
        }

        public int Count
        {
            get { return _livros.Count; }
        }

        public Livro Get(int index)
        {
            return _livros[index];
        }
    }

    // Concrete Iterator
    public class BibliotecaIterator : IIterator<Livro>
    {
        private Biblioteca _biblioteca;
        private int _current = 0;

        public BibliotecaIterator(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
        }

        public bool HasNext()
        {
            return _current < _biblioteca.Count;
        }

        public Livro Next()
        {
            return _biblioteca.Get(_current++);
        }
    }

    // Supporting Livro class
    public class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}
