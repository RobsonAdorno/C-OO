using System;
using ExercicioOO.Model;
using ExercicioOO.DAL;
using ExercicioOO.Beans;

namespace ExercicioOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente c;
            Vendedor v;
            Produto p;
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
                        if (ValidateCPF.ValidandoCPF(c.cpf) == false){
                            Console.WriteLine("CPF INVÁLIDO");
                            Console.WriteLine("Pressione algum botao para voltar ao menu");
                            Console.ReadKey();
                            break;
                        }
                        if (ClienteDAO.CadastrarCliente(c)){
                            Console.WriteLine("Cadastro Efetuado com sucesso");
                        }else{
                            Console.WriteLine("CPF Duplicado, voltando ao menu principal...");
                            break;
                        }
                       
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

                    case "3":
                        v = new Vendedor();
                        Console.WriteLine("Você selecionou a opção Cadastrar Vendedor");
                        Console.WriteLine("Digite o nome do Vendedor");
                        v.nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do Vendedor");
                        v.cpf = Console.ReadLine();

                        if (ValidateCPF.ValidandoCPF(v.cpf) == false){
                            Console.WriteLine("CPF INVÁLIDO!");
                            Console.WriteLine("Pressione algum botao para voltar ao menu");
                            Console.ReadKey();
                            break;
                        }

                        if(VendedorDAL.cadastrarVendedores(v)){

                            Console.WriteLine("Cadastro efetuado com sucesso!!");
                           


                        }else{
                            Console.WriteLine("CPF Duplicado, cadastro inválido!");
                            Console.WriteLine("Pressione algum botao para voltar ao menu");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("Pressione algum botao para voltar ao menu");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Você selecionou a opção Listar Clientes");

                        foreach (Vendedor vender  in VendedorDAL.TrazendoVendedores())
                        {
                            Console.WriteLine("Os nomes dos vendedores: " + vender.nome);
                            Console.WriteLine("O CPF dos vendedores: " + vender.cpf);

                        }
                        Console.WriteLine("Pressione algum botao para voltar ao menu");
                        Console.ReadKey();
                        break;

                    case "5":
                        p = new Produto();
                        Console.WriteLine("Você selecionou a opção Cadastrar Produtos");
                        Console.WriteLine("Digite o nome do Produto!");
                        p.nome = Console.ReadLine();
                        Console.WriteLine("Digite o preço do Produto!");
                        p.preco = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade do Produto!");
                        p.quantidade = int.Parse(Console.ReadLine());


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
