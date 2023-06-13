using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto.");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do protudo: " + p);

            Console.WriteLine();
            Console.Write("Alterar Quantidade? (s/n) :");
            string respU = Console.ReadLine();
            if (respU == "s")
            {
                Console.Write("Deseja adicionar ou remover produtos?(+/-)");
                string respD = Console.ReadLine();

                if (respD == "+")
                {
                    Console.WriteLine();
                    Console.Write("Digite a quantidade de produtos a serem adicionados: ");
                    int qte = int.Parse(Console.ReadLine());
                    p.AdicionarProdutos(qte);

                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados: " + p);
                }
                else if (respD == "-")
                {
                    Console.WriteLine();
                    Console.Write("Digite a quantidade de produtos a serem removidos: ");
                    int qte = int.Parse(Console.ReadLine());
                    p.RemoverProdutos(qte);

                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados: " + p);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados: " + p);
                }
            }
            else if (respU == "S")
            {
                Console.Write("Deseja adicionar ou remover produtos?(+/-)");
                string respD = Console.ReadLine();

                if (respD == "+")
                {
                    Console.WriteLine();
                    Console.Write("Digite a quantidade de produtos a serem adicionados: ");
                    int qte = int.Parse(Console.ReadLine());
                    p.AdicionarProdutos(qte);

                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados: " + p);
                }
                else if (respD == "-")
                {
                    Console.WriteLine();
                    Console.Write("Digite a quantidade de produtos a serem removidos: ");
                    int qte = int.Parse(Console.ReadLine());
                    p.RemoverProdutos(qte);

                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados: " + p);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados: " + p);
                }

            }
            else if (respU == "n")
            {



                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + p);


            }
            else if (respU == "N")
            {
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + p);

            }
            else
            {
                Console.WriteLine("Comando inexistente!");
            }

        }
    }

}