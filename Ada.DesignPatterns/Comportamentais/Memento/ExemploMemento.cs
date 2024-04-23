using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Comportamentais.Memento
{
    public class TextoMemento
    {
        public string Estado { get; }

        public TextoMemento(string estado)
        {
            Estado = estado;
        }
    }

    // Originator class
    public class EditorTexto
    {
        public string Conteudo { get; set; }

        public TextoMemento SalvarEstado()
        {
            return new TextoMemento(Conteudo);
        }

        public void RestaurarEstado(TextoMemento memento)
        {
            Conteudo = memento.Estado;
        }
    }

    // Caretaker class
    public class Caretaker
    {
        private List<TextoMemento> mementos = new List<TextoMemento>();
        private EditorTexto editor;

        public Caretaker(EditorTexto editor)
        {
            this.editor = editor;
        }

        public void Salvar()
        {
            mementos.Add(editor.SalvarEstado());
        }

        public void Desfazer(int indice)
        {
            if (indice < 0 || indice >= mementos.Count) throw new IndexOutOfRangeException("Índice fora de alcance.");
            editor.RestaurarEstado(mementos[indice]);
        }
    }
}
