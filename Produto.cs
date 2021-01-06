using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCconsole
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto(){
            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta)){
                    Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public List<Produto> Ler(){
            
            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATH);
                 
                 if (produtos != null )
                 {
                     Console.WriteLine("Opa! voce não tem nenhum produto cadastrado ainda :(");
                     return produtos;
                 }

            foreach(var objeto in linhas){
                string[] atributos = objeto.Split(";");
                Produto p = new Produto();
                p.Codigo = Int32.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.preco = float.Parse(atributos[2]);
                 produtos.Add(p);
            }

            return produtos;
        }
       

        public void InserirProduto(Produto p){
            string[] linhas = {PrepararLinhasCSV(p)};
            File.AppendAllLines(PATH, linhas );
        }
        public string PrepararLinhasCSV( Produto p){

          return $"{p.Codigo};{p.Nome}; {p.preco}";

        }
    }
}