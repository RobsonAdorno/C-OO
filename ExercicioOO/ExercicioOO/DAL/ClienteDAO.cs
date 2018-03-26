using System;
using ExercicioOO.Model;
using System.Collections.Generic;


namespace ExercicioOO.DAL
{
    public class ClienteDAO
    {

        private static List<Cliente> clientes = new List<Cliente>();

        public static List<Cliente> BuscarClientes()
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                Console.WriteLine(clienteCadastrado);
            }
            return clientes;
        }

        public static List<Cliente> CadastrarCliente(Cliente c){

            clientes.Add(c);

            return clientes;

        }

        public static List<Cliente> TrazerClientes()
        {

            return clientes;
        }
    }
}
