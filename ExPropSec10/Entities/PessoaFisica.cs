namespace ExPropSec10.Entities;

internal class PessoaFisica : Pessoa
{
    public double GastosComSaude { get; set; }
    public double ImpostoPago { get; set; }

    public PessoaFisica()
    {
    }
    public PessoaFisica(string nome, double rendaAnual) : base(nome, rendaAnual)
    {
        Nome = nome;
        RendaAnual = rendaAnual;

    }
    public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
    {
        Nome = nome;
        RendaAnual = rendaAnual;
        GastosComSaude = gastosComSaude;

    }

    public override double Imposto()
    {
        if (RendaAnual <= 20000)
        {
            return (RendaAnual * 0.15) - (GastosComSaude * 0.5);
        }
        else
        {
            return (RendaAnual * 0.25) - (GastosComSaude * 0.5);
        }

    }
}