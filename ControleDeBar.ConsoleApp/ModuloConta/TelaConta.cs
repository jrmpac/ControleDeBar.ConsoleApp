using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloPedido;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class TelaConta : TelaBase
    {
        private RepositorioConta repositorioConta;
        private TelaPedido telaPedido;
        private RepositorioPedido repositorioPedido;
        private TelaMesa telaMesa;

        public TelaConta(RepositorioConta repositorioConta, TelaPedido telaPedido, RepositorioPedido repositorioPedido, TelaMesa telaMesa)
        {
            this.repositorioConta = repositorioConta;
            this.telaPedido = telaPedido;
            this.repositorioPedido = repositorioPedido;
            this.telaMesa = telaMesa;

            nomeEntidade = "Conta";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -30}", "Id", "Quantidade de Pedidos", "Id da mesa", "Data", "Status");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Conta conta in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -30}", conta.id, conta.pedido, conta.mesa.id, conta.data);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {           
            Mesa mesa = ObterMesa();

            Pedido pedido = ObterPedido();

            DateTime data = DateTime.Now.Date;

            return new Conta(pedido, mesa, data);
        }

        private Mesa ObterMesa()
        {
            telaMesa.VisualizarRegistros(false);

            Mesa mesa = (Mesa)telaMesa.EncontrarRegistro("Digite o id da mesa: ");

            Console.WriteLine();

            return mesa;
        }

        private Pedido ObterPedido()
        {
            telaPedido.VisualizarRegistros(false);

            Pedido pedido = (Pedido)telaPedido.EncontrarRegistro("Digite o id do pedido: ");

            Console.WriteLine();

            return pedido;
        }
    }
}
