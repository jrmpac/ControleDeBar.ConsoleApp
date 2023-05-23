using ControleDeBar.ConsoleApp.Compartilhado;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase<RepositorioMesa, Mesa>
    {
        public TelaMesa(RepositorioMesa repositorioMesa) : base(repositorioMesa)
        {
            repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }

        protected override void MostrarTabela(List<Mesa> registros)
        {
            foreach (Mesa mesa in registros)
            {
                string ocupada = mesa.ocupada ? "Ocupada" : "Desocupada";
                Console.Write(mesa.id + ", " + mesa.numeroMesa + ", " + ocupada);
                Console.WriteLine();
            }
        }

        protected override Mesa ObterRegistro()
        {
            Console.Write("Digite o número da mesa: ");
            string numeroMesa = Console.ReadLine();


            return new Mesa (numeroMesa);
        }
    }
}
