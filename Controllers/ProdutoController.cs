using System.Collections.Generic;
using MVCconsole.Views;

namespace MVCconsole.Controllers
{
    public class ProdutoController
    {
        Produto p = new Produto();


        ProdutoViews pv = new ProdutoViews();

        public void ListarProdutos(){         
            pv.Listar(p.Ler());
        }
    public void Cadastrar(){
        p.InserirProduto(pv.CadastrarProduto());
    }
    }
}