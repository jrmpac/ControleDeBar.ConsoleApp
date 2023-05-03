using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloPedido;
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
            RepositorioPedido repositorioPedido = new RepositorioPedido(new ArrayList());
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());

            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            TelaPedido telaPedido = new TelaPedido(repositorioPedido, telaProduto, repositorioProduto);
            TelaConta telaConta = new TelaConta(repositorioConta, telaPedido, repositorioPedido, telaMesa);

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
                    //tela pedido
                    string subMenu = telaPedido.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaPedido.InserirNovoRegistro();
                    }

                    else if (subMenu == "2")
                    {
                        telaPedido.VisualizarRegistros(true);
                        Console.ReadLine();
                    }

                    else if (subMenu == "3")
                    {
                        telaPedido.EditarRegistro();
                    }

                    else if (subMenu == "4")
                    {
                        telaPedido.ExcluirRegistro();
                    }
                }

                else if (opcao == "5")
                {
                    //tela conta
                    string subMenu = telaConta.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaConta.InserirNovoRegistro();
                    }

                    else if (subMenu == "2")
                    {
                        telaConta.VisualizarRegistros(true);
                        Console.ReadLine();
                    }

                    else if (subMenu == "3")
                    {
                        telaConta.EditarRegistro();
                    }

                    else if (subMenu == "4")
                    {
                        telaConta.ExcluirRegistro();
                    }
                }
            }
        }
    }
}