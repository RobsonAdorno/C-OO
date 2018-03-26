using System;
using System.Collections.Generic;
using ExercicioOO.Model;

namespace ExercicioOO.DAL
{
    public class ProdutoDAL
    {

        private static List<Produto> produtos = new List<Produto>();

        public static bool CadastrarProduto(Produto p ){
               
            foreach (Produto production in produtos)
            {
                if (production.nome.Equals(p.nome)){

                    return false;
                }

            }

            produtos.Add(p);
            return true;
        }

        public static List<Produto> TrazerProduto(){
            return produtos;
        }
    }
}
