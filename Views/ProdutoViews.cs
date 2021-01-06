using System.Collections.Generic;
using System;

namespace MVCconsole.Views
{
    public class ProdutoViews
    {
        
        public void Listar(List<Produto> produtos){
                foreach (var item in produtos)
                {
                    Console.WriteLine($"Produto: [{item.Codigo}]");
                    Console.WriteLine($"nome: {item.Nome}");
                    Console.WriteLine($"Preço: R${item.preco.ToString("n2")}");
                    Console.WriteLine("");
                    
                }
                
        }

        public Produto CadastrarProduto(){
            Produto p = new Produto();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Digite um codigo:");
            p.Codigo = int.Parse(Console.ReadLine());

             Console.WriteLine($"Digite um nome:");
            p.Nome = Console.ReadLine();

             Console.WriteLine($"Digite um preço:");
            p.preco = float.Parse(Console.ReadLine());
            Console.ResetColor();
            return p;
            
        }


    }
}