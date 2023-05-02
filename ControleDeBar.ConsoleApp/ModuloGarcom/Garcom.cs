using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string nomeGarcom;
        public string cpfGarcom;

        public Garcom(string nomeGarcom, string cpfGarcom)
        {
            this.nomeGarcom = nomeGarcom;
            this.cpfGarcom = cpfGarcom;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom GarcomAtualizado = (Garcom)registroAtualizado;

            this.nomeGarcom = GarcomAtualizado.nomeGarcom;
            this.cpfGarcom = GarcomAtualizado.cpfGarcom;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nomeGarcom.Trim()))
                erros.Add("O campo \"numero da mesa\" é obrigatório");

            if (nomeGarcom.Length <= 3)
                erros.Add("O campo \"numero da mesa\" precisa ter mais que 3 digito");

            if (string.IsNullOrEmpty(cpfGarcom.Trim()))
                erros.Add("O campo \"CPF do garçom\" é obrigatório");


            return erros;
        }
    }
}
