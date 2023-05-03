using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public TelaMesa(RepositorioMesa repositorioMesa) : base(repositorioMesa)
        {
            repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Mesa mesa in registros)
            {
                string ocupada = mesa.ocupada ? "Ocupada" : "Desocupada";
                Console.Write(mesa.id + ", " + mesa.numeroMesa + ", " + ocupada);
                Console.WriteLine();
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o número da mesa: ");
            string numeroMesa = Console.ReadLine();


            return new Mesa (numeroMesa);
        }
    }
}
