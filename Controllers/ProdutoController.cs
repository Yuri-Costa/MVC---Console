using System.Collections.Generic;
using MVCconsole.Views;
using System;

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


     public void MostrarMenu(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("            :)            ");
            Console.ResetColor();
            Console.WriteLine("CADASTRAR PRODUTOS  -- [1]");
            Console.WriteLine("LISTA DE PRODUTOS   -- [2]");
            Console.WriteLine("SAIR                -- [0]");

                int resposta = int.Parse(Console.ReadLine());
                switch (resposta)
                {
                    case 1: Cadastrar();
                    Console.WriteLine("deseja voltar ? s/n");
                    string respost = Console.ReadLine();
                    if (respost == "s")
                    {
                        MostrarMenu();
                    }else{Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Até a proxima!");}
                        break;
                     case 2:
                     ListarProdutos();
                    Console.WriteLine("deseja voltar ? s/n");
                    string respost2 = Console.ReadLine();
                    if (respost2 == "s")
                    {
                        MostrarMenu();
                    }else{Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Até a proxima!");}

                        break;
                    case 0:Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Até a proxima!");
                        break;

                    default:
                        break;
                }
                
        }
    }
}