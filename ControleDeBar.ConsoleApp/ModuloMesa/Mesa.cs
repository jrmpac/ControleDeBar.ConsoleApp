using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase<Mesa>
    {
        public string numeroMesa;
        public bool ocupada;

        public Mesa(string numeroMesa)
        {
            this.numeroMesa = numeroMesa;
        }

        public override void AtualizarInformacoes(Mesa mesaAtualizada)
        {            
            numeroMesa = mesaAtualizada.numeroMesa;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(numeroMesa.Trim()))
            {
                erros.Add("O campo \"Número da Mesa\" é obrigatorio");
            }

            return erros;
        }

        public void Desocupar()
        {
            ocupada = false;
        }

        public void Ocupar()
        {
            ocupada = true;
        }
    }
}
