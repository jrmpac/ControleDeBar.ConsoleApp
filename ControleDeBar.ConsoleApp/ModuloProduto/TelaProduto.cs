using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto) : base(repositorioProduto)
        {
            repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome do Produto", "Preço do Produto");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", produto.id, produto.produto_nome, produto.precoProduto);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do Produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Digite o valor do Produto");
            
            int precoProduto = Convert.ToInt32(Console.ReadLine());

            return new Produto(nomeProduto, precoProduto);
        }
    }
}
