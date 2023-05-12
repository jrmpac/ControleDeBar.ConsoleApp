using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloPrincipal;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());            
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());

            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            TelaConta telaConta = new TelaConta(repositorioConta, telaMesa, telaGarcom, telaProduto);

            TelaPrincipal principal = new TelaPrincipal();

            while (true)
            {

                string opcao = principal.ApresentarMenu();

                if (opcao == "s")
                {
                    break;
                }

                if (opcao == "1")
                {
                    //tela garçom
                    string subMenu = telaGarcom.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaGarcom.InserirNovoRegistro();
                    }

                    else if (subMenu == "2")
                    {
                        telaGarcom.VisualizarRegistros(true);
                        Console.ReadLine();
                    }

                    else if (subMenu == "3")
                    {
                        telaGarcom.EditarRegistro();
                    }

                    else if (subMenu == "4")
                    {
                        telaGarcom.ExcluirRegistro();
                    }
                }

                else if (opcao == "2")
                {
                    //tela mesa
                    string subMenu = telaMesa.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaMesa.InserirNovoRegistro();
                    }

                    else if (subMenu == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }

                    else if (subMenu == "3")
                    {
                        telaMesa.EditarRegistro();
                    }

                    else if (subMenu == "4")
                    {
                        telaMesa.ExcluirRegistro();
                    }
                }

                else if (opcao == "3")
                {
                    //tela produto
                    string subMenu = telaProduto.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaProduto.InserirNovoRegistro();
                    }

                    else if (subMenu == "2")
                    {
                        telaProduto.VisualizarRegistros(true);
                        Console.ReadLine();
                    }

                    else if (subMenu == "3")
                    {
                        telaProduto.EditarRegistro();
                    }

                    else if (subMenu == "4")
                    {
                        telaProduto.ExcluirRegistro();
                    }
                }
                
                else if (opcao == "4")
                {
                    //tela conta
                    string subMenu = telaConta.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaConta.AbrirNovaConta();
                    }

                    else if (subMenu == "2")
                    {
                        telaConta.RegistrarPedidos();
                    }

                    else if (subMenu == "3")
                    {
                        telaConta.FecharConta();
                    }

                    else if (subMenu == "4")
                    {
                        telaConta.VisualizarContasAbertas();
                        Console.ReadLine();
                    }         
                    else if (subMenu == "5")
                    {
                        telaConta.VisualizarFaturamentoDoDia();
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}