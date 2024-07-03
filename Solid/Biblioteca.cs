namespace Solid
{
    public class Biblioteca
    {
        private GerenciadorDeLivros gerenciadorDeLivros;
        private GerenciadorDeEmprestimos gerenciadorDeEmprestimos;
        private CalculadoraDeMultas calculadoraDeMulta;
        private ArmazenamentoDeDados armazenamentoDeDados;
        private GeradorDeRelatorios geradorDeRelatorios;

        public Biblioteca()
        {
            gerenciadorDeLivros = new GerenciadorDeLivros();
            gerenciadorDeEmprestimos = new GerenciadorDeEmprestimos(gerenciadorDeLivros);
            calculadoraDeMulta = new CalculadoraDeMultas(gerenciadorDeEmprestimos);
            armazenamentoDeDados = new ArmazenamentoDeDados();
            geradorDeRelatorios = new GeradorDeRelatorios(gerenciadorDeLivros, gerenciadorDeEmprestimos);
        }

        // Métodos delegados para as classes responsáveis
        public void AdicionarLivro(Livro livro) => gerenciadorDeLivros.AdicionarLivro(livro);
        public void RemoverLivro(Livro livro) => gerenciadorDeLivros.RemoverLivro(livro);
        public List<Livro> ObterLivros() => gerenciadorDeLivros.ObterLivros();
        public void EmprestarLivro(string usuarioId, Livro livro) => gerenciadorDeEmprestimos.EmprestarLivro(usuarioId, livro);
        public void DevolverLivro(string usuarioId, Livro livro) => gerenciadorDeEmprestimos.DevolverLivro(usuarioId, livro);
        public double CalcularMulta(string usuarioId) => calculadoraDeMulta.CalcularMulta(usuarioId);
        public void SalvarDadosBiblioteca() => armazenamentoDeDados.SalvarDados();
        public void CarregarDadosBiblioteca() => armazenamentoDeDados.CarregarDados();
        public void GerarRelatorio() => geradorDeRelatorios.GerarRelatorio();
    }
}
