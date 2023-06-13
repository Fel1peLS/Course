using System.Globalization;
namespace Course
{
    internal class Produto
    {
        /*ATRIBUTOS*/
        /*Preco e Quantidade são propriedades automaticas.*/

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        /*CONSTRUTORES*/

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        /*PROPRIEDADES*/

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }





        /*METODOS*/

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade
                + " unidades, Toatal: $"
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}