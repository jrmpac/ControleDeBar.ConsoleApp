﻿using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloPedido;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class TelaConta : TelaBase
    {
        private RepositorioConta repositorioConta;

        private TelaProduto telaProduto;
        private TelaGarcom telaGarcom;
        private TelaPedido telaPedido;
        private TelaMesa telaMesa;


        public TelaConta(RepositorioConta repositorioConta, TelaMesa telaMesa, TelaGarcom telaGarcom, TelaProduto telaProduto) : base(repositorioConta)
        {
            this.repositorioBase = repositorioConta;
            this.repositorioConta = repositorioConta;

            this.telaMesa = telaMesa;
            this.telaGarcom = telaGarcom;
            this.telaProduto = telaProduto;

            nomeEntidade = "Conta";
            sufixo = "s";
        }

        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Contas \n");

            Console.WriteLine("Digite 1 para Abrir Nova Conta");
            Console.WriteLine("Digite 2 para Registrar Pedidos");
            Console.WriteLine("Digite 3 para Fechar Conta");
            Console.WriteLine("Digite 4 para Visualizar Contas Abertas");

            Console.WriteLine("Digite 5 para Visualizar Faturamento do Dia");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("{0, -10} | {1, -20} | {2, -22}", "Id", "Numero da Mesa", "Nome do Garçom");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            Console.ResetColor();

            foreach (Conta conta in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -22}", conta.id, conta.mesa.numeroMesa, conta.garcom.nomeGarcom);

                foreach (Pedido pedido in conta.pedidos)
                {
                    Console.WriteLine();

                    Console.WriteLine("{0, -20} | {1, -20} ", "Produto", "Quantidade");

                    Console.Write("{0, -20} | {1, -20} ",  pedido.produto.produto_nome, pedido.quantidade);

                    Console.WriteLine();
                }

                Console.WriteLine("----------------------------------------------------");
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Mesa mesa = ObterMesa();

            Garcom garcom = ObterGarcom();


            return new Conta(mesa, garcom);
        }

        private Mesa ObterMesa()
        {
            telaMesa.VisualizarRegistros(false);

            Mesa mesa = (Mesa)telaMesa.EncontrarRegistro("Digite o id da mesa: ");

            Console.WriteLine();

            return mesa;
        }

        private Garcom ObterGarcom()
        {
            telaGarcom.VisualizarRegistros(false);

            Garcom garcom = (Garcom)telaGarcom.EncontrarRegistro("Digite o id do Garçom: ");

            Console.WriteLine();

            return garcom;
        }

        public void AbrirNovaConta()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}{sufixo}", "Inserindo um novo registro...");

            Conta conta = (Conta)ObterRegistro();

            if (TemErrosDeValidacao(conta))
            {
                InserirNovoRegistro(); //chamada recursiva

                return;
            }

            repositorioBase.Inserir(conta);

            AdicionarPedidos(conta);

            MostrarMensagem("Registro inserido com sucesso!", ConsoleColor.Green);
        }

        public bool VisualizarContasAbertas()
        {
            ArrayList contasEmAberto = repositorioConta.SelecionarContasEmAberto();

            if (contasEmAberto.Count > 0)
            {
                MostrarMensagem("Nenhuma conta em aberto", ConsoleColor.DarkYellow);
                return false;
            }

            MostrarTabela(contasEmAberto);

            return contasEmAberto.Count > 0;
        }

        public void RegistrarPedidos()
        {
            VisualizarContasAbertas();

            Conta contaSelecionada = (Conta)EncontrarRegistro("Digite o id da Conta: ");

            Console.Write("Selecionar produtos? [s] ou [n]");

            Console.WriteLine(" -> ");

            string opcao = Console.ReadLine();


            while (opcao == "s")
            {
                Produto produto = ObterProduto();

                Console.WriteLine("Digite a quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                contaSelecionada.RegistrarPedido(produto, quantidade);

                Console.Write("Selecionar produtos? [s] ou [n]");

                Console.WriteLine(" -> ");

                opcao = Console.ReadLine();
            }
        }

        private void AdicionarPedidos(Conta contaSelecionada)
        {
            Console.WriteLine("Selecionar produtos? [s] ou [n]");

            Console.Write(" -> ");

            string opcao = Console.ReadLine();

            while (opcao == "s")
            {
                Produto produto = ObterProduto();

                Console.Write("Digite a quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                contaSelecionada.RegistrarPedido(produto, quantidade);

                Console.WriteLine("Selecionar mais produtos? [s] ou [n]");

                Console.Write(" -> ");

                opcao = Console.ReadLine();
            }
        }

        private Produto ObterProduto()
        {
            telaProduto.VisualizarRegistros(false);

            Produto produto = (Produto)telaProduto.EncontrarRegistro("Digite o id do Produto: ");

            Console.WriteLine();

            return produto;
        }

        public void FecharConta()
        {
            bool temContasEmAberto = VisualizarContasAbertas();

            if (temContasEmAberto == false)
                return;

            Conta contaSelecionada = (Conta)EncontrarRegistro("Digite o id da Conta: ");

            contaSelecionada.Fechar();
        }
    }
}
