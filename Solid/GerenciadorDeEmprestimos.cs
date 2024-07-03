namespace Solid
{
    public class GerenciadorDeEmprestimos
    {
        private Dictionary<string, RegistroEmprestimo> registrosEmprestimo;
        private GerenciadorDeLivros gerenciadorDeLivros;

        public GerenciadorDeEmprestimos(GerenciadorDeLivros gerenciadorDeLivros)
        {
            this.registrosEmprestimo = new Dictionary<string, RegistroEmprestimo>();
            this.gerenciadorDeLivros = gerenciadorDeLivros;
        }

        public void EmprestarLivro(string usuarioId, Livro livro)
        {
            if (gerenciadorDeLivros.ObterLivros().Contains(livro))
            {
                registrosEmprestimo[usuarioId] = new RegistroEmprestimo(usuarioId, livro, DateTime.Now);
                gerenciadorDeLivros.RemoverLivro(livro);
            }
        }

        public void DevolverLivro(string usuarioId, Livro livro)
        {
            if (registrosEmprestimo.TryGetValue(usuarioId, out var registro) && registro.Livro.Equals(livro))
            {
                gerenciadorDeLivros.AdicionarLivro(livro);
                registrosEmprestimo.Remove(usuarioId);
            }
        }

        public Dictionary<string, RegistroEmprestimo> ObterRegistrosEmprestimo()
        {
            return registrosEmprestimo;
        }
    }
}
