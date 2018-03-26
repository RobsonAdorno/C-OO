using System;
using ExercicioOO.Model;
using ExercicioOO.DAL;

namespace ExercicioOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente c;
            string op;
              do
            {

            Console.WriteLine("Por favor, digite a opção desejada logo abaixo:");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1) Cadastrar Clientes.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("2) Listar Clientes.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("3) Cadastrar Vendendor.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("4) Listar Vendendor.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("5) Cadastrar Produtos.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("6) Listar Produtos.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("7) Registar Vendas.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("8) Listar Vendas");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("9) Listar Vendas por Ciente");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("0) Sair.");
            op = Console.ReadLine();
            Console.ReadKey();

                switch (op)
                {
                    case "1":
                        c = new Cliente();
                        Console.WriteLine("Você selecionou a opção Cadastrar Clientes");
                        Console.WriteLine("Digite o nome do Cliente");
                        c.nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do Cliente");
                        c.cpf = Console.ReadLine();
                        ClienteDAO.CadastrarCliente(c);
                        Console.WriteLine("Pressione algum botao para voltar ao menu");
                        Console.ReadKey();
                        break;
                   
                    case "2":
                        Console.WriteLine("Você selecionou a opção Listar Clientes");
                        foreach (Cliente ClienteCadsatrado in ClienteDAO.TrazerClientes())
                        {
                            Console.WriteLine("Esse eh o nome!!" + ClienteCadsatrado.nome);
                            Console.WriteLine("Esse eh o seu cpf!!" +  ClienteCadsatrado.cpf);
                        }
                        Console.WriteLine("Pressione algum botao para voltar ao menu");
                        Console.ReadKey();
                        break;

                    case "0":
                        Console.WriteLine("Saindo da aplicação...");

                        break;

                    default:
                        Console.WriteLine("Opção inválida, digite novamente!");
                        break;
                }
            } while (op != "0");

        }
    }
}
