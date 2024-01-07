namespace Estoque
{


    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdcionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;

        }
    }

}
