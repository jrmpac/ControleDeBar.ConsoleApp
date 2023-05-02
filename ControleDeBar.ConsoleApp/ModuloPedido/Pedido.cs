using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPedido
{
    public class Pedido : EntidadeBase
    {
        public decimal quantidade;
        public decimal totalParcial;
        public Produto produto;

        public Pedido(Produto produto, decimal quantidade, decimal totalParcial)
        {           

            this.produto = produto;
            this.quantidade = quantidade;
            this.totalParcial = totalParcial;

        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Pedido pedidoAtualizado = (Pedido) registroAtualizado;

            this.produto = pedidoAtualizado.produto;
            this.quantidade = pedidoAtualizado.quantidade;
            this.totalParcial = pedidoAtualizado.totalParcial;
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
    }
}
