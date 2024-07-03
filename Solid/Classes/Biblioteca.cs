namespace Solid.Classes

public class Biblioteca
{
    private List<Livro> livros;
    private Dictionary<string, RegistroEmprestimo> registrosEmprestimo;

    public Biblioteca()
    {
        this.livros = new List<Livro>();
        this.registrosEmprestimo = new Dictionary<string, RegistroEmprestimo>();
    }
}

