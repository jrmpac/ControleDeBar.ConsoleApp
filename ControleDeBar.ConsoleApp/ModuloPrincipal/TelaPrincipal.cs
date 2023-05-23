

using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPrincipal
{
    public class TelaPrincipal
    {
        private TelaGarcom telaGarcom;
        private TelaMesa telaMesa;
        private TelaProduto telaProduto;
        private TelaConta telaConta;

        public TelaPrincipal()
        {
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new List<Garcom>());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new List<Mesa>());
            RepositorioProduto repositorioProduto = new RepositorioProduto(new List<Produto>());
            RepositorioConta repositorioConta = new RepositorioConta(new List<Conta>());


            telaGarcom = new TelaGarcom(repositorioGarcom);
            telaMesa = new TelaMesa(repositorioMesa);
            telaProduto = new TelaProduto(repositorioProduto);
            telaConta = new TelaConta(repositorioConta, telaMesa, telaGarcom, telaProduto);

        }

        public ITelaCadastravel SelecionarTela() 
        {
            string opcao = ApresentarMenu();

            if (opcao == "1")
                return telaGarcom;

            else if (opcao == "2")
                return telaMesa;

            else if (opcao == "3")
                return telaProduto;

            else if (opcao == "4")
                return telaConta;

            else
                return null;

        }

        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Controle de Bar\n");

            Console.WriteLine("Digite 1 para Cadastrar Garçons");
            Console.WriteLine("Digite 2 para Cadastrar Mesas");
            Console.WriteLine("Digite 3 para Cadastrar Produtos");

            Console.WriteLine("Digite 4 para Cadastrar Conta");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }


    }
}
