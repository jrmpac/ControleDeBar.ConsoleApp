using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPedido
{
    public class Pedido : EntidadeBase<Pedido>
    {
        public decimal quantidade;
        public decimal totalParcial;
        public Produto produto;

        public Pedido(Produto produto, int quantidadeEscolhida)
        {
            this.produto = produto;
            quantidade = quantidadeEscolhida;
        }

        public Pedido(Produto produto, decimal quantidade, decimal totalParcial)
        {

            this.produto = produto;
            this.quantidade = quantidade;
            this.totalParcial = totalParcial;

        }

        public override void AtualizarInformacoes(Pedido pedidoAtualizado)
        {
            produto = pedidoAtualizado.produto;
            quantidade = pedidoAtualizado.quantidade;
            totalParcial = pedidoAtualizado.totalParcial;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (produto == null)
                erros.Add("O campo \"produto\" é obrigatório");

            if (quantidade <= 0)
                erros.Add("O campo \"quantidade\" não pode ser menor que 0");

            if (totalParcial < 0)
                erros.Add("O campo \"total\" é obrigatório");


            return erros;
        }

        internal decimal CalcularTotalParcial()
        {
            return produto.precoProduto * quantidade;
        }
    }
}
