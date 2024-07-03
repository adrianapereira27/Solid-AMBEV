namespace Solid
{
    public class CalculadoraDeMultas
    {
        private GerenciadorDeEmprestimos gerenciadorDeEmprestimos;

        public CalculadoraDeMultas(GerenciadorDeEmprestimos gerenciadorDeEmprestimos)
        {
            this.gerenciadorDeEmprestimos = gerenciadorDeEmprestimos;
        }

        public double CalcularMulta(string usuarioId)
        {
            if (gerenciadorDeEmprestimos.ObterRegistrosEmprestimo().TryGetValue(usuarioId, out var registro))
            {
                var diasEmprestados = (DateTime.Now - registro.DataEmprestimo).TotalDays;
                if (diasEmprestados > 14)
                {
                    return (diasEmprestados - 14) * 0.5;
                }
            }
            return 0.0;
        }

    }
}
