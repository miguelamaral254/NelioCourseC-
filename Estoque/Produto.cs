namespace Estoque;

class Produto
{
    private string _nome;
    private double _preco;
    private int _quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string Nome {
        get { return _nome;}
        set { _nome = value;}

    }
    public double Preco {
        get {return _preco;}
    }
    public int Quantidade {
        get {return _quantidade;}
    }
    /*
        public string GetNome()
        {
            return _nome;

        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }
    public double GetPreco()
    {
        return _preco;
    }
    public int GetQuantidade()
    {
        return _quantidade;
    }
    */
    public double ValorTotalEmEstoque()
    {
        return _preco * _quantidade;
    }

    public void AdcionarProdutos(int quantidade)
    {
        _quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade)
    {
        _quantidade -= quantidade;

    }
    /*
    public override string ToString()
    {
        return _nome +
         ", $" +
          _preco.ToString("F2") +
        ", " +
        _quantidade +
        " unidades, Total: $" +
        ValorTotalEmEstoque().ToString("F2");
    }
*/
}
