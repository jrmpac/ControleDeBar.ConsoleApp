using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string produto_nome;
        public int precoProduto;

        public Produto(string produto, int precoProduto)
        {
            this.produto_nome = produto;
            this.precoProduto = precoProduto;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto produtoAtualizado = (Produto)registroAtualizado;

            this.produto_nome = produtoAtualizado.produto_nome;
            this.precoProduto = produtoAtualizado.precoProduto;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();
            
            if (produto_nome == null)
                erros.Add("O campo \"produto\" é obrigatório");

            if (produto_nome.Length <= 3)
                erros.Add("O campo \"produto\" precisa ter mais que 3 digitos");

            if (precoProduto < 0)
                erros.Add("O campo \"preço\" não pode ser menor que 0");

            return erros;
        }
    }
}
