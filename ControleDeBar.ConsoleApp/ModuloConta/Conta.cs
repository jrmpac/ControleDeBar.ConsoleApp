using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloPedido;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Pedido pedido;
        public decimal valorTotal;
        public Mesa mesa;
        public DateTime data;

        public Conta(Pedido pedido, Mesa mesa, DateTime data)
        {
            this.pedido = pedido;
            this.mesa = mesa;
            this.data = data;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta contaAtualizada = (Conta)registroAtualizado;

            this.pedido = contaAtualizada.pedido;
            this.mesa = contaAtualizada.mesa;
            this.data = contaAtualizada.data;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (mesa == null)
                erros.Add("O campo \"mesa\" é obrigatório");

            if (data < DateTime.Now.Date)
                erros.Add("O campo \"data\" deve ser maior que a data atual");


            return erros;
        }
    }
}
