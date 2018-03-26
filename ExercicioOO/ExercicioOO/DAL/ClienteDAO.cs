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

        public static bool CadastrarCliente(Cliente c){

            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.cpf.Equals(c.cpf))
                {
                    return false;
                }
            }

            clientes.Add(c);
            return true;

        }

        public static List<Cliente> TrazerClientes()
        {

            return clientes;
        }
    }
}
