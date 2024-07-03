namespace Solid
{
    public class GeradorDeRelatorios
    {
        private GerenciadorDeLivros gerenciadorDeLivros;
        private GerenciadorDeEmprestimos gerenciadorDeEmprestimos;

        public GeradorDeRelatorios(GerenciadorDeLivros gerenciadorDeLivros, GerenciadorDeEmprestimos gerenciadorDeEmprestimos)
        {
            this.gerenciadorDeLivros = gerenciadorDeLivros;
            this.gerenciadorDeEmprestimos = gerenciadorDeEmprestimos;
        }

        public void GerarRelatorio()
        {
            // Código para gerar relatório de status da biblioteca
        }
    }
}
