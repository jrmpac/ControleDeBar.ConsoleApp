using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPedido
{
    public class TelaPedido : TelaBase
    {
        private TelaProduto telaProduto;
        private RepositorioProduto repositorioProduto;
        public TelaPedido(RepositorioPedido repositorioPedido, TelaProduto telaProduto, RepositorioProduto repositorioProduto) : base(repositorioPedido)
        {
            this.repositorioProduto = repositorioProduto;
            this.telaProduto = telaProduto;
            this.repositorioBase = repositorioPedido;

            nomeEntidade = "Pedido";
            sufixo = "s";            
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -30}", "Id", "Produto","Quantidade", "Valor do Pedido");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Pedido pedido in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -30}", pedido.id, pedido.produto.produto_nome, pedido.quantidade, pedido.totalParcial);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {                       
            telaProduto.VisualizarRegistros(false);
            // selecionar um produto a partir do id


            Console.Write("Digite o id do produto: ");
            int idProduto = Convert.ToInt32(Console.ReadLine());
            Produto produto = repositorioProduto.SelecionarPorId(idProduto);

            Console.Write("Digite a quantidade do Produto: ");
            decimal quantidade = Convert.ToInt32(Console.ReadLine());

            decimal totalParcial = produto.precoProduto * quantidade;

            return new Pedido(produto, quantidade, totalParcial);
        }

        private Produto ObterProduto()
        {
            telaProduto.VisualizarRegistros(false);

            Produto produto = (Produto)telaProduto.EncontrarRegistro("Digite o id do produto: ");

            Console.WriteLine();

            return produto;
        }
    }
}
