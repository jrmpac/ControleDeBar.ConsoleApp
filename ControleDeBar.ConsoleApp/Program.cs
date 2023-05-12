using ControleDeBar.ConsoleApp.Compartilhado;
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
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            while (true)
            {
                TelaBase tela = telaPrincipal.SelecionarTela();

                if (tela == null)
                    break;

                if (tela is TelaConta)
                    GerenciarContas(tela);
                else
                    ExecutarCadastros(tela);
            }
        }

        private static void ExecutarCadastros(TelaBase tela)
        {
            string subMenu = tela.ApresentarMenu();

            if (subMenu == "1")
            {
                tela.InserirNovoRegistro();
            }

            else if (subMenu == "2")
            {
                tela.VisualizarRegistros(true);
                Console.ReadLine();
            }

            else if (subMenu == "3")
            {
                tela.EditarRegistro();
            }

            else if (subMenu == "4")
            {
                tela.ExcluirRegistro();
            }
        }

        private static void GerenciarContas(TelaBase tela)
        {
            string subMenu = tela.ApresentarMenu();

            TelaConta telaConta = (TelaConta)tela;

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
        }
    }
}