using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class RepositorioProduto : RepositorioBase<Produto>
    {
        public RepositorioProduto(List<Produto> listaProdutos)
        {
            this.listaRegistros = listaProdutos;
        }
       
    }
}
