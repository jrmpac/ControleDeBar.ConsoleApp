using ControleDeBar.ConsoleApp.Compartilhado;

namespace ControleDeBar.ConsoleApp.ModuloFuncionario
{
    public class TelaFuncionario : TelaBase<RepositorioFuncionario, Funcionario>
    {
        public TelaFuncionario(RepositorioFuncionario repositorioBase) : base(repositorioBase)
        {
        }

        protected override void MostrarTabela(List<Funcionario> registros)
        {
            throw new NotImplementedException();
        }

        protected override Funcionario ObterRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
