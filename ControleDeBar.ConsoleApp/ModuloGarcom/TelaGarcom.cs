

using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloGarcom
{
    public class TelaGarcom : TelaBase<RepositorioGarcom, Garcom>
    {
        public TelaGarcom(RepositorioGarcom repositorioGarcom) : base(repositorioGarcom)
        {
            repositorioBase = repositorioGarcom;
            nomeEntidade = "Garçom";
        }

        protected override void MostrarTabela(List<Garcom> registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome do Garçom", "CPF do Garçom");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Garcom garcom in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", garcom.id, garcom.nomeGarcom, garcom.cpfGarcom);
            }
        }

        protected override Garcom ObterRegistro()
        {
            Console.Write("Digite o nome do Garçom: ");
            string nomeGarcom = Console.ReadLine();

            Console.Write("Digite o CPF do Garçom");
            string cpfGarcom = Console.ReadLine();

            return new Garcom(nomeGarcom, cpfGarcom);
        }
    }
}
