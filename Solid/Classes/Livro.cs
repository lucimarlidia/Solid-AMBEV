namespace Solid.Classes

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    // Métodos relacionados ao gerenciamento de livros
    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void RemoverLivro(Livro livro)
    {
        livros.Remove(livro);
    }

    public List<Livro> ObterLivros()
    {
        return livros;
    }
}

