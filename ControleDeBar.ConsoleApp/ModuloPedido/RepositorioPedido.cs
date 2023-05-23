using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloProduto;

namespace ControleDeBar.ConsoleApp.ModuloPedido
{
    public class RepositorioPedido : RepositorioBase<Pedido>
    {
        public RepositorioPedido(List<Pedido> listaPedidos)
        {
            this.listaRegistros = listaPedidos;
        }
    }
}
