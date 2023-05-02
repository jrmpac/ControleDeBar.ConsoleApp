

using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloGarcom
{
    public class TelaGarcom : TelaBase
    {
        public TelaGarcom(RepositorioGarcom repositorioGarcom)
        {
            repositorioBase = repositorioGarcom;
            nomeEntidade = "Garçom";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome do Garçom", "CPF do Garçom");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Garcom garcom in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", garcom.id, garcom.nomeGarcom, garcom.cpfGarcom);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do Garçom: ");
            string nomeGarcom = Console.ReadLine();

            Console.Write("Digite o CPF do Garçom");
            string cpfGarcom = Console.ReadLine();

            return new Garcom(nomeGarcom, cpfGarcom);
        }
    }
}
