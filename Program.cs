using System;
using MVCconsole.Controllers;

namespace MVCconsole
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController pc = new ProdutoController();
           pc.Cadastrar();
           pc.ListarProdutos();

           
            
        }
    }
}
