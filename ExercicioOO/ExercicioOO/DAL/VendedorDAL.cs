using System;
using System.Collections.Generic;
using ExercicioOO.Model;

namespace ExercicioOO.DAL
{
    public class VendedorDAL
    {
        private static List<Vendedor> vendedores = new List<Vendedor>();

        public static bool cadastrarVendedores(Vendedor d){

            foreach (Vendedor cadastroVendedores in vendedores)
            {
                if(cadastroVendedores.cpf.Equals(d.cpf)){
                    
                    return false;
                }
            }
            vendedores.Add(d);
            return true;
        }

        public static List<Vendedor> TrazendoVendedores()
        {
            return vendedores;
        }
            
    }
}
