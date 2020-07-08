using System;
using Aula34MVCConsole.Controllers;
using Aula34MVCConsole.Views;

namespace Aula34MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Buscar("39,99");
        }
    }
}
