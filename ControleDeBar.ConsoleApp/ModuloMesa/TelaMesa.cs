using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20}", "Número da mesa", "Nome do Cliente");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20}", mesa.numeroMesa, mesa.nomeCliente);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o número da mesa: ");
            string numeroMesa = Console.ReadLine();

            Console.Write("Digite o responsavel pela comanda na mesa: ");
            string nomeCliente = Console.ReadLine();

            return new Mesa (numeroMesa, nomeCliente);
        }
    }
}
