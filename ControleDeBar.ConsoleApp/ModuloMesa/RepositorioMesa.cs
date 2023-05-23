using ControleDeBar.ConsoleApp.Compartilhado;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public   class RepositorioMesa : RepositorioBase<Mesa>
    {
        public RepositorioMesa(List<Mesa> listaMesas)
        {
            this.listaRegistros = listaMesas;
        }
    }
}
