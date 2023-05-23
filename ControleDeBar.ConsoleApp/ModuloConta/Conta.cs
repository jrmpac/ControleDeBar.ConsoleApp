using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloPedido;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase<Conta>
    {
        public Mesa mesa;
        public ArrayList pedidos;
        public Garcom garcom;
        public bool estaAberta;

        public DateTime data;

        public Conta(Mesa mesa, Garcom garcom, DateTime dataAbertura)
        {
            this.mesa = mesa;
            this.garcom = garcom;
            this.estaAberta = true;
            this.pedidos = new ArrayList();
            this.data = dataAbertura;

            Abrir();                  
        }

        private void Abrir()
        {
            estaAberta = true;
            mesa.Ocupar();
        }

        public void RegistrarPedido(Produto produto, int quantidadeEscolhida)
        {
            Pedido novoPedido = new Pedido(produto, quantidadeEscolhida);

            pedidos.Add(novoPedido);
        }

        public decimal CalcularValorTotal()
        {
            decimal total = 0;

            foreach (Pedido pedido in pedidos)
            {
                decimal totalPedido = pedido.CalcularTotalParcial();

                total += totalPedido;
            }

            return total;
        }

        public override void AtualizarInformacoes(Conta contaAtualizada)
        {            
            garcom = contaAtualizada.garcom;
            mesa = contaAtualizada.mesa;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (garcom == null)
                erros.Add("O campo \"Garçom\" é obrigatório");

            if (mesa == null)
                erros.Add("O campo \"Mesa\" é obrigatório");


            return erros;
        }

        public void Fechar()
        {
            estaAberta = false;
            mesa.Desocupar();
        }
    }
}
