using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class RepositorioProduto : RepositorioBase
    {
        public RepositorioProduto(ArrayList listaProdutos)
        {
            this.listaRegistros = listaProdutos;
        }

        public override Produto SelecionarPorId(int id)
        {
            return (Produto)base.SelecionarPorId(id);
        }
    }
}
