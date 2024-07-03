namespace Solid
{
    public class GerenciadorDeLivros
    {
        private List<Livro> livros;

        public GerenciadorDeLivros()
        {
            this.livros = new List<Livro>();
        }

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
}
