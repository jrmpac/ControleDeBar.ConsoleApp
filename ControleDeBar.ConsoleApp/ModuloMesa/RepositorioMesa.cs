﻿using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public   class RepositorioMesa : RepositorioBase
    {
        public RepositorioMesa(ArrayList listaMesas)
        {
            this.listaRegistros = listaMesas;
        }

        public override Mesa SelecionarPorId(int id)
        {
            return (Mesa)base.SelecionarPorId(id);
        }
    }
}
