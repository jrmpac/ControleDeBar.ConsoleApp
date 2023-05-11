using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloPedido;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList listaContas)
        {
            this.listaRegistros = listaContas;
        }

        public ArrayList SelecionarContasEmAberto()
        {
            ArrayList contasEmAberto = new ArrayList();

            foreach (Conta conta in listaRegistros)
            {
                if(conta.estaAberta)
                    contasEmAberto.Add(conta);
            }

            return contasEmAberto;
        }

        public override Conta SelecionarPorId(int id)
        {
            return (Conta)base.SelecionarPorId(id);
        }

        public void CadastrarConta()
        {

        }

        public ArrayList SelecionarContasFechadas(DateTime data)
        {
            ArrayList contasEmAberto = new ArrayList();

            foreach (Conta conta in listaRegistros)
            {
                if (conta.estaAberta == false && conta.data.Date == data.Date)
                    contasEmAberto.Add(conta);
            }

            return contasEmAberto;
        }
    }
}
