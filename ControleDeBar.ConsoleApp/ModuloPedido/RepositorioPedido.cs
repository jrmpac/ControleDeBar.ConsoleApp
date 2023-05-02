

using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPedido
{
    public class RepositorioPedido : RepositorioBase
    {
        public RepositorioPedido(ArrayList listaPedidos)
        {
            this.listaRegistros = listaPedidos;
        }

        public override Pedido SelecionarPorId(int id)
        {
            return (Pedido)base.SelecionarPorId(id);
        }
    }
}
