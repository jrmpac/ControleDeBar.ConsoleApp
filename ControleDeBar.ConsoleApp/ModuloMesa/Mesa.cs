using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string numeroMesa;
        public string nomeCliente;

        public Mesa(string numeroMesa, string nomeCliente)
        {
            this.numeroMesa = numeroMesa;
            this.nomeCliente = nomeCliente;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa) registroAtualizado;

            this.numeroMesa = mesaAtualizada.numeroMesa;
            this.nomeCliente = mesaAtualizada.nomeCliente;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(numeroMesa.Trim()))
                erros.Add("O campo \"numero da mesa\" é obrigatório");

            if (numeroMesa.Length <= 1)
                erros.Add("O campo \"numero da mesa\" precisa ter mais que 1 digito");

            if (string.IsNullOrEmpty(nomeCliente.Trim()))
                erros.Add("O campo \"nome do cliente\" é obrigatório");


            return erros;
        }
    }
}
