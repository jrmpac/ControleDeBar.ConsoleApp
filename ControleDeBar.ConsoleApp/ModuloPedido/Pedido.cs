using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPedido
{
    public class Pedido : EntidadeBase
    {
        public int quantidadeDoProduto;
        public int totalParcial;
        public Produto produto;

        public Pedido(Produto produto, int quantidadeProduto)
        {           

            this.produto = produto;
            this.quantidadeDoProduto = quantidadeProduto;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Pedido pedidoAtualizado = (Pedido) registroAtualizado;

            this.produto = pedidoAtualizado.produto;
            this.quantidadeDoProduto = pedidoAtualizado.quantidadeDoProduto;
            this.totalParcial = pedidoAtualizado.totalParcial;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (produto == null)
                erros.Add("O campo \"produto\" é obrigatório");

            if (quantidadeDoProduto <= 0)
                erros.Add("O campo \"quantidade\" não pode ser menor que 0");

            if (totalParcial < 0)
                erros.Add("O campo \"total\" é obrigatório");


            return erros;
        }
    }
}
